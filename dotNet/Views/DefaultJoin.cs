using System;
using System.Drawing;
using System.Windows.Forms;
using Atomus.Service;
using Atomus.Control.Join.Controllers;
using Atomus.Control.Join.Models;
using System.Text;

namespace Atomus.Control.Join
{
    public partial class DefaultJoin : UserControl, IAction
    {
        private AtomusControlEventHandler beforeActionEventHandler;
        private AtomusControlEventHandler afterActionEventHandler;

        private Point point;
        
        #region Init
        public DefaultJoin()
        {
            InitializeComponent();

            this.point = new Point(0, 0);
        }
        #endregion

        #region Dictionary
        #endregion

        #region Spread
        #endregion

        #region IO
        object IAction.ControlAction(ICore sender, AtomusControlArgs e)
        {
            try
            {
                this.beforeActionEventHandler?.Invoke(this, e);

                switch (e.Action)
                {
                    case "UserAgreement":
                        this.UserAgreement_Detail.Text = (string)e.Value;
                        return true;

                    case "UserAgreement.Rtf":
                        this.UserAgreement_Detail.Rtf = (string)e.Value;
                        return true;

                    case "PersonalInformationCollectionAgreement":
                        this.PersonalInformationCollectionAgreement_Detail.Text = (string)e.Value;
                        return true;

                    case "PersonalInformationCollectionAgreement.Rtf":
                        this.PersonalInformationCollectionAgreement_Detail.Rtf = (string)e.Value;
                        return true;

                    default:
                        throw new AtomusException("'{0}'은 처리할 수 없는 Action 입니다.".Translate(e.Action));
                }
            }
            finally
            {
                this.afterActionEventHandler?.Invoke(this, e);
            }
        }

