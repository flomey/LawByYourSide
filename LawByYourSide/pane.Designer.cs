namespace LawByYourSide
{
    partial class pane
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.norm_input = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.query_button = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.allNorms = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // norm_input
            // 
            this.norm_input.Location = new System.Drawing.Point(19, 3);
            this.norm_input.Name = "norm_input";
            this.norm_input.Size = new System.Drawing.Size(100, 20);
            this.norm_input.TabIndex = 0;
            this.norm_input.Text = "Please enter norm";
            this.norm_input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // query_button
            // 
            this.query_button.Location = new System.Drawing.Point(44, 45);
            this.query_button.Name = "query_button";
            this.query_button.Size = new System.Drawing.Size(75, 23);
            this.query_button.TabIndex = 1;
            this.query_button.Text = "Query";
            this.query_button.UseVisualStyleBackColor = true;
            this.query_button.Click += new System.EventHandler(this.query_button_Click);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(19, 275);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.output.Size = new System.Drawing.Size(116, 162);
            this.output.TabIndex = 2;
            this.output.TextChanged += new System.EventHandler(this.output_TextChanged);
            // 
            // allNorms
            // 
            this.allNorms.Location = new System.Drawing.Point(14, 100);
            this.allNorms.Name = "allNorms";
            this.allNorms.Size = new System.Drawing.Size(121, 97);
            this.allNorms.TabIndex = 3;
            this.allNorms.UseCompatibleStateImageBehavior = false;
            // 
            // pane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.allNorms);
            this.Controls.Add(this.output);
            this.Controls.Add(this.query_button);
            this.Controls.Add(this.norm_input);
            this.Name = "pane";
            this.Size = new System.Drawing.Size(191, 500);
            this.Load += new System.EventHandler(this.pane_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox norm_input;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button query_button;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ListView allNorms;
    }
}
