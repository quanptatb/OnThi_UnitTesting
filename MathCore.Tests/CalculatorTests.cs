using NUnit.Framework;
using OnThi1_KiemTraCong_Chia;
using System;

namespace MathCore.Tests
{
    [TestFixture] // đánh dấu lớp này là một bộ kiểm tra NUnit
    public class CalculatorTests
    {
        private Calculator _cal;
        [SetUp] // phương thức này sẽ được gọi trước mỗi phương thức kiểm tra
        public void Setup()
        {
            _cal = new Calculator(); //khởi tạo đối tượng trước khi test
        }

        [Test] //đánh dấu đây là một bài test (testcase)
        public void Cong_HaiSoDuong_TraVeKetQuaDung()
        {
            // Arrange (chuẩn bị dữ liệu)
            int soA = 10;
            int soB = 20;
            int KetQuaMongDoi = 30;

            // Act (thực hiện hành động cần kiểm tra)
            int KetQuaThucTe = _cal.Cong(soA, soB);

            // Assert (xác nhận kết quả)
            Assert.That(KetQuaThucTe, Is.EqualTo(KetQuaMongDoi));
        }
        [Test]
        public void Chia_ChoSoKhong_NemRaLoi()
        {
            Assert.That(() => _cal.Chia(10, 0), Throws.TypeOf<DivideByZeroException>()); //kiểm tra xem có ném ra ngoại lệ không
        }
    }
}
