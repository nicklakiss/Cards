Console.Write("Введите масть карты: Пика Червь Бубна Трефь   ");
string CardSuit = Console.ReadLine();
Console.Write("Введите значение карты: Шестерка Семерка Восьмерка Девятка Десятка Валет Дама Король Туз   ");
string CardMeaning = Console.ReadLine();

if (CardSuit.ToLower().Trim() == "пика" && CardMeaning.ToLower().Trim() == "шестерка")
{
    Console.WriteLine("*******************************");
    Console.WriteLine("*  ***   *****                *");
    Console.WriteLine("* *      *   *                *");
    Console.WriteLine("* ***    *   *                *");
    Console.WriteLine("* *  *   *   *                *");
    Console.WriteLine("*  **    *   *                *");
    Draw();
}
else if (CardSuit.ToLower().Trim() == "червь" && CardMeaning.ToLower().Trim() == "шестерка")
{
    Console.WriteLine("*******************************");
    Console.WriteLine("*  ***  *   *                 *");
    Console.WriteLine("* *     *   *                 *");
    Console.WriteLine("* ***    ****                 *");
    Console.WriteLine("* *  *      *                 *");
    Console.WriteLine("*  **       *                 *");
    Draw();
}
else if (CardSuit.ToLower().Trim() == "бубна" && CardMeaning.ToLower().Trim() == "шестерка")
{
    Console.WriteLine("*******************************");
    Console.WriteLine("*  ***    *****               *");
    Console.WriteLine("* *       *                   *");
    Console.WriteLine("* ****    *****               *");
    Console.WriteLine("* *   *   *   *               *");
    Console.WriteLine("*  ***    *****               *");
    Draw();
}
else if (CardSuit.ToLower().Trim() == "терфь" && CardMeaning.ToLower().Trim() == "шестерка")
{
    Console.WriteLine("*******************************");
    Console.WriteLine("*  ***    *****               *");
    Console.WriteLine("* *         *                 *");
    Console.WriteLine("* ***       *                 *");
    Console.WriteLine("* *  *      *                 *");
    Console.WriteLine("*  **       *                 *");
    Draw();
}
else if (CardSuit.ToLower().Trim() == "пика" && CardMeaning.ToLower().Trim() == "семерка")
{
    Console.WriteLine("*******************************");
    Console.WriteLine("* *****   *****               *");
    Console.WriteLine("* *   *   *   *               *");
    Console.WriteLine("*     *   *   *               *");
    Console.WriteLine("*     *   *   *               *");
    Console.WriteLine("*     *   *   *               *");
    Draw();
}
else if (CardSuit.ToLower().Trim() == "червь" && CardMeaning.ToLower().Trim() == "семерка")
{
    Console.WriteLine("*******************************");
    Console.WriteLine("* *****  *   *               *");
    Console.WriteLine("* *   *  *   *                *");
    Console.WriteLine("*     *   ****                *");
    Console.WriteLine("*     *      *                *");
    Console.WriteLine("*     *      *                *");
    Draw();
}
else if (CardSuit.ToLower().Trim() == "бубна" && CardMeaning.ToLower().Trim() == "семерка")
{
    Console.WriteLine("*******************************");
    Console.WriteLine("* *****    ***                *");
    Console.WriteLine("* *   *   *                   *");
    Console.WriteLine("*     *   ****                *");
    Console.WriteLine("*     *   *   *               *");
    Console.WriteLine("*     *    ***                *");
    Draw();
}
else if (CardSuit.ToLower().Trim() == "терфь" && CardMeaning.ToLower().Trim() == "семерка")
{
    Console.WriteLine("*******************************");
    Console.WriteLine("* *****   *****               *");
    Console.WriteLine("* *   *     *                 *");
    Console.WriteLine("*     *     *                 *");
    Console.WriteLine("*     *     *                 *");
    Console.WriteLine("*     *     *                 *");
    Draw();
}
else if (CardSuit.ToLower().Trim() == "пика" && CardMeaning.ToLower().Trim() == "восьмерка")
{
    Console.WriteLine("*******************************");
    Console.WriteLine("* *****   *****               *");
    Console.WriteLine("* *   *   *   *               *");
    Console.WriteLine("* *****   *   *               *");
    Console.WriteLine("* *   *   *   *               *");
    Console.WriteLine("* *****   *   *               *");
    Draw();
}
else if (CardSuit.ToLower().Trim() == "червь" && CardMeaning.ToLower().Trim() == "восьмерка")
{
    Console.WriteLine("*******************************");
    Console.WriteLine("* *****   *   *               *");
    Console.WriteLine("* *   *   *   *               *");
    Console.WriteLine("* *****    ****               *");
    Console.WriteLine("* *   *       *               *");
    Console.WriteLine("* *****       *               *");
    Draw();
}
else if (CardSuit.ToLower().Trim() == "бубна" && CardMeaning.ToLower().Trim() == "восьмерка")
{
    Console.WriteLine("*******************************");
    Console.WriteLine("* *****   *****               *");
    Console.WriteLine("* *   *   *                   *");
    Console.WriteLine("* *****   *****               *");
    Console.WriteLine("* *   *   *   *               *");
    Console.WriteLine("* *****   *****               *");
    Draw();
}
else if (CardSuit.ToLower().Trim() == "терфь" && CardMeaning.ToLower().Trim() == "восьмерка")
{
    Console.WriteLine("*******************************");
    Console.WriteLine("* *****   *****               *");
    Console.WriteLine("* *   *     *                 *");
    Console.WriteLine("* *****     *                *");
    Console.WriteLine("* *   *     *                 *");
    Console.WriteLine("* *****     *                 *");
    Draw();
}
else if (CardSuit.ToLower().Trim() == "бубна" && CardMeaning.ToLower().Trim() == "девятка")
{
    Console.WriteLine("*******************************");
    Console.WriteLine("*  ***   *****                *");
    Console.WriteLine("* *   *  *                    *");
    Console.WriteLine("*  ****  *****                *");
    Console.WriteLine("*     *  *   *                *");
    Console.WriteLine("*  ***   *****                *");
    Draw();
}
else if (CardSuit.ToLower().Trim() == "пика" && CardMeaning.ToLower().Trim() == "девятка")
{
    Console.WriteLine("*******************************");
    Console.WriteLine("*  ***   *****                *");
    Console.WriteLine("* *   *  *   *                *");
    Console.WriteLine("*  ****  *   *                *");
    Console.WriteLine("*     *  *   *                *");
    Console.WriteLine("*  ***   *   *                *");
    Draw();
}
else if (CardSuit.ToLower().Trim() == "бубна" && CardMeaning.ToLower().Trim() == "девятка")
{
    Console.WriteLine("*******************************");
    Console.WriteLine("*  ***   *   *                *");
    Console.WriteLine("* *   *  *   *                *");
    Console.WriteLine("*  ****   ****                *");
    Console.WriteLine("*     *      *                *");
    Console.WriteLine("*  ***       *                *");
    Draw();
}
else if (CardSuit.ToLower().Trim() == "терфь" && CardMeaning.ToLower().Trim() == "девятка")
{
    Console.WriteLine("*******************************");
    Console.WriteLine("*  ****  *****                *");
    Console.WriteLine("* *   *    *                  *");
    Console.WriteLine("*  ****    *                  *");
    Console.WriteLine("*     *    *                  *");
    Console.WriteLine("*  ***     *                  *");
    Draw();
}
else if (CardSuit.ToLower().Trim() == "бубна" && CardMeaning.ToLower().Trim() == "десятка")
{
    Console.WriteLine("*******************************");
    Console.WriteLine("*  *  ***   *****             *");
    Console.WriteLine("*  * *   *  *                 *");
    Console.WriteLine("*  * *   *  *****             *");
    Console.WriteLine("*  * *   *  *   *             *");
    Console.WriteLine("*  *  ***   *****             *");
    Draw();
}
else if (CardSuit.ToLower().Trim() == "червь" && CardMeaning.ToLower().Trim() == "десятка")
{
    Console.WriteLine("*******************************");
    Console.WriteLine("*  *  ***   *   *            *");
    Console.WriteLine("*  * *   *  *   *             *");
    Console.WriteLine("*  * *   *   ****             *");
    Console.WriteLine("*  * *   *      *             *");
    Console.WriteLine("*  *  ***       *             *");
    Draw();
}
else if (CardSuit.ToLower().Trim() == "пика" && CardMeaning.ToLower().Trim() == "десятка")
{
    Console.WriteLine("*******************************");
    Console.WriteLine("*  *  ***   *****             *");
    Console.WriteLine("*  * *   *  *   *             *");
    Console.WriteLine("*  * *   *  *   *             *");
    Console.WriteLine("*  * *   *  *   *             *");
    Console.WriteLine("*  *  ***   *   *             *");
    Draw();
}
else if (CardSuit.ToLower().Trim() == "терфь" && CardMeaning.ToLower().Trim() == "десятка")
{
    Console.WriteLine("*******************************");
    Console.WriteLine("*  *  ***  *****              *");
    Console.WriteLine("*  * *   *   *                *");
    Console.WriteLine("*  * *   *   *                *");
    Console.WriteLine("*  * *   *   *                *");
    Console.WriteLine("*  *  ***    *                *");
    Draw();
}
else if (CardSuit.ToLower().Trim() == "бубна" && CardMeaning.ToLower().Trim() == "валет")
{
    Console.WriteLine("*******************************");
    Console.WriteLine("* ****    *****               *");
    Console.WriteLine("* *   *   *                   *");
    Console.WriteLine("* *****   *****               *");
    Console.WriteLine("* *   *   *   *               *");
    Console.WriteLine("* ****    *****               *");
    Draw();
}
else if (CardSuit.ToLower().Trim() == "червь" && CardMeaning.ToLower().Trim() == "валет")
{
    Console.WriteLine("*******************************");
    Console.WriteLine("* ****    *   *               *");
    Console.WriteLine("* *   *   *   *               *");
    Console.WriteLine("* *****    ****               *");
    Console.WriteLine("* *   *       *               *");
    Console.WriteLine("* ****        *               *");
    Draw();
}
else if (CardSuit.ToLower().Trim() == "пика" && CardMeaning.ToLower().Trim() == "валет")
{
    Console.WriteLine("*******************************");
    Console.WriteLine("* ****    *****               *");
    Console.WriteLine("* *   *   *   *               *");
    Console.WriteLine("* *****   *   *               *");
    Console.WriteLine("* *   *   *   *               *");
    Console.WriteLine("* ****    *   *               *");
    Draw();
}
else if (CardSuit.ToLower().Trim() == "тервь" && CardMeaning.ToLower().Trim() == "валет")
{
    Console.WriteLine("*******************************");
    Console.WriteLine("* ****    *****               *");
    Console.WriteLine("* *   *     *                 *");
    Console.WriteLine("* *****     *                 *");
    Console.WriteLine("* *   *     *                 *");
    Console.WriteLine("* ****      *                 *");
    Draw();
}
else if (CardSuit.ToLower().Trim() == "бубна" && CardMeaning.ToLower().Trim() == "дама")
{
    Console.WriteLine("*******************************");
    Console.WriteLine("*   ***    *****              *");
    Console.WriteLine("*  *   *   *                  *");
    Console.WriteLine("*  *   *   *****              *");
    Console.WriteLine("*  *****   *   *              *");
    Console.WriteLine("* *     *  *****              *");
    Draw();
}
else if (CardSuit.ToLower().Trim() == "червь" && CardMeaning.ToLower().Trim() == "Дама")
{
    Console.WriteLine("*******************************");
    Console.WriteLine("*   ***    *   *              *");
    Console.WriteLine("*  *   *   *   *              *");
    Console.WriteLine("*  *   *    ****              *");
    Console.WriteLine("*  *****       *              *");
    Console.WriteLine("* *     *      *              *");
    Draw();
}
else if (CardSuit.ToLower().Trim() == "пика" && CardMeaning.ToLower().Trim() == "дама")
{
    Console.WriteLine("*******************************");
    Console.WriteLine("*   ***    *****              *");
    Console.WriteLine("*  *   *   *   *               *");
    Console.WriteLine("*  *   *   *   *              *");
    Console.WriteLine("*  *****   *   *              *");
    Console.WriteLine("* *     *  *   *              *");
    Draw();
}
else if (CardSuit.ToLower().Trim() == "трефь" && CardMeaning.ToLower().Trim() == "дама")
{
    Console.WriteLine("*******************************");
    Console.WriteLine("*   ***    *****              *");
    Console.WriteLine("*  *   *     *                *");
    Console.WriteLine("*  *   *     *                *");
    Console.WriteLine("*  *****     *                *");
    Console.WriteLine("* *     *    *                *");
    Draw();
}
else if (CardSuit.ToLower().Trim() == "Бубна" && CardMeaning.ToLower().Trim() == "Король")
{
    Console.WriteLine("*******************************");
    Console.WriteLine("*  *    *   *****             *");
    Console.WriteLine("*  *   *    *                 *");
    Console.WriteLine("*  * *      *****             *");
    Console.WriteLine("*  *   *    *   *             *");
    Console.WriteLine("*  *     *  *****             *");
    Draw();
}
else if (CardSuit.ToLower().Trim() == "пика" && CardMeaning.ToLower().Trim() == "король")
{
    Console.WriteLine("*******************************");
    Console.WriteLine("*  *    *   *****             *");
    Console.WriteLine("*  *   *    *   *             *");
    Console.WriteLine("*  * *      *   *             *");
    Console.WriteLine("*  *   *    *   *             *");
    Console.WriteLine("*  *     *  *   *             *");
    Draw();
}
else if (CardSuit.ToLower().Trim() == "терфь" && CardMeaning.ToLower().Trim() == "король")
{
    Console.WriteLine("*******************************");
    Console.WriteLine("*  *    *   *   *             *");
    Console.WriteLine("*  *   *    *   *              *");
    Console.WriteLine("*  * *       ****             *");
    Console.WriteLine("*  *   *        *             *");
    Console.WriteLine("*  *     *      *             *");
    Draw();
}
else if (CardSuit.ToLower().Trim() == "трефь" && CardMeaning.ToLower().Trim() == "король")
{
    Console.WriteLine("*******************************");
    Console.WriteLine("*  *    *   *****             *");
    Console.WriteLine("*  *   *      *               *");
    Console.WriteLine("*  * *        *               *");
    Console.WriteLine("*  *   *      *               *");
    Console.WriteLine("*  *     *    *               *");
    Draw();
}
else if (CardSuit.ToLower().Trim() == "бубна" && CardMeaning.ToLower().Trim() == "туз")
{
    Console.WriteLine("*******************************");
    Console.WriteLine("*  ******   *****             *");
    Console.WriteLine("*    *      *                 *");
    Console.WriteLine("*    *      *****             *");
    Console.WriteLine("*    *      *   *             *");
    Console.WriteLine("*    *      *****             *");
    Draw();
}
else if (CardSuit.ToLower().Trim() == "пика" && CardMeaning.ToLower().Trim() == "туз")
{
    Console.WriteLine("*******************************");
    Console.WriteLine("*  ******   *****             *");
    Console.WriteLine("*    *      *   *             *");
    Console.WriteLine("*    *      *   *             *");
    Console.WriteLine("*    *      *   *             *");
    Console.WriteLine("*    *      *   *             *");
    Draw();
}
else if (CardSuit.ToLower().Trim() == "червь" && CardMeaning.ToLower().Trim() == "туз")
{
    Console.WriteLine("*******************************");
    Console.WriteLine("*  ******   *   *             *");
    Console.WriteLine("*    *      *   *              *");
    Console.WriteLine("*    *       ****             *");
    Console.WriteLine("*    *          *             *");
    Console.WriteLine("*    *          *             *");
    Draw();
}
else if (CardSuit.ToLower().Trim() == "терфь" && CardMeaning.ToLower().Trim() == "туз")
{
    Console.WriteLine("*******************************");
    Console.WriteLine("*  ******   *****             *");
    Console.WriteLine("*    *        *               *");
    Console.WriteLine("*    *        *               *");
    Console.WriteLine("*    *        *               *");
    Console.WriteLine("*    *        *               *");
    Draw();
}

static void Draw()
{
    Console.WriteLine("*                             *");
    Console.WriteLine("*                             *");
    Console.WriteLine("*                             *");
    Console.WriteLine("*                             *");
    Console.WriteLine("*                             *");
    Console.WriteLine("*                             *");
    Console.WriteLine("*                             *");
    Console.WriteLine("*                             *");
    Console.WriteLine("*                             *");
    Console.WriteLine("*                             *");
    Console.WriteLine("*                             *");
    Console.WriteLine("*                             *");
    Console.WriteLine("*                             *");
    Console.WriteLine("*                             *");
    Console.WriteLine("*                             *");
    Console.WriteLine("*                             *");
    Console.WriteLine("*                             *");
    Console.WriteLine("*                             *");
    Console.WriteLine("*******************************");
}
