using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe2
{
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
        }

        private void отменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undo();
        }

        void Undo ()
        {
            DisplayMethod(true);
            MessageBox.Show("метод Undo");
        }

        private void отчётToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Report();

        }

        void Report ()
        {
            MessageBox.Show("метод Report");
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New();
        }

        void New()
        {
            DisplayMethod(false);
            MessageBox.Show("метод New");
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit();
        }

        void Edit()
        {
            DisplayMethod(false);
            MessageBox.Show("метод Edit");
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }
        void Save()
        {

            DisplayMethod(true);
            MessageBox.Show("метод Save");
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Remove();
        }
        void Remove()
        {
            DisplayMethod(true);
            // MessageBox.Show("метод Remove");
            DialogResult result = MessageBox.Show(" Удалить данные \n по сотруднику ?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            switch (result)
            {
                case DialogResult.Yes:
                    {
                        //выполнить действия по удалению данных по сотруднику 
                        MessageBox.Show("Удаление данных");
                        break;
                    }
                case DialogResult.No:
                    {
                        //отмена удаления данных по сотруднику 
                        MessageBox.Show("Отмена удаления данных");
                        break;
                    }
            }

        }

        private void toolStripButtonUndo_Click(object sender, EventArgs e)
        {

            Undo();
            //DisplayReadOnly();
        }

        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
              New();
            //DisplayEdit();
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            Edit();
            //DisplayEdit();
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            Save();
            //DisplayReadOnly();
        }

        private void toolStripButtonRemove_Click(object sender, EventArgs e)
        {
            Remove();
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            DisplayMethod(true);
        }

        private void отменитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void создатьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            New();
        }

        private void редактироватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void сохранитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void удалитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Remove();
        }

        private void действиеToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabelEmployee.Text = "Выбор действий по сотрудникам";
        }

        private void действиеToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {

            toolStripStatusLabelEmployee.Text = "";

        }

        private void отменитьToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabelEmployee.Text = "Отменить редкатирование данных по сотруднику";
        }

        private void отменитьToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelEmployee.Text = "";
        }

        private void создатьToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabelEmployee.Text = "Создать новые данные по сотруднику";
        }

        private void создатьToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelEmployee.Text = "";
        }

        private void редактироватьToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabelEmployee.Text = "Редактировать данные по сотруднику";
        }

        private void редактироватьToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelEmployee.Text = "";
        }

        private void сохранитьToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabelEmployee.Text = "Сохранить данные по сотруднику";
        }

        private void сохранитьToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelEmployee.Text = "";
        }

        private void удалитьToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabelEmployee.Text = "Удалить данные по сотруднику";
        }

        private void удалитьToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelEmployee.Text = "";
        }

        private void поСотрудникуToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabelEmployee.Text = "Посмотреть отчёт по сотруднику";
        }

        private void поСотрудникуToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelEmployee.Text = "";
        }

        private void поСотрудникамToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabelEmployee.Text = "Посмотреть отчёт по сотрудникам";
        }

        private void поСотрудникамToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelEmployee.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void DisplayReadOnly()
        {
            this.textBoxSurname.ReadOnly = true;
            this.textBoxName.ReadOnly = true;
            this.textBoxPatronymic.ReadOnly = true;
            this.textBoxNetName.ReadOnly = true;
            this.comboBoxJobRole.Enabled = false;
            this.comboBoxStatus.Enabled = false;
            this.comboBoxAccess.Enabled = false;
        }
        public void DisplayEdit()
        {
            this.textBoxSurname.ReadOnly = false;
            this.textBoxName.ReadOnly = false;
            this.textBoxPatronymic.ReadOnly = false;
            this.textBoxNetName.ReadOnly = false; 
            this.comboBoxJobRole.Enabled = true;
            this.comboBoxStatus.Enabled = true;
            this.comboBoxAccess.Enabled = true;
        }

        public void DisplayReadOnly(bool ReadOnly)
        {
            this.textBoxSurname.ReadOnly = ReadOnly;
            this.textBoxName.ReadOnly = ReadOnly;
            this.textBoxPatronymic.ReadOnly = ReadOnly;
            this.textBoxNetName.ReadOnly = ReadOnly;
            this.comboBoxJobRole.Enabled = !ReadOnly;
            this.comboBoxStatus.Enabled = !ReadOnly;
            this.comboBoxAccess.Enabled = !ReadOnly;
        }
        private void DisplayReadOnly(object sender, EventArgs e)
        {
           
        }
        private void MainMenu(bool state)
        {
            отменитьToolStripMenuItem.Enabled = !state;
            создатьToolStripMenuItem.Enabled = state;
            сохранитьToolStripMenuItem.Enabled = !state;
            редактироватьToolStripMenuItem.Enabled = state;
            удалитьToolStripMenuItem.Enabled = state;
        }
        private void MenuContex(bool state)
        {
            отменитьToolStripMenuItem1.Enabled = !state;
            создатьToolStripMenuItem1.Enabled = state;
            сохранитьToolStripMenuItem1.Enabled = !state;
            редактироватьToolStripMenuItem1.Enabled = state;
            удалитьToolStripMenuItem1.Enabled = state;
        }
        private void MenuTool(bool state)
        {
            toolStripButtonUndo.Enabled = !state;
            toolStripButtonNew.Enabled = state;
            toolStripButtonEdit.Enabled = state;
            toolStripButtonSave.Enabled = !state;
            toolStripButtonRemove.Enabled = state;
        }

        private void Elements(bool state)
        {
            this.textBoxSurname.ReadOnly = state;
            this.textBoxName.ReadOnly = state;
            this.textBoxPatronymic.ReadOnly = state;
            this.textBoxNetName.ReadOnly = state;
            this.comboBoxJobRole.Enabled = !state;
            this.comboBoxStatus.Enabled = !state;
            this.comboBoxAccess.Enabled = !state;
        }

        private void DisplayMethod(bool mode)
        {
            MainMenu(mode);
            MenuContex(mode);
            Elements(mode);
            MenuTool(mode);
        }
    }

}

