using MyApp;

namespace BankAccountTest
{
    public class TestBankAccount
    {
        [Theory]
        [InlineData(1000,500,1500)]
        [InlineData(-500, 500, 0)]
        [InlineData(0, -500, 0)]
        public void MakeDeposit_ShouldIncreaseBalance(float initalBalance,
            float depositAmount, float expectedBalance)
        {
            // Arrange / Einrichten
            BankAccount account = new BankAccount(
                "123456", "John Doe", initalBalance
                );

            

            // Act / Ausführen
            account.MakeDeposit(depositAmount);

            // Assert / Geltend machen
            Assert.Equal(expectedBalance, account.Balance);
        }
    }
}
