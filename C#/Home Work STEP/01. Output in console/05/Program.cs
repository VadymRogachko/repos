using System;

namespace _05
{
	class Program
	{
		private const int consoleBufferWidth = 150;
		private const int consoleWindowWidth = 150;

		static void Main(string[] args)
		{
			Console.BufferWidth = consoleBufferWidth;
			Console.WindowWidth = consoleWindowWidth;
			Console.WriteLine("*               *  *         * * *   *        * *         *     * * *      * * *       * * *         *          * * *   *       * *    *  * * *");
			Console.WriteLine(" *             *  * *        *     *  *      *  * *     * *     *     *   *     *     *     *       * *        *     *  *       * *   *  *     *");
			Console.WriteLine("  *           *  *   *       *      *  *    *   *  *   *  *     *      * *       *   *       *     *   *      *       * *       * *  *  *       *");
			Console.WriteLine("   *         *  *     *      *       *  * *     *   * *   *     *     *  *        * *             *     *    *          *       * * *   *        *");
			Console.WriteLine("    *       *  *       *     *       *   *      *    *    *     * * *    *        * *            *       *   *          ********* *     *        *");
			Console.WriteLine("     *     *  ***********    *       *   *      *         *     * *      *        * * * * * *   ***********  *          *       * * *   *        *");
			Console.WriteLine("      *   *  *           *   *      *    *      *         *     *   *     *       *  *       * *           *  *       * *       * *  *   *       *");
			Console.WriteLine("       * *  *             *  *     *     *      *         *     *     *    *     *    *     * *             *  *     *  *       * *   *   *     *");
			Console.WriteLine("        *  *               * * * *       *      *         *     *       *   * * *      * * * *               *  * * *   *       * *    *   * * *");

			Console.ReadKey();
		}
	}
}
