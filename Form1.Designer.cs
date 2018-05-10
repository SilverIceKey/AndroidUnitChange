namespace Android_unit_change
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Change = new System.Windows.Forms.Button();
            this.beChangeValue = new System.Windows.Forms.TextBox();
            this.resultValue = new System.Windows.Forms.TextBox();
            this.dpi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.beChangeUnit = new System.Windows.Forms.ComboBox();
            this.resultUnit = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(164, 46);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(75, 23);
            this.Change.TabIndex = 0;
            this.Change.Text = "转换";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // beChangeValue
            // 
            this.beChangeValue.Location = new System.Drawing.Point(12, 12);
            this.beChangeValue.Name = "beChangeValue";
            this.beChangeValue.Size = new System.Drawing.Size(100, 21);
            this.beChangeValue.TabIndex = 1;
            // 
            // resultValue
            // 
            this.resultValue.Location = new System.Drawing.Point(12, 85);
            this.resultValue.Name = "resultValue";
            this.resultValue.Size = new System.Drawing.Size(100, 21);
            this.resultValue.TabIndex = 2;
            // 
            // dpi
            // 
            this.dpi.Location = new System.Drawing.Point(12, 48);
            this.dpi.Name = "dpi";
            this.dpi.Size = new System.Drawing.Size(100, 21);
            this.dpi.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "dpi";
            // 
            // beChangeUnit
            // 
            this.beChangeUnit.FormattingEnabled = true;
            this.beChangeUnit.Items.AddRange(new object[] {
            "px",
            "dp"});
            this.beChangeUnit.Location = new System.Drawing.Point(118, 12);
            this.beChangeUnit.Name = "beChangeUnit";
            this.beChangeUnit.Size = new System.Drawing.Size(121, 20);
            this.beChangeUnit.TabIndex = 5;
            // 
            // resultUnit
            // 
            this.resultUnit.FormattingEnabled = true;
            this.resultUnit.Items.AddRange(new object[] {
            "px",
            "dp"});
            this.resultUnit.Location = new System.Drawing.Point(118, 85);
            this.resultUnit.Name = "resultUnit";
            this.resultUnit.Size = new System.Drawing.Size(121, 20);
            this.resultUnit.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 132);
            this.Controls.Add(this.resultUnit);
            this.Controls.Add(this.beChangeUnit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dpi);
            this.Controls.Add(this.resultValue);
            this.Controls.Add(this.beChangeValue);
            this.Controls.Add(this.Change);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.TextBox beChangeValue;
        private System.Windows.Forms.TextBox resultValue;
        private System.Windows.Forms.TextBox dpi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox beChangeUnit;
        private System.Windows.Forms.ComboBox resultUnit;
    }
}

