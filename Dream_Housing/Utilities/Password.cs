using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dream_Housing.Utilities
{
	public class Password
	{

		/*
		  	____________________________________
			| Cost  | Iterations               |
			|-------|--------------------------|
			|   8   |    256 iterations        | Medium security, slower
			|   9   |    512 iterations        |
			|  10   |  1,024 iterations        | Default security, moderate speed (commonly used)
			|  11   |  2,048 iterations        |
			|  12   |  4,096 iterations        | High security, slower
			|  13   |  8,192 iterations        |
			|  14   | 16,384 iterations        | Very high security, significantly slower
			|  15   | 32,768 iterations        |
			|  16   | 65,536 iterations        | Extreme security, very slow
			|  17   | 131,072 iterations       |
			|  18   | 262,144 iterations       | Maximum security, extremely slow
			|  19   | 524,288 iterations       |
			|  20   | 1,048,576 iterations     |
			|  21   | 2,097,152 iterations     |
			|  22   | 4,194,304 iterations     |
			|  23   | 8,388,608 iterations     |
			|  24   | 16,777,216 iterations    |
			|  25   | 33,554,432 iterations    |
			|  26   | 67,108,864 iterations    |
			|  27   | 134,217,728 iterations   |
			|  28   | 268,435,456 iterations   |
			|  29   | 536,870,912 iterations   |
			|  30   | 1,073,741,824 iterations |
			|  31   | 2,147,483,648 iterations |
			|  32   | 4,294,967,296 iterations |
			|_______|__________________________|
		*/


		private const int iterations_workFactor = 13;

		public static string Hash(string password)
		{
			string HashedPassword = BCrypt.Net.BCrypt.EnhancedHashPassword(password, iterations_workFactor);
			Console.WriteLine(HashedPassword);
			return HashedPassword;
		}

		public static bool Verify(string password, string hashed_password)
		{
			return BCrypt.Net.BCrypt.EnhancedVerify(password, hashed_password);
		}
	}
}