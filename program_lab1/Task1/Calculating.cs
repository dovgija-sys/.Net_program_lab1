namespace program_lab1
{
    public class ClassForСalculations
    {
        public double[,] xy = new double[1000, 2];
        public int n = 0;
        private double F1(double x) => Math.Pow(Math.Abs(x), 5) * (1.0 / Math.Tan(x + 2));
        private double F2(double x) => (5 * x + x * x) / Math.Pow((x * x + 3), 3);
        private double F3(double x) => Math.Pow(Math.Sin(x + 3), 2) / (Math.Pow(x, 5) - (1.0 / Math.Tan(Math.PI * Math.Pow(x, 3))));

        public void Tab(double xn = 3.35,
                        double xk = 36.26,
                        double h = 0.2,
                        double a = 1)
        {
            double x = xn, y;
            int i = 0;
            while (x <= xk)
            {
                if (x < 0)
                {
                    y = F1(x);
                }
                else if (x < a && x >= 0)
                {
                    y = F2(x);
                }
                else
                {
                    y = F3(x);
                }
                xy[i, 0] = x;
                xy[i, 1] = y;
                x += h;
                i++;
            }
            n = i;
        }
    }
}