        IErrorAlert errorAlertJoin;
        private async void Join()
        {
            IResponse result;

            try
            {
                this.errorAlertJoin = this.errorAlertJoin ?? this.ErrorAlert(false);
                this.errorAlertJoin.Clear();
                this.errorAlertJoin.Checked(this.UserAgreement, this.PersonalInformationCollectionAgreement);
                this.errorAlertJoin.TextNotEqual("", this.EMAIL, this.EMAIL_Retry, this.ACCESS_NUMBER, this.ACCESS_NUMBER_Retry, this.NICKNAME);
                this.errorAlertJoin.TextEqual(this.EMAIL_Retry.Text, this.EMAIL);
                this.errorAlertJoin.TextEqual(this.ACCESS_NUMBER_Retry.Text, this.ACCESS_NUMBER);

                if (!this.errorAlertJoin.Result)
                    return;

                this.Cursor = Cursors.WaitCursor;

                this.beforeActionEventHandler?.Invoke(this, "Join.Start");

                result = await this.SaveAsync(new DefaultJoinSaveModel()
                {
                    EMAIL = this.EMAIL.Text,
                    ACCESS_NUMBER = ((Security.ISecureHashAlgorithm)this.CreateInstance("SecureHashAlgorithm")).ComputeHashToBase64String(this.ACCESS_NUMBER.Text),
                    NICKNAME = this.NICKNAME.Text
                });

                if (result.Status == Status.OK)
                {
                    this.MessageBoxShow(this, "가입이 완료 되었습니다.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.afterActionEventHandler?.Invoke(this, "Join.OK");

                    this.Bnt_Cancel_Click(this.Bnt_Cancel, null);
                }
                else
                    this.MessageBoxShow(this, result.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception exception)
            {
                this.MessageBoxShow(this, exception);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private async void Init()
        {
            IResponse result;
            Security.ISecureHashAlgorithm secureHashAlgorithm;

            try
            {
                this.errorAlertJoin = this.errorAlertJoin ?? this.ErrorAlert(false);
                this.errorAlertJoin.Clear();
                this.errorAlertJoin.Checked(this.UserAgreement, this.PersonalInformationCollectionAgreement);
                this.errorAlertJoin.TextNotEqual("", this.EMAIL, this.EMAIL_Retry, this.ACCESS_NUMBER, this.ACCESS_NUMBER_Retry);
                //this.errorAlertJoin.TextEqual(this.EMAIL_Retry.Text, this.EMAIL);
                this.errorAlertJoin.TextEqual(this.ACCESS_NUMBER_Retry.Text, this.ACCESS_NUMBER);

                if (!this.errorAlertJoin.Result)
                    return;

                this.Cursor = Cursors.WaitCursor;

                this.beforeActionEventHandler?.Invoke(this, "PasswordChange.Start");

                secureHashAlgorithm = ((Security.ISecureHashAlgorithm)this.CreateInstance("SecureHashAlgorithm"));

                result = await this.SavePasswordChangeAsync(new DefaultJoinSaveModel()
                {
                    EMAIL = this.EMAIL.Text,
                    ACCESS_NUMBER = secureHashAlgorithm.ComputeHashToBase64String(this.EMAIL_Retry.Text),
                    NEW_ACCESS_NUMBER = secureHashAlgorithm.ComputeHashToBase64String(this.ACCESS_NUMBER.Text)
                });

                if (result.Status == Status.OK)
                {
                    this.MessageBoxShow(this, "비밀번호 변경이 완료 되었습니다.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.afterActionEventHandler?.Invoke(this, "PasswordChange.OK");

                    this.Bnt_Cancel_Click(this.Bnt_Cancel, null);
                }
                else
                    this.MessageBoxShow(this, result.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception exception)
            {
                this.MessageBoxShow(this, exception);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        #endregion

        #region Event
        event AtomusControlEventHandler IAction.BeforeActionEventHandler
        {
            add
            {
                this.beforeActionEventHandler += value;
            }
            remove
            {
                this.beforeActionEventHandler -= value;
            }
        }
        event AtomusControlEventHandler IAction.AfterActionEventHandler
        {
            add
            {
                this.afterActionEventHandler += value;
            }
            remove
            {
                this.afterActionEventHandler -= value;
            }
        }

        private async void DefaultJoin_Load(object sender, EventArgs e)
        {
            string tmp;

            this.tableLayoutPanel1.DoubleBuffered(true);
            this.tableLayoutPanel2.DoubleBuffered(true);

            try
            {
                this.BackgroundImage = await this.GetAttributeWebImage("BackgroundImage");

                if (this.BackgroundImage != null)
                {
                    this.afterActionEventHandler?.Invoke(this, "Form.Size", this.BackgroundImage.Size);
                }
            }
            catch (Exception exception)
            {
                this.MessageBoxShow(this, exception);
            }

            try
            {
                tmp = this.GetAttribute("UserAgreement");
                this.UserAgreement_Detail.Text = tmp;
            }
            catch (Exception exception)
            {
                this.MessageBoxShow(this, exception);
            }

            try
            {
                tmp = this.GetAttribute("PersonalInformationCollectionAgreement");
                this.PersonalInformationCollectionAgreement_Detail.Text = tmp;
            }
            catch (Exception exception)
            {
                this.MessageBoxShow(this, exception);
            }
        }

        private void Bnt_Join_Init_Click(object sender, EventArgs e)
        {
            if (this.New.Checked)
                this.Join();
            else
                this.Init();
        }

        private void Bnt_Cancel_Click(object sender, EventArgs e)
        {
            this.beforeActionEventHandler?.Invoke(this, "Join.Cancel");
        }

        private void DefaultJoin_MouseMove(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Control userControl;

            try
            {
                userControl = (System.Windows.Forms.Control)sender;

                if (e.Button != MouseButtons.Left)
                    return;

                userControl.FindForm().Left = userControl.FindForm().Left + (e.X - this.point.X);
                userControl.FindForm().Top = userControl.FindForm().Top + (e.Y - this.point.Y);
            }
            catch (Exception exception)
            {
                this.MessageBoxShow(this, exception);
            }
        }
        private void DefaultJoin_MouseDown(object sender, MouseEventArgs e)
        {
            this.point.X = e.X;
            this.point.Y = e.Y;
        }

        private void New_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton;

            try
            {
                radioButton = (RadioButton)sender;

                if (radioButton.Checked)
                {
                    this.EMAIL.Enabled = true;
                    this.label5.Text = "이메일 확인".Translate();
                    this.EMAIL_Retry.Enabled = true;
                    this.EMAIL_Retry.PasswordChar = '\0';
                    this.ACCESS_NUMBER.Enabled = true;
                    this.ACCESS_NUMBER_Retry.Enabled = true;
                    this.NICKNAME.Enabled = true;
                    this.Bnt_Join_Init.Text = "가입".Translate();
                }
            }
            catch (Exception exception)
            {
                this.MessageBoxShow(this, exception);
            }
        }
        private void PasswordInit_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton RadioButton;

            try
            {
                RadioButton = (RadioButton)sender;

                if (RadioButton.Checked)
                {
                    this.EMAIL.Enabled = true;
                    this.label5.Text = "기존 비밀번호".Translate();
                    this.EMAIL_Retry.Enabled = true;
                    this.EMAIL_Retry.PasswordChar = '*';
                    this.ACCESS_NUMBER.Enabled = true;
                    this.ACCESS_NUMBER_Retry.Enabled = true;
                    this.NICKNAME.Enabled = false;
                    this.Bnt_Join_Init.Text = "비밀번호 변경".Translate();
                }
            }
            catch (Exception exception)
            {
                this.MessageBoxShow(this, exception);
            }
        }
        #endregion

        #region "ETC"
        #endregion
    }
}
