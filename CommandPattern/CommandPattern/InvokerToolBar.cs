namespace CommandPattern
{
    partial class Program
    {
        class InvokerToolBar
        {
            IButtonCommand btn;
            public InvokerToolBar(IButtonCommand btn)
            {
                this.btn = btn;
            }

            public void ExecuteCommandClick()
            {
                btn.Execute();
            }
        }

    }
}
