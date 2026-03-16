using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;


namespace GUI
{
    public partial class FormGUI : Form
    {
        // Указатель на окно редактирования
        private RichTextBox inputBox;
        // Лист всех ошибок из всех файлов
        private List<ReportFile> report = new List<ReportFile>();

        public FormGUI()
        {
            InitializeComponent();
            files.TabPages.Add(NewFile("Новый документ 1"));
            // Для сканера
            outputBox.Columns[0].HeaderText = "Условный код";
            outputBox.Columns[1].HeaderText = "Тип лексемы";
            outputBox.Columns[2].HeaderText = "Лексема";
            outputBox.Columns[3].HeaderText = "Местоположение";
        }

        // Меню - Файл

        private void CreatFile_Click(object sender, EventArgs e)
        {
            files.TabPages.Add(NewFile("Новый документ" + (files.TabCount + 1).ToString()));
        }
        private TabPage NewFile(string name)
        {
            TabPage file = new TabPage(name);
            file.BorderStyle = BorderStyle.FixedSingle;

            RichTextBox inputBoxFile = new RichTextBox(); // Текст файла
            file.Controls.Add(inputBoxFile);
            inputBoxFile.Dock = DockStyle.Fill;
            inputBoxFile.Location = new Point(51, 3);
            inputBoxFile.BorderStyle = BorderStyle.None;
            inputBoxFile.Font = new Font("Microsoft Sans Serif", 9F);
            inputBoxFile.SelectionChanged += new EventHandler(inputBox_SelectionChanged);
            inputBoxFile.VScroll += new EventHandler(inputBox_VScroll);
            inputBoxFile.TextChanged += new EventHandler(inputBox_TextChanged);
            inputBoxFile.KeyPress += new KeyPressEventHandler(inputBox_KeyPress);
            //inputBoxFile.KeyDown += new KeyEventHandler(inputBox_KeyDown);
            inputBox = inputBoxFile;
            inputBox.Focus();

            ReportFile reportFile = new ReportFile();
            report.Add(reportFile);

            RichTextBox LineNumberFile = new RichTextBox();
            file.Controls.Add(LineNumberFile);
            LineNumberFile.Dock = DockStyle.Left;
            LineNumberFile.BackColor = SystemColors.Window;
            LineNumberFile.Location = new Point(3, 3);
            LineNumberFile.Width = 48;
            LineNumberFile.SelectionAlignment = HorizontalAlignment.Center;
            LineNumberFile.Font = new Font("Microsoft Sans Serif", 9F);
            LineNumberFile.BorderStyle = BorderStyle.None;
            LineNumberFile.Cursor = Cursors.PanNE;
            LineNumberFile.ForeColor = SystemColors.GrayText;
            LineNumberFile.ReadOnly = true;
            LineNumberFile.ScrollBars = RichTextBoxScrollBars.None;
            LineNumberFile.MouseDown += new MouseEventHandler(LineNumber_MouseDown);
            LineNumberFile.HideSelection = true;

            UpdateLineNumbers(inputBoxFile);

            foreach (ToolStripItem button in toolStrip1.Items)
            {
                button.Enabled = true;
            }
            foreach (ToolStripMenuItem menu in menuStrip1.Items)
            {
                menu.Enabled = true;
                foreach (var dropMenu in menu.DropDownItems)
                {
                    if (dropMenu is ToolStripMenuItem)
                    {
                        ToolStripMenuItem dropMenuItem = dropMenu as ToolStripMenuItem;
                        dropMenuItem.Enabled = true;
                    }
                }
            }
            пускToolStripMenuItem.Enabled = true;

            file.DragDrop += new DragEventHandler(FormGUI_DragDrop);
            file.DragEnter += new DragEventHandler(FormGUI_DragEnter);

            return file;
        }
        private void OpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            files.TabPages.Add(NewFile(openFileDialog1.SafeFileName));
            files.SelectedTab = files.TabPages[files.TabPages.Count - 1];
            RichTextBox inputBox = files.TabPages[files.TabPages.Count - 1].GetChildAtPoint(new Point(51, 3)) as RichTextBox;
            inputBox.Text = File.ReadAllText(openFileDialog1.FileName);
        }
        private void SaveFile_Click(object sender, EventArgs e)
        {
            string filename = files.SelectedTab.Text;
            RichTextBox inputBox = files.SelectedTab.GetChildAtPoint(new Point(51, 3)) as RichTextBox;
            File.WriteAllText(filename, inputBox.Text);
        }
        private void SaveAsFile_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = files.SelectedTab.Text;
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;

