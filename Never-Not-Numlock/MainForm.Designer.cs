
namespace NeverNotNumlock
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._closeButton = new System.Windows.Forms.Button();
            this._numlockStatusLabel = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this._runAtStartup = new System.Windows.Forms.CheckBox();
            this._hideButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.Location = new System.Drawing.Point(832, 33);
            this._closeButton.Name = "_closeButton";
            this._closeButton.Size = new System.Drawing.Size(181, 82);
            this._closeButton.TabIndex = 0;
            this._closeButton.Text = "Close";
            this._closeButton.UseVisualStyleBackColor = true;
            this._closeButton.Click += new System.EventHandler(this._closeButton_Click);
            // 
            // _numlockStatusLabel
            // 
            this._numlockStatusLabel.AutoSize = true;
            this._numlockStatusLabel.Location = new System.Drawing.Point(42, 33);
            this._numlockStatusLabel.Name = "_numlockStatusLabel";
            this._numlockStatusLabel.Size = new System.Drawing.Size(360, 29);
            this._numlockStatusLabel.TabIndex = 2;
            this._numlockStatusLabel.Text = "I mean.... why is it even a button?";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Will enable numlock any time it is detected to be off.";
            this.notifyIcon1.BalloonTipTitle = "Nevere NOT Numlock!";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // _runAtStartup
            // 
            this._runAtStartup.AutoSize = true;
            this._runAtStartup.Checked = global::NeverNotNumlock.WinApp.Properties.Settings.Default.NotifyMeWhenDisabled;
            this._runAtStartup.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::NeverNotNumlock.WinApp.Properties.Settings.Default, "NotifyMeWhenDisabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._runAtStartup.Location = new System.Drawing.Point(47, 92);
            this._runAtStartup.Name = "_runAtStartup";
            this._runAtStartup.Size = new System.Drawing.Size(203, 33);
            this._runAtStartup.TabIndex = 1;
            this._runAtStartup.Text = "Run at startup?";
            this._runAtStartup.UseVisualStyleBackColor = true;
            this._runAtStartup.CheckedChanged += new System.EventHandler(this._runAtStartup_CheckedChanged);
            // 
            // _hideButton
            // 
            this._hideButton.Location = new System.Drawing.Point(620, 33);
            this._hideButton.Name = "_hideButton";
            this._hideButton.Size = new System.Drawing.Size(181, 82);
            this._hideButton.TabIndex = 3;
            this._hideButton.Text = "Hide";
            this._hideButton.UseVisualStyleBackColor = true;
            this._hideButton.Click += new System.EventHandler(this._hideButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 150);
            this.Controls.Add(this._hideButton);
            this.Controls.Add(this._numlockStatusLabel);
            this.Controls.Add(this._runAtStartup);
            this.Controls.Add(this._closeButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Never Not Numlock!";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _closeButton;
        private System.Windows.Forms.CheckBox _runAtStartup;
        private System.Windows.Forms.Label _numlockStatusLabel;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button _hideButton;
    }
}

