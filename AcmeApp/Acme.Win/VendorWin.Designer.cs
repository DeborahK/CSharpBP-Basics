namespace Acme.Win
{
  partial class VendorWin
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      label1 = new Label();
      CompanyNameTextBox = new TextBox();
      EmailTextBox = new TextBox();
      label2 = new Label();
      CancelChangesButton = new Button();
      SaveButton = new Button();
      SuspendLayout();
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(13, 13);
      label1.Name = "label1";
      label1.Size = new Size(94, 15);
      label1.TabIndex = 0;
      label1.Text = "Company Name";
      // 
      // CompanyNameTextBox
      // 
      CompanyNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      CompanyNameTextBox.Location = new Point(13, 30);
      CompanyNameTextBox.Name = "CompanyNameTextBox";
      CompanyNameTextBox.Size = new Size(275, 23);
      CompanyNameTextBox.TabIndex = 1;
      // 
      // EmailTextBox
      // 
      EmailTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      EmailTextBox.Location = new Point(13, 72);
      EmailTextBox.Name = "EmailTextBox";
      EmailTextBox.Size = new Size(275, 23);
      EmailTextBox.TabIndex = 3;
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(16, 54);
      label2.Name = "label2";
      label2.Size = new Size(84, 15);
      label2.TabIndex = 2;
      label2.Text = "Email Address:";
      // 
      // CancelChangesButton
      // 
      CancelChangesButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      CancelChangesButton.CausesValidation = false;
      CancelChangesButton.DialogResult = DialogResult.Cancel;
      CancelChangesButton.Location = new Point(214, 143);
      CancelChangesButton.Name = "CancelChangesButton";
      CancelChangesButton.Size = new Size(75, 23);
      CancelChangesButton.TabIndex = 4;
      CancelChangesButton.Text = "Cancel";
      CancelChangesButton.UseVisualStyleBackColor = true;
      CancelChangesButton.Click += CancelChangesButton_Click;
      // 
      // SaveButton
      // 
      SaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      SaveButton.DialogResult = DialogResult.OK;
      SaveButton.Location = new Point(133, 143);
      SaveButton.Name = "SaveButton";
      SaveButton.Size = new Size(75, 23);
      SaveButton.TabIndex = 5;
      SaveButton.Text = "Save";
      SaveButton.UseVisualStyleBackColor = true;
      SaveButton.Click += SaveButton_Click;
      // 
      // VendorWin
      // 
      AcceptButton = SaveButton;
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(301, 178);
      Controls.Add(SaveButton);
      Controls.Add(CancelChangesButton);
      Controls.Add(EmailTextBox);
      Controls.Add(label2);
      Controls.Add(CompanyNameTextBox);
      Controls.Add(label1);
      MinimumSize = new Size(301, 187);
      Name = "VendorWin";
      Text = "Vendor Detail";
      Load += VendorWin_Load;
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox CompanyNameTextBox;
    private System.Windows.Forms.TextBox EmailTextBox;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button CancelChangesButton;
    private System.Windows.Forms.Button SaveButton;
  }
}