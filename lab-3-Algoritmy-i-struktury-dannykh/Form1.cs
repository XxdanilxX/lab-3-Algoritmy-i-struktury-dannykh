namespace lab_3_Algoritmy_i_struktury_dannykh
{
    public partial class Form1 : Form
    {
        
        Queue<int> queue = new Queue<int>();

        
        Stack<int> stackL1 = new Stack<int>();
        Stack<int> stackL2 = new Stack<int>();
        Stack<int> stackL = new Stack<int>();

        public Form1()
        {
            InitializeComponent();
        }
              
        // Створити чергу з послідовності чисел
        private void CreateQueue(string input)
        {
            var numbers = input.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            queue.Clear(); 
            foreach (var number in numbers)
            {
                if (int.TryParse(number, out int result))
                {
                    queue.Enqueue(result); // додаємо тільки числа
                }
                else
                {
                    MessageBox.Show($"Помилка: '{number}' не є числом.", "Некоректне введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }
            }
        }

        // Видалити всі негативні числа
        private void RemoveNegativeNumbers()
        {
            queue = new Queue<int>(queue.Where(x => x >= 0));
        }

        // Вивести чергу
        private string DisplayQueue()
        {
            return string.Join(", ", queue);
        }

        private void btnCreateQueue_Click(object sender, EventArgs e)
        {
            CreateQueue(txtQueueInput.Text);
            lblQueueOutput.Text = "Черга: " + DisplayQueue();
        }

        private void btnRemoveNegatives_Click(object sender, EventArgs e)
        {
            RemoveNegativeNumbers();
            lblQueueOutput.Text = "Черга після видалення негативних: " + DisplayQueue();
        }


        // Створити стек L1 і L2
        private void CreateStacks(string input1, string input2)
        {
            var numbers1 = input1.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            var numbers2 = input2.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            stackL1.Clear(); 
            stackL2.Clear();

            foreach (var number in numbers1)
            {
                if (int.TryParse(number, out int result))
                {
                    stackL1.Push(result); // додаємо тільки числа
                }
                else
                {
                    MessageBox.Show($"Помилка: '{number}' не є числом.", "Некоректне введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }
            }

            foreach (var number in numbers2)
            {
                if (int.TryParse(number, out int result))
                {
                    stackL2.Push(result); 
                }
                else
                {
                    MessageBox.Show($"Помилка: '{number}' не є числом.", "Некоректне введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        // Об'єднати елементи L1 і L2 в L 
        private void MergeStacks()
        {
            var uniqueElements = new HashSet<int>(stackL1.Concat(stackL2));
            stackL = new Stack<int>(uniqueElements);
        }

        // Вивести стек
        private string DisplayStack(Stack<int> stack)
        {
            return string.Join(", ", stack);
        }

        private void btnCreateStacks_Click(object sender, EventArgs e)
        {
            CreateStacks(txtStackInput1.Text, txtStackInput2.Text);
            lblStackOutputL1.Text = "Стек L1: " + DisplayStack(stackL1);
            lblStackOutputL2.Text = "Стек L2: " + DisplayStack(stackL2);
        }

        private void btnMergeStacks_Click(object sender, EventArgs e)
        {
            MergeStacks();
            lblStackOutputL.Text = "Стек L: " + DisplayStack(stackL);
        }
    }
}
