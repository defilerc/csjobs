namespace CodeFights
{
    public class BankRequests
    {
        public int[] bankRequests(int[] accounts, string[] requests)
        {
            for (var i = 0; i < requests.Length; i++)
            {
                var request = requests[i].Split(' ');

                int account, amount, dest = 0;

                if (request[0] == "deposit")
                {
                    account = int.Parse(request[1]) - 1;
                    amount = int.Parse(request[2]);

                    if (!ValidateAccount(account, accounts))
                    {
                        return new[] { -(i + 1) };
                    }

                    accounts[account] += amount;
                }
                else if (request[0] == "withdraw")
                {
                    account = int.Parse(request[1]) - 1;
                    amount = int.Parse(request[2]);

                    if (!ValidateAccount(account, accounts) || accounts[account] < amount)
                    {
                        return new[] { -(i + 1) };
                    }

                    accounts[account] -= amount;
                }
                else if (request[0] == "transfer")
                {
                    account = int.Parse(request[1]) - 1;
                    dest = int.Parse(request[2]) - 1;
                    amount = int.Parse(request[3]);

                    if (!ValidateAccount(account, accounts) || !ValidateAccount(dest, accounts) || accounts[account] < amount)
                    {
                        return new[] { -(i + 1) };
                    }

                    accounts[account] -= amount;
                    accounts[dest] += amount;
                }
            }

            return accounts;
        }

        bool ValidateAccount(int account, int[] accounts)
        {
            return account >= 0 && account < accounts.Length;
        }
    }
}