            string nameFile = saveFileDialog1.FileName;
            RichTextBox inputBox = files.SelectedTab.GetChildAtPoint(new Point(51, 3)) as RichTextBox;
            File.WriteAllText(nameFile, inputBox.Text);
            files.SelectedTab.Text = nameFile;
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Обновляем окна при смене файлов
        private void files_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Настраиваем вывод ошибок для каждого файла
            outputBox.Rows.Clear();

            ReportFile reportFile = report[files.SelectedIndex];
            for (int i = 0; i < reportFile.message.Count; i++)
            {
                if (reportFile.message[i] != " " && reportFile.message[i] != "")
                {
                    outputBox.Rows.Add(reportFile.path[i], reportFile.line[i],reportFile.column[i], reportFile.message[i]);
                }
            }

            // Делаем указатель на окно редактора в используемом файле
            inputBox = files.TabPages[files.SelectedIndex].GetChildAtPoint(new Point(51, 3)) as RichTextBox;
            inputBox.Focus();
        }

        // Перетаскивание файлов в приложение
        private void FormGUI_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
        private void FormGUI_DragDrop(object sender, DragEventArgs e)
        {
            this.Cursor = Cursors.Default;
            string[] file = (string[])e.Data.GetData(DataFormats.FileDrop);
            openFileDialog1.FileName = file[0];
            openFileDialog1.ShowDialog();
        }

        // Меню - правка

        private void Cancel_Click(object sender, EventArgs e)
        {
            if(inputBox != null) inputBox.Undo();
        }
        private void Return_Click(object sender, EventArgs e)
        {
            if (inputBox != null) inputBox.Redo();
        }
        private void Cut_Click(object sender, EventArgs e)
        {
            if (inputBox != null) inputBox.Cut();
        }
        private void Copy_Click(object sender, EventArgs e)
        {
            if (inputBox != null) inputBox.Copy();
        }
        private void Paste_Click(object sender, EventArgs e)
        {
            if (inputBox != null) inputBox.Paste();
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            if (inputBox != null) inputBox.Clear();
        }
        private void SelectAll_Click(object sender, EventArgs e)
        {
            if (inputBox != null) inputBox.SelectAll();
        }

        // Меню - Текст

        private void textWork_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Меню «Текст» будет реализовано позже. При вызове команд этого меню должны открываться окна с соответствующей информацией. ");
        }

        // Меню - Пуск

        private void Run_Click(object sender, EventArgs e)
        {
            try
            {
                outputBox.Rows.Clear();

                Scanner scanner = new Scanner();
                List<Token> tokens = scanner.analyze(inputBox.Text);

                ReportFile tempReport = new ReportFile();

                foreach (Token token in tokens)
                {
                    outputBox.Rows.Add(token.id, token.type, token.name, token.location);
                    tempReport.addReport(token.id.ToString(), token.type, token.name, token.location);
                }

                int indexFile = files.SelectedIndex;
                report.RemoveAt(indexFile);
                report.Insert(indexFile, tempReport);
                
                this.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Меню - Справка

        private void Help_Click(object sender, EventArgs e)
        {
            Form help = new Form();
            help.Size = new System.Drawing.Size(500, 500);
            help.Text = "Справочная служба";
            help.StartPosition = FormStartPosition.CenterScreen;
            RichTextBox info = new RichTextBox();
            info.ReadOnly = true;
            info.Font = statusFont.Font;
            info.Size = new System.Drawing.Size(450, 425);
            info.Location = new Point(25, 15);
            info.Text = "Меню приложения:\nФайл:\n - Создать файл - Создается новый файл и открывается в приложение для работы с ним. (Ctrl+N)\n" +
                " - Сохранить - Сохраняет текущий рабочий файл в приложении без указания пути до файла. (Ctrl+S)\n" +
                " - Cохранить как - Открывается диалоговое окно для указания расположения, где сохраниться текущий рабочий файл. (Ctrl+Shift+S)\n" + 
                " - Выход - Совершается закрытие приложения. (Alt+F4)\n\nПравка:\n" + 
                " - Отмена - Отменяет совершенное действие. (Ctrl+Z)\n" + 
                " - Возврат - Возращает раннее отмененное действие. (Ctrl+Y)\n" + 
                " - Вырезать - Стирает выделенный текст и сохраняет в буфере обмене для вставки. (Ctrl+X)\n" +
                " - Копировать - выделенный текст сохраняет в буфере обмене. (Ctrl+C)\n" + 
                " - Вставить - Текст из буфере обмене напишеться в окне редактирования. (Ctrl+V)\n" + 
                " - Удалить - Удаляет весь текст из окна редактирования. (Delete)\n"  +
                " - Выделить все - Выделяет весь текст из окна редактирования. (Ctrl+A)\n\nПуск:\n" +
                " - Выводиться сообщение о том, что позже будет реализован пуск. (F5)\n\nСправка:\n"+
                " - Вызов справки - Появляется окно об всех функциях в приложении. (Ctrl+F1)\n" + 
                " - О программе - Появляется окно с информации об окне. (Ctrl+F2)\n\nЛокализация:\n"  +
                " - Русский - Меняет текст на русский язык. \n" +
                " - Китайский - Меняет текст на китайский язык. \n\nРазмер текста:\n" +
                " - прибавить - Увеличивает размер текста во всем приложении. (Ctrl+ +)\n" +
                " - убавить - Увеличивает размер текста во всем приложении. (Ctrl+ -)";
            help.Controls.Add(info);
            help.ShowDialog();
        }
        private void AboutProgram_Click(object sender, EventArgs e)
        {
            Form about = new Form();
            about.Text = "О программе";
            about.StartPosition = FormStartPosition.CenterScreen;
            RichTextBox form = new RichTextBox();
            form.ReadOnly = true;
            form.Multiline = true;
            form.Dock = DockStyle.Fill;
            form.Text = "Программа - пользовательский графический интерфейс для компилятора!\n" +
                "Выполнил: Тарбаев Даба-Цырен АП-327" +
                "\nПроверил: Антонянц Егор Николаевич асс. каф. АСУ.";
            about.Controls.Add(form);
            about.Show();
        }

        // Меню - Локализация

        private void RusLg_Click(object sender, EventArgs e)
        {
            swap_lang(0);
        }

        private void ChinaLg(object sender, EventArgs e)
        {
            swap_lang(1);
        }
        private void swap_lang(int key)
        {
            if (key == 0) файлToolStripMenuItem.Text = "Файл";
            else файлToolStripMenuItem.Text = "文件";

            if (key == 0) правкаToolStripMenuItem.Text = "Правка";
            else правкаToolStripMenuItem.Text = "编辑";

            if (key == 0) текстToolStripMenuItem.Text = "Текст";
            else текстToolStripMenuItem.Text = "文本";

            if (key == 0) пускToolStripMenuItem.Text = "Пуск";
            else пускToolStripMenuItem.Text = "开始";

            if (key == 0) справкаToolStripMenuItem.Text = "Справка";
            else справкаToolStripMenuItem.Text = "参考";

            if (key == 0) размерТекстаToolStripMenuItem.Text = "Размер текста";
            else размерТекстаToolStripMenuItem.Text = "文字大小";

            if (key == 0) локалиToolStripMenuItem.Text = "Язык";
            else локалиToolStripMenuItem.Text = "本地化";

            if (key == 0) созданиеToolStripMenuItem.Text = "Создать";
            else созданиеToolStripMenuItem.Text = "创造";

            if (key == 0) открытиеToolStripMenuItem.Text = "Открыть";
            else открытиеToolStripMenuItem.Text = "打开";

            if (key == 0) сохранениеToolStripMenuItem.Text = "Сохранить";
            else сохранениеToolStripMenuItem.Text = "节省";

            if (key == 0) сохранениеКакToolStripMenuItem.Text = "Сохранить как";
            else сохранениеКакToolStripMenuItem.Text = "另存为";

            if (key == 0) выходToolStripMenuItem.Text = "Выход";
            else выходToolStripMenuItem.Text = "出口";

            if (key == 0) MenuItemCancel.Text = "Отменить";
            else MenuItemCancel.Text = "取消";

            if (key == 0) MenuItemReturn.Text = "Повторить";
            else MenuItemReturn.Text = "重复";

            if (key == 0) MenuItemCut.Text = "Вырезать";
            else MenuItemCut.Text = "切";

            if (key == 0) MenuItemCopy.Text = "Копировать";
            else MenuItemCopy.Text = "复制";

            if (key == 0) MenuItemPaste.Text = "Вставить";
            else MenuItemPaste.Text = "插入";

            if (key == 0) MenuItemDelete.Text = "Удалить";
            else MenuItemDelete.Text = "删除";

            if (key == 0) русскийToolStripMenuItem.Text = "Русский";
            else русскийToolStripMenuItem.Text = "俄语";

            if (key == 0) китайскийToolStripMenuItem.Text = "Китайский";
            else китайскийToolStripMenuItem.Text = "中文";

            if (key == 0) увеличитьToolStripMenuItem.Text = "Увеличить";
            else увеличитьToolStripMenuItem.Text = "增加";

            if (key == 0) уменьшитьToolStripMenuItem.Text = "Уменьшить";
            else уменьшитьToolStripMenuItem.Text = "减少";

            if (key == 0) выделениеВсегоТекстаToolStripMenuItem.Text = "Выделить все";
            else выделениеВсегоТекстаToolStripMenuItem.Text = "选择全部";

            if (key == 0) постановкаЗадачиToolStripMenuItem.Text = "Постановка задачи";
            else постановкаЗадачиToolStripMenuItem.Text = "问题陈述";

            if (key == 0) грамматикаЯзыкаToolStripMenuItem.Text = "Грамматика";
            else грамматикаЯзыкаToolStripMenuItem.Text = "语法";

            if (key == 0) классификацияГрамматикиToolStripMenuItem.Text = "Классификация грамматики";
            else классификацияГрамматикиToolStripMenuItem.Text = "语法分类";

            if (key == 0) методАнализаToolStripMenuItem.Text = "Метод анализа";
            else методАнализаToolStripMenuItem.Text = "分析方法";

            if (key == 0) тестовыйПримерToolStripMenuItem.Text = "Тестовый пример";
            else тестовыйПримерToolStripMenuItem.Text = "测试用例";

            if (key == 0) списокЛитературыToolStripMenuItem.Text = "Список литературы";
            else списокЛитературыToolStripMenuItem.Text = "参考";

            if (key == 0) исходныйКодПрограммыToolStripMenuItem.Text = "Исходный код программы";
            else исходныйКодПрограммыToolStripMenuItem.Text = "程序源码";

            if (key == 0) вызовСправкиToolStripMenuItem.Text = "Вызов справки";
            else вызовСправкиToolStripMenuItem.Text = "寻求帮助";

            if (key == 0) оПрограммеToolStripMenuItem.Text = "О программе";
            else оПрограммеToolStripMenuItem.Text = "关于该计划";

            if (key == 0) outputBox.Columns[0].HeaderText = "Путь файла";
            else outputBox.Columns[0].HeaderText = "文件路径";

            if (key == 0) outputBox.Columns[1].HeaderText = "Строка";
            else outputBox.Columns[1].HeaderText = "线";

            if (key == 0) outputBox.Columns[2].HeaderText = "Колонка";
            else outputBox.Columns[2].HeaderText = "柱子";

            if (key == 0) outputBox.Columns[3].HeaderText = "Сообщение";
            else outputBox.Columns[3].HeaderText = "信息";

            if (key == 0) this.Text = "Языковой процессор";
            else this.Text = "语言处理器";

            if (key == 0) sec = "сек";
            else sec = "第二";

            if (key == 0) time = "Время работы приложения: ";
            else time = "申请开放时间";

            int hours = totalSec / 3600;
            int minutes = (totalSec % 3600) / 60;
            int seconds = totalSec % 60;

            string timeStatus;

            if (hours > 0) timeStatus = $"{hours}:{minutes}:{seconds}";
            else if (minutes > 0) timeStatus = $"{minutes}:{seconds}";
            else timeStatus = $"{seconds} " + sec;

            statusTimeApp.Text = time + timeStatus;
        }


        // Меню - Размер текста

        private void fontSize_Up(object sender, EventArgs e)
        {
            float size = buttonCancel.Font.Size;
            string font = buttonCancel.Font.Name;

            Size begin_size = this.Size;

            font_Change(this, size + 1, font);

            this.Size = begin_size;

            statusFont.Text = $"Шрифт: {font} {size + 1}pt";
        }
        private void fontSize_Down(object sender, EventArgs e)
        {
            float size = buttonCancel.Font.Size;
            string font = buttonCancel.Font.Name;

            font_Change(this, size - 1, font);

            statusFont.Text = $"Шрифт: {font} {size - 1}pt";
        }
        private void font_Change(Control control, float size, string font)
        {
            control.Font = new Font(font, size);
            foreach (Control sub in control.Controls)
            {
                font_Change(sub, size, font);
            }
        }

        // Строка состояния приложения

        private int totalSec = 0;
        private string sec = "сек";
        private string time = "Время работы приложения: ";
        private void timerApp_Tick(object sender, EventArgs e)
        {
            totalSec++;

            int hours = totalSec / 3600;
            int minutes = (totalSec % 3600) / 60;
            int seconds = totalSec % 60;

            string timeStatus;

            if (hours > 0) timeStatus = $"{hours}:{minutes}:{seconds}";
            else if (minutes > 0) timeStatus = $"{minutes}:{seconds}";
            else timeStatus = $"{seconds} " + sec;

            statusTimeApp.Text = time + timeStatus;
        }

        // Нумерация строк для окна редактирования

        private void UpdateLineNumbers(object sender)
        {
            RichTextBox inputBox = sender as RichTextBox;
            TabPage file = inputBox.Parent as TabPage;
            RichTextBox LineNumber = file.GetChildAtPoint(new Point(3, 3)) as RichTextBox;

            Point pt = new Point(0, 0);
            int First_Index = inputBox.GetCharIndexFromPosition(pt);
            int First_Line = inputBox.GetLineFromCharIndex(First_Index);

            pt.X = ClientRectangle.Width;
            pt.Y = ClientRectangle.Height;

            int Last_Index = inputBox.GetCharIndexFromPosition(pt);
            int Last_Line = inputBox.GetLineFromCharIndex(Last_Index);

            LineNumber.SelectionAlignment = HorizontalAlignment.Center;
            LineNumber.Text = "";
            for (int i = First_Line; i <= Last_Line; i++)
            {
                LineNumber.Text += i + 1 + "\n";
            }
        }
        private void inputBox_TextChanged(object sender, EventArgs e)
        {
            if(curr_row != inputBox.GetLineFromCharIndex(inputBox.GetFirstCharIndexOfCurrentLine()) || curr_row == 0)
            {
                UpdateLineNumbers(sender);
                curr_row = inputBox.GetLineFromCharIndex(inputBox.GetFirstCharIndexOfCurrentLine());
            }
        }

        private void inputBox_VScroll(object sender, EventArgs e)
        {
            RichTextBox inputBox = sender as RichTextBox;
            TabPage file = inputBox.Parent as TabPage;
            RichTextBox LineNumber = file.GetChildAtPoint(new Point(3, 3)) as RichTextBox;
            
            LineNumber.Text = "";
            UpdateLineNumbers(sender);
            LineNumber.Invalidate();
        }
        private void inputBox_SelectionChanged(object sender, EventArgs e)
        {
            RichTextBox inputBox = sender as RichTextBox;
            Point pt = inputBox.GetPositionFromCharIndex(inputBox.SelectionStart);
            if (pt.X == 0)
            {
                UpdateLineNumbers(sender);
            }
        }

        private void LineNumber_MouseDown(object sender, MouseEventArgs e)
        {
            RichTextBox lineNumber = sender as RichTextBox;
            TabPage file = lineNumber.Parent as TabPage;
            RichTextBox inputBox = file.GetChildAtPoint(new Point(51, 3)) as RichTextBox;

            int charIndex = lineNumber.GetCharIndexFromPosition(e.Location);
            int visualLineIndex = lineNumber.GetLineFromCharIndex(charIndex);

            // Проверяем, есть ли текст в этой строке lineNumber
            if (visualLineIndex < lineNumber.Lines.Length)
            {
                string lineText = lineNumber.Lines[visualLineIndex].Trim();

                if (int.TryParse(lineText, out int lineNumberValue) && lineNumberValue > 0)
                {
                    int targetLine = lineNumberValue - 1;

                    if (targetLine >= 0 && targetLine < inputBox.Lines.Length)
                    {
                        int startIndex = inputBox.GetFirstCharIndexFromLine(targetLine);
                        int lineLength = inputBox.Lines[targetLine].Length;

                        inputBox.Select(startIndex, lineLength);
                        
                        inputBox.Focus();
                    }
                }
            }
        }
        // Текущая строка
        private int curr_row = 0;
        // Текущее слово
        private string word = "";
        private void backfillkeywords(object sender, int pos, int len)
        {
            RichTextBox text_box = sender as RichTextBox;
            text_box.SelectionStart = pos;
            text_box.SelectionLength = len;
            text_box.SelectionBackColor = Color.Yellow;
            text_box.SelectionStart = pos + len;
            text_box.SelectionLength = 0;
            text_box.SelectionBackColor = Color.White;
        }
        // Подсветка ключевых слов
        private void inputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            RichTextBox text_box = sender as RichTextBox;
            if (e.KeyChar == '\r' || e.KeyChar == ' ' || e.KeyChar == '\0' || e.KeyChar == (char)Keys.Back)
            {
                int curr_pos = 0;
                if (e.KeyChar == '\r') curr_row--;
                switch (word.ToLower())
                {
                    case "if":
                        curr_pos = text_box.GetFirstCharIndexFromLine(curr_row) + text_box.Lines[curr_row].IndexOf(word);
                        backfillkeywords(text_box, curr_pos, word.Length);
                        e.Handled = true;
                        break;
                    case "else":
                        curr_pos = text_box.GetFirstCharIndexFromLine(curr_row) + text_box.Lines[curr_row].IndexOf(word);
                        backfillkeywords(text_box, curr_pos, word.Length);
                        e.Handled = true;
                        break;
                    case "int":
                        curr_pos = text_box.GetFirstCharIndexFromLine(curr_row) + text_box.Lines[curr_row].IndexOf(word);
                        backfillkeywords(text_box, curr_pos, word.Length);
                        e.Handled = true;
                        break;
                    case "float":
                        curr_pos = text_box.GetFirstCharIndexFromLine(curr_row) + text_box.Lines[curr_row].IndexOf(word);
                        backfillkeywords(text_box, curr_pos, word.Length);
                        e.Handled = true;
                        break;
                    case "while":
                        curr_pos = text_box.GetFirstCharIndexFromLine(curr_row) + text_box.Lines[curr_row].IndexOf(word);
                        backfillkeywords(text_box, curr_pos, word.Length);
                        e.Handled = true;
                        break;
                    case "for":
                        curr_pos = text_box.GetFirstCharIndexFromLine(curr_row) + text_box.Lines[curr_row].IndexOf(word);
                        backfillkeywords(text_box, curr_pos, word.Length);
                        e.Handled = true;
                        break;
                }
                word = "";
            }
            else word += e.KeyChar;
        }

        private void FormGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            if (files.SelectedIndex > -1)
            {
                result = MessageBox.Show("У вас есть несохраненный файл, сохранить?", "сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    сохранениеКакToolStripMenuItem.PerformClick();
                }
            }
        }
        public class ReportFile
        {
            public List<string> path = new List<string>();
            public List<string> line = new List<string>();
            public List<string> column = new List<string>();
            public List<string> message = new List<string>();
            public ReportFile(string path = "", string line = "0", string column = "0", string message = "")
            {
                addReport(path, line, column, message);
            }
            public void addReport(string path = "", string line = "0", string column = "0", string message = "")
            {
                this.path.Add(path);
                this.line.Add(line);
                this.column.Add(column);
                this.message.Add(message);
            }
        }

        private void outputBox_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            inputBox.Focus();
            if(e.RowIndex == -1) return;
            string position = outputBox.Rows[e.RowIndex].Cells[3].Value.ToString();
            string location = position.Split(' ')[1];
            string line = location.Split(',')[0];
            int numberLine = Convert.ToInt32(line);
            string inLine = position.Split(' ')[2];
            int positioninstr = Convert.ToInt32(inLine.Split('-')[0]);
            inputBox.Select(inputBox.GetFirstCharIndexFromLine(numberLine - 1) + positioninstr - 1, 1);
        }
    }
}
