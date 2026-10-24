namespace BRUSOLA_05LAB_01
{
    partial class FrmLab1
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
            Create = new Button();
            Input = new RichTextBox();
            SuspendLayout();
            // 
            // Create
            // 
            Create.Location = new Point(70, 374);
            Create.Name = "Create";
            Create.Size = new Size(257, 48);
            Create.TabIndex = 1;
            Create.Text = "Create";
            Create.UseVisualStyleBackColor = true;
            Create.Click += Create_Click;
            // 
            // Input
            // 
            Input.BorderStyle = BorderStyle.FixedSingle;
            Input.Location = new Point(70, 27);
            Input.Name = "Input";
            Input.Size = new Size(257, 323);
            Input.TabIndex = 3;
            Input.Text = "";
            // 
            // FrmLab1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 451);
            Controls.Add(Input);
            Controls.Add(Create);
            Name = "FrmLab1";
            Text = "FrmLab1";
            ResumeLayout(false);
        }

        #endregion

        private Button Create;
        private RichTextBox Input;
    }
}