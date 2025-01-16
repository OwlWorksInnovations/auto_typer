namespace auto_typer
{
    partial class AutoTyper
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
            this.inputBox = new System.Windows.Forms.TextBox();
            this.typeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.inputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.inputBox.Location = new System.Drawing.Point(16, 15);
            this.inputBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(1033, 488);
            this.inputBox.TabIndex = 0;
            this.inputBox.Text = "This is testing text";
            this.inputBox.TextChanged += new System.EventHandler(this.inputBox_TextChanged);
            // 
            // typeBtn
            // 
            this.typeBtn.Location = new System.Drawing.Point(500, 511);
            this.typeBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.typeBtn.Name = "typeBtn";
            this.typeBtn.Size = new System.Drawing.Size(100, 28);
            this.typeBtn.TabIndex = 1;
            this.typeBtn.Text = "Type";
            this.typeBtn.UseVisualStyleBackColor = true;
            this.typeBtn.Click += new System.EventHandler(this.typeBtn_Click);
            // 
            // AutoTyper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.typeBtn);
            this.Controls.Add(this.inputBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AutoTyper";
            this.Text = "Auto Typer";
            this.Load += new System.EventHandler(this.AutoTyper_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button typeBtn;
    }
}

