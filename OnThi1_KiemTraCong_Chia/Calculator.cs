namespace OnThi1_KiemTraCong_Chia
{
    public class Calculator
    {
        public int Cong(int a, int b)
        {
            return a + b;
        }
        public int Chia(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Khong the chia cho 0");
            }
            return a / b;
        }
    }
}
