namespace Project1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.construction = new System.Windows.Forms.TableLayoutPanel();
            this.methodNameBox = new System.Windows.Forms.TextBox();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.constructionBox = new System.Windows.Forms.TextBox();
            this.revalBox = new System.Windows.Forms.TextBox();
            this.refBox = new System.Windows.Forms.TextBox();
            this.parameterBox = new System.Windows.Forms.TextBox();
            this.exampleBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.construction.SuspendLayout();
            this.SuspendLayout();
            // 
            // construction
            // 
            this.construction.ColumnCount = 2;
            this.construction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.construction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.construction.Controls.Add(this.methodNameBox, 0, 0);
            this.construction.Controls.Add(this.descriptionBox, 0, 1);
            this.construction.Controls.Add(this.label1, 0, 2);
            this.construction.Controls.Add(this.label2, 0, 3);
            this.construction.Controls.Add(this.label3, 0, 4);
            this.construction.Controls.Add(this.label4, 0, 5);
            this.construction.Controls.Add(this.label5, 0, 6);
            this.construction.Controls.Add(this.constructionBox, 1, 2);
            this.construction.Controls.Add(this.revalBox, 1, 4);
            this.construction.Controls.Add(this.refBox, 1, 6);
            this.construction.Controls.Add(this.parameterBox, 1, 3);
            this.construction.Controls.Add(this.exampleBox, 1, 5);
            this.construction.Controls.Add(this.button1, 0, 7);
            this.construction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.construction.Location = new System.Drawing.Point(0, 0);
            this.construction.Name = "construction";
            this.construction.RowCount = 8;
            this.construction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.60543F));
            this.construction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.70593F));
            this.construction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.70593F));
            this.construction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.08321F));
            this.construction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.60543F));
            this.construction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.08321F));
            this.construction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.60543F));
            this.construction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.60543F));
            this.construction.Size = new System.Drawing.Size(936, 489);
            this.construction.TabIndex = 0;
            // 
            // methodNameBox
            // 
            this.methodNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.construction.SetColumnSpan(this.methodNameBox, 2);
            this.methodNameBox.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.methodNameBox.Location = new System.Drawing.Point(3, 3);
            this.methodNameBox.Name = "methodNameBox";
            this.methodNameBox.Size = new System.Drawing.Size(930, 25);
            this.methodNameBox.TabIndex = 0;
            this.methodNameBox.Text = "addStringforPrint (method)";
            this.methodNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // descriptionBox
            // 
            this.descriptionBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.construction.SetColumnSpan(this.descriptionBox, 2);
            this.descriptionBox.Font = new System.Drawing.Font("굴림", 10F);
            this.descriptionBox.Location = new System.Drawing.Point(3, 27);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(930, 21);
            this.descriptionBox.TabIndex = 2;
            this.descriptionBox.Text = "이미지 인쇄시 같이 인쇄할 문자열을 추가한다.";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 10F);
            this.label1.Location = new System.Drawing.Point(3, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "구      문";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 10F);
            this.label2.Location = new System.Drawing.Point(3, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "매개변수";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 10F);
            this.label3.Location = new System.Drawing.Point(3, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "반 환 값";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 10F);
            this.label4.Location = new System.Drawing.Point(3, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 14);
            this.label4.TabIndex = 1;
            this.label4.Text = "예    제";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 10F);
            this.label5.Location = new System.Drawing.Point(3, 444);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 14);
            this.label5.TabIndex = 1;
            this.label5.Text = "참고항목";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // constructionBox
            // 
            this.constructionBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.constructionBox.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.constructionBox.Location = new System.Drawing.Point(190, 59);
            this.constructionBox.Multiline = true;
            this.constructionBox.Name = "constructionBox";
            this.constructionBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.constructionBox.Size = new System.Drawing.Size(743, 21);
            this.constructionBox.TabIndex = 3;
            this.constructionBox.Text = "void addStringforPrint(LPCTSTR InputStr, LPCTSTR FontName, long FontSize, long Fo" +
    "ntColor, long StringPosition)";
            this.constructionBox.TextChanged += new System.EventHandler(this.constructionBox_TextChanged);
            // 
            // revalBox
            // 
            this.revalBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.revalBox.Location = new System.Drawing.Point(190, 255);
            this.revalBox.Name = "revalBox";
            this.revalBox.Size = new System.Drawing.Size(743, 21);
            this.revalBox.TabIndex = 3;
            this.revalBox.Text = "없음";
            // 
            // refBox
            // 
            this.refBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.refBox.Location = new System.Drawing.Point(190, 443);
            this.refBox.Name = "refBox";
            this.refBox.Size = new System.Drawing.Size(743, 21);
            this.refBox.TabIndex = 3;
            this.refBox.Text = "removeStringforPrint";
            // 
            // parameterBox
            // 
            this.parameterBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.parameterBox.Font = new System.Drawing.Font("굴림", 8F);
            this.parameterBox.Location = new System.Drawing.Point(190, 89);
            this.parameterBox.Multiline = true;
            this.parameterBox.Name = "parameterBox";
            this.parameterBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.parameterBox.Size = new System.Drawing.Size(743, 160);
            this.parameterBox.TabIndex = 3;
            this.parameterBox.Text = resources.GetString("parameterBox.Text");
            // 
            // exampleBox
            // 
            this.exampleBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.exampleBox.Location = new System.Drawing.Point(190, 277);
            this.exampleBox.Multiline = true;
            this.exampleBox.Name = "exampleBox";
            this.exampleBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.exampleBox.Size = new System.Drawing.Size(743, 160);
            this.exampleBox.TabIndex = 3;
            this.exampleBox.Text = resources.GetString("exampleBox.Text");
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(56, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 4;
            this.button1.Text = "저    장";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.Title = "savedirectory";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 489);
            this.Controls.Add(this.construction);
            this.Name = "Form1";
            this.Text = "Form1";
            this.construction.ResumeLayout(false);
            this.construction.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel construction;
        private System.Windows.Forms.TextBox methodNameBox;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox constructionBox;
        private System.Windows.Forms.TextBox revalBox;
        private System.Windows.Forms.TextBox refBox;
        private System.Windows.Forms.TextBox parameterBox;
        private System.Windows.Forms.TextBox exampleBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
    }
}

