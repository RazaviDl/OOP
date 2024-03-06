namespace Lab2
{
    partial class Form2
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
            HistoryOperation = new ListBox();
            OperationType = new ComboBox();
            SaveJSON = new Button();
            ExtractJSON = new Button();
            Execute = new Button();
            SumOperation = new TextBox();
            SuspendLayout();
            // 
            // HistoryOperation
            // 
            HistoryOperation.FormattingEnabled = true;
            HistoryOperation.Location = new Point(247, 69);
            HistoryOperation.Name = "HistoryOperation";
            HistoryOperation.Size = new Size(380, 364);
            HistoryOperation.TabIndex = 0;
            // 
            // OperationType
            // 
            OperationType.FormattingEnabled = true;
            OperationType.Items.AddRange(new object[] { "Перевод", "Снятие" });
            OperationType.Location = new Point(27, 69);
            OperationType.Name = "OperationType";
            OperationType.Size = new Size(193, 28);
            OperationType.TabIndex = 1;
            OperationType.Text = "Тип операции";
            // 
            // SaveJSON
            // 
            SaveJSON.Location = new Point(26, 339);
            SaveJSON.Name = "SaveJSON";
            SaveJSON.Size = new Size(192, 44);
            SaveJSON.TabIndex = 2;
            SaveJSON.Text = "Сохранить";
            SaveJSON.UseVisualStyleBackColor = true;
            SaveJSON.Click += SaveJSON_Click;
            // 
            // ExtractJSON
            // 
            ExtractJSON.Location = new Point(27, 389);
            ExtractJSON.Name = "ExtractJSON";
            ExtractJSON.Size = new Size(192, 44);
            ExtractJSON.TabIndex = 3;
            ExtractJSON.Text = "Извлечь";
            ExtractJSON.UseVisualStyleBackColor = true;
            ExtractJSON.Click += ExtractJSON_Click;
            // 
            // Execute
            // 
            Execute.Location = new Point(26, 143);
            Execute.Name = "Execute";
            Execute.Size = new Size(192, 44);
            Execute.TabIndex = 5;
            Execute.Text = "Выполнить";
            Execute.UseVisualStyleBackColor = true;
            Execute.Click += Execute_Click;
            // 
            // SumOperation
            // 
            SumOperation.Location = new Point(27, 103);
            SumOperation.Name = "SumOperation";
            SumOperation.PlaceholderText = "Сумма";
            SumOperation.Size = new Size(191, 27);
            SumOperation.TabIndex = 6;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 490);
            Controls.Add(SumOperation);
            Controls.Add(Execute);
            Controls.Add(ExtractJSON);
            Controls.Add(SaveJSON);
            Controls.Add(OperationType);
            Controls.Add(HistoryOperation);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox HistoryOperation;
        private ComboBox OperationType;
        private Button SaveJSON;
        private Button ExtractJSON;
        private Button Execute;
        private TextBox SumOperation;
    }
}
