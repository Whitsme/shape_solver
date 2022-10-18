namespace GUI_Assignment_1
{
    partial class RadiusSolver
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
            this.buttonRadiusReset = new System.Windows.Forms.Button();
            this.textRadiusArea = new System.Windows.Forms.TextBox();
            this.labelRadiusArea = new System.Windows.Forms.Label();
            this.buttonSubmitRadius = new System.Windows.Forms.Button();
            this.pictureBoxRadius = new System.Windows.Forms.PictureBox();
            this.labelCircleOrSphere = new System.Windows.Forms.Label();
            this.labelRadius = new System.Windows.Forms.Label();
            this.textBoxRadius = new System.Windows.Forms.TextBox();
            this.comboBoxRadius = new System.Windows.Forms.ComboBox();
            this.textBoxShape = new System.Windows.Forms.TextBox();
            this.labelShape = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRadius)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRadiusReset
            // 
            this.buttonRadiusReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRadiusReset.Location = new System.Drawing.Point(364, 184);
            this.buttonRadiusReset.Name = "buttonRadiusReset";
            this.buttonRadiusReset.Size = new System.Drawing.Size(90, 40);
            this.buttonRadiusReset.TabIndex = 21;
            this.buttonRadiusReset.Text = "Reset";
            this.buttonRadiusReset.UseVisualStyleBackColor = true;
            this.buttonRadiusReset.Click += new System.EventHandler(this.buttonRadiusReset_Click);
            // 
            // textRadiusArea
            // 
            this.textRadiusArea.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textRadiusArea.Location = new System.Drawing.Point(218, 230);
            this.textRadiusArea.Name = "textRadiusArea";
            this.textRadiusArea.ReadOnly = true;
            this.textRadiusArea.Size = new System.Drawing.Size(122, 29);
            this.textRadiusArea.TabIndex = 20;
            this.textRadiusArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelRadiusArea
            // 
            this.labelRadiusArea.AutoSize = true;
            this.labelRadiusArea.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRadiusArea.Location = new System.Drawing.Point(13, 233);
            this.labelRadiusArea.Name = "labelRadiusArea";
            this.labelRadiusArea.Size = new System.Drawing.Size(0, 21);
            this.labelRadiusArea.TabIndex = 18;
            this.labelRadiusArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSubmitRadius
            // 
            this.buttonSubmitRadius.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSubmitRadius.Location = new System.Drawing.Point(268, 184);
            this.buttonSubmitRadius.Name = "buttonSubmitRadius";
            this.buttonSubmitRadius.Size = new System.Drawing.Size(90, 40);
            this.buttonSubmitRadius.TabIndex = 17;
            this.buttonSubmitRadius.Text = "Submit";
            this.buttonSubmitRadius.UseVisualStyleBackColor = true;
            this.buttonSubmitRadius.Click += new System.EventHandler(this.buttonSubmitRadius_Click);
            // 
            // pictureBoxRadius
            // 
            this.pictureBoxRadius.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxRadius.Location = new System.Drawing.Point(460, 90);
            this.pictureBoxRadius.Name = "pictureBoxRadius";
            this.pictureBoxRadius.Size = new System.Drawing.Size(107, 169);
            this.pictureBoxRadius.TabIndex = 19;
            this.pictureBoxRadius.TabStop = false;
            // 
            // labelCircleOrSphere
            // 
            this.labelCircleOrSphere.AutoSize = true;
            this.labelCircleOrSphere.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCircleOrSphere.Location = new System.Drawing.Point(96, 155);
            this.labelCircleOrSphere.Name = "labelCircleOrSphere";
            this.labelCircleOrSphere.Size = new System.Drawing.Size(220, 21);
            this.labelCircleOrSphere.TabIndex = 16;
            this.labelCircleOrSphere.Text = " Circle area or sphere volume?";
            // 
            // labelRadius
            // 
            this.labelRadius.AutoSize = true;
            this.labelRadius.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRadius.Location = new System.Drawing.Point(50, 120);
            this.labelRadius.Name = "labelRadius";
            this.labelRadius.Size = new System.Drawing.Size(262, 21);
            this.labelRadius.TabIndex = 14;
            this.labelRadius.Text = "                                   Enter the radius:";
            // 
            // textBoxRadius
            // 
            this.textBoxRadius.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxRadius.Location = new System.Drawing.Point(322, 117);
            this.textBoxRadius.Name = "textBoxRadius";
            this.textBoxRadius.Size = new System.Drawing.Size(132, 29);
            this.textBoxRadius.TabIndex = 13;
            // 
            // comboBoxRadius
            // 
            this.comboBoxRadius.FormattingEnabled = true;
            this.comboBoxRadius.Items.AddRange(new object[] {
            "Circle",
            "Sphere"});
            this.comboBoxRadius.Location = new System.Drawing.Point(322, 155);
            this.comboBoxRadius.Name = "comboBoxRadius";
            this.comboBoxRadius.Size = new System.Drawing.Size(132, 23);
            this.comboBoxRadius.TabIndex = 22;
            // 
            // textBoxShape
            // 
            this.textBoxShape.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxShape.Location = new System.Drawing.Point(459, 230);
            this.textBoxShape.Name = "textBoxShape";
            this.textBoxShape.ReadOnly = true;
            this.textBoxShape.Size = new System.Drawing.Size(109, 29);
            this.textBoxShape.TabIndex = 24;
            this.textBoxShape.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelShape
            // 
            this.labelShape.AutoSize = true;
            this.labelShape.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelShape.Location = new System.Drawing.Point(346, 233);
            this.labelShape.Name = "labelShape";
            this.labelShape.Size = new System.Drawing.Size(0, 21);
            this.labelShape.TabIndex = 23;
            this.labelShape.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RadiusSolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.textBoxShape);
            this.Controls.Add(this.labelShape);
            this.Controls.Add(this.comboBoxRadius);
            this.Controls.Add(this.buttonRadiusReset);
            this.Controls.Add(this.textRadiusArea);
            this.Controls.Add(this.labelRadiusArea);
            this.Controls.Add(this.buttonSubmitRadius);
            this.Controls.Add(this.pictureBoxRadius);
            this.Controls.Add(this.labelCircleOrSphere);
            this.Controls.Add(this.labelRadius);
            this.Controls.Add(this.textBoxRadius);
            this.Name = "RadiusSolver";
            this.Text = "Radius Solver";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRadius)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRadiusReset;
        private System.Windows.Forms.TextBox textRadiusArea;
        private System.Windows.Forms.Label labelRadiusArea;
        private System.Windows.Forms.Button buttonSubmitRadius;
        private System.Windows.Forms.PictureBox pictureBoxRadius;
        private System.Windows.Forms.Label labelCircleOrSphere;
        private System.Windows.Forms.Label labelRadius;
        private System.Windows.Forms.TextBox textBoxRadius;
        private System.Windows.Forms.ComboBox comboBoxRadius;
        private System.Windows.Forms.TextBox textBoxShape;
        private System.Windows.Forms.Label labelShape;
    }
}