using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using 策略模式.Entity;

namespace 策略模式
{
    public partial class Form1 : Form
    {
        decimal totalMoney = 0M;
        string resutlMsg = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                //简单工厂模式
                //CashSuper cashSuper = CashFactory.CreateCashAccept(txtRebate.SelectedItem.ToString());
                //decimal money = cashSuper.AcceptCash((int.Parse(txtNum.Text) * decimal.Parse(txtPrice.Text)));  

                //策略模式与简单工厂的结合
                StrategyContext cashSuper =  new StrategyContext(txtRebate.SelectedItem.ToString());
                decimal money = cashSuper.ContextInterface((int.Parse(txtNum.Text) * decimal.Parse(txtPrice.Text)));
                totalMoney = totalMoney + money;
                txtTotal.Text = totalMoney.ToString();
                resutlMsg = resutlMsg + string.Format("商品数量：{0}，单价：{1}￥，优惠方式{2}，合计金额：{3};￥\r\n", txtNum.Text, txtPrice.Text,txtRebate.SelectedItem.ToString(), money);
                txtDetail.Text = resutlMsg;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"错误信息", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtRebate.Items.AddRange(new object[] {"正常收费","打九折","满300减20"});
            txtRebate.SelectedItem = "正常收费";
            txtTotal.Text = totalMoney.ToString();
            txtNum.Text = "0";
            txtPrice.Text = "0.00";
        }
        //验证只能输入数字
        private void txtNum_Validating(object sender, CancelEventArgs e)
        {
            const string pattern = @"^[-]?[1-9]{1}\d*$|^[0]{1}$";
            string content = ((TextBox)sender).Text;
            if (!(Regex.IsMatch(content, pattern)))
            {
                errorProvider1.SetError((Control)sender,"只能输入数字!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError((Control)sender,null);
            }
        }
    }
}
