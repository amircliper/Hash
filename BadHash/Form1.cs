using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadHash
{
    public partial class BadHasher : Form
    {
        public BadHasher()
        {
            InitializeComponent();
            GetValue();

        }

        private void COdeBtn_Click(object sender, EventArgs e)
        {
            ForReturn = "";
            var input = OutputText.Text;
            input = ClearDecoder(input.ToLower());
            Decoder(input);
            OutputDecoderTxt.Text = ForReturn;
        }

        public static string ForReturn;
        public static char[,] Core = new char[27, 27];
        public static readonly Random Random = new Random();
        private static void GetValue()
        {
            #region Create Core
            //floor1
            Core[1, 01] = 'a';
            Core[1, 02] = 'b';
            Core[1, 03] = 'c';
            Core[1, 04] = 'd';
            Core[1, 05] = 'e';
            Core[1, 06] = 'f';
            Core[1, 07] = 'g';
            Core[1, 08] = 'h';
            Core[1, 09] = 'i';
            Core[1, 10] = 'j';
            Core[1, 11] = 'k';
            Core[1, 12] = 'l';
            Core[1, 13] = 'm';
            Core[1, 14] = 'n';
            Core[1, 15] = 'o';
            Core[1, 16] = 'p';
            Core[1, 17] = 'q';
            Core[1, 18] = 'r';
            Core[1, 19] = 's';
            Core[1, 20] = 't';
            Core[1, 21] = 'u';
            Core[1, 22] = 'v';
            Core[1, 23] = 'w';
            Core[1, 24] = 'x';
            Core[1, 25] = 'y';
            Core[1, 26] = 'z';
            //floor2
            Core[2, 1] = 'b';
            Core[2, 2] = 'c';
            Core[2, 3] = 'd';
            Core[2, 4] = 'e';
            Core[2, 5] = 'f';
            Core[2, 6] = 'g';
            Core[2, 7] = 'h';
            Core[2, 8] = 'i';
            Core[2, 9] = 'j';
            Core[2, 10] = 'k';
            Core[2, 11] = 'l';
            Core[2, 12] = 'm';
            Core[2, 13] = 'n';
            Core[2, 14] = 'o';
            Core[2, 15] = 'p';
            Core[2, 16] = 'q';
            Core[2, 17] = 'r';
            Core[2, 18] = 's';
            Core[2, 19] = 't';
            Core[2, 20] = 'u';
            Core[2, 21] = 'v';
            Core[2, 22] = 'w';
            Core[2, 23] = 'x';
            Core[2, 24] = 'y';
            Core[2, 25] = 'z';
            Core[2, 26] = 'a';
            //floor3
            Core[3, 1] = 'c';
            Core[3, 2] = 'd';
            Core[3, 3] = 'e';
            Core[3, 4] = 'f';
            Core[3, 5] = 'g';
            Core[3, 6] = 'h';
            Core[3, 7] = 'i';
            Core[3, 8] = 'j';
            Core[3, 9] = 'k';
            Core[3, 10] = 'l';
            Core[3, 11] = 'm';
            Core[3, 12] = 'n';
            Core[3, 13] = 'o';
            Core[3, 14] = 'p';
            Core[3, 15] = 'q';
            Core[3, 16] = 'r';
            Core[3, 17] = 's';
            Core[3, 18] = 't';
            Core[3, 19] = 'u';
            Core[3, 20] = 'v';
            Core[3, 21] = 'w';
            Core[3, 22] = 'x';
            Core[3, 23] = 'y';
            Core[3, 24] = 'z';
            Core[3, 25] = 'a';
            Core[3, 26] = 'b';
            //floor4
            Core[4, 1] = 'd';
            Core[4, 2] = 'e';
            Core[4, 3] = 'f';
            Core[4, 4] = 'g';
            Core[4, 5] = 'h';
            Core[4, 6] = 'i';
            Core[4, 7] = 'j';
            Core[4, 8] = 'k';
            Core[4, 9] = 'l';
            Core[4, 10] = 'm';
            Core[4, 11] = 'n';
            Core[4, 12] = 'o';
            Core[4, 13] = 'p';
            Core[4, 14] = 'q';
            Core[4, 15] = 'r';
            Core[4, 16] = 's';
            Core[4, 17] = 't';
            Core[4, 18] = 'u';
            Core[4, 19] = 'v';
            Core[4, 20] = 'w';
            Core[4, 21] = 'x';
            Core[4, 22] = 'y';
            Core[4, 23] = 'z';
            Core[4, 24] = 'a';
            Core[4, 25] = 'b';
            Core[4, 26] = 'c';
            //floor5
            Core[5, 01] = 'e';
            Core[5, 02] = 'f';
            Core[5, 03] = 'g';
            Core[5, 04] = 'h';
            Core[5, 05] = 'i';
            Core[5, 06] = 'j';
            Core[5, 07] = 'k';
            Core[5, 08] = 'l';
            Core[5, 09] = 'm';
            Core[5, 10] = 'n';
            Core[5, 11] = 'o';
            Core[5, 12] = 'p';
            Core[5, 13] = 'q';
            Core[5, 14] = 'r';
            Core[5, 15] = 's';
            Core[5, 16] = 't';
            Core[5, 17] = 'u';
            Core[5, 18] = 'v';
            Core[5, 19] = 'w';
            Core[5, 20] = 'x';
            Core[5, 21] = 'y';
            Core[5, 22] = 'z';
            Core[5, 23] = 'a';
            Core[5, 24] = 'b';
            Core[5, 25] = 'c';
            Core[5, 26] = 'd';
            //floor6
            Core[6, 01] = 'f';
            Core[6, 02] = 'g';
            Core[6, 03] = 'h';
            Core[6, 04] = 'i';
            Core[6, 05] = 'j';
            Core[6, 06] = 'k';
            Core[6, 07] = 'l';
            Core[6, 08] = 'm';
            Core[6, 09] = 'n';
            Core[6, 10] = 'o';
            Core[6, 11] = 'p';
            Core[6, 12] = 'q';
            Core[6, 13] = 'r';
            Core[6, 14] = 's';
            Core[6, 15] = 't';
            Core[6, 16] = 'u';
            Core[6, 17] = 'v';
            Core[6, 18] = 'w';
            Core[6, 19] = 'x';
            Core[6, 20] = 'y';
            Core[6, 21] = 'z';
            Core[6, 22] = 'a';
            Core[6, 23] = 'b';
            Core[6, 24] = 'c';
            Core[6, 25] = 'd';
            Core[6, 26] = 'e';
            //floor7
            Core[7, 01] = 'g';
            Core[7, 02] = 'h';
            Core[7, 03] = 'i';
            Core[7, 04] = 'j';
            Core[7, 05] = 'k';
            Core[7, 06] = 'l';
            Core[7, 07] = 'm';
            Core[7, 08] = 'n';
            Core[7, 09] = 'o';
            Core[7, 10] = 'p';
            Core[7, 11] = 'q';
            Core[7, 12] = 'r';
            Core[7, 13] = 's';
            Core[7, 14] = 't';
            Core[7, 15] = 'u';
            Core[7, 16] = 'v';
            Core[7, 17] = 'w';
            Core[7, 18] = 'x';
            Core[7, 19] = 'y';
            Core[7, 20] = 'z';
            Core[7, 21] = 'a';
            Core[7, 22] = 'b';
            Core[7, 23] = 'c';
            Core[7, 24] = 'd';
            Core[7, 25] = 'e';
            Core[7, 26] = 'f';
            //floor8
            Core[8, 01] = 'h';
            Core[8, 02] = 'i';
            Core[8, 03] = 'j';
            Core[8, 04] = 'k';
            Core[8, 05] = 'l';
            Core[8, 06] = 'm';
            Core[8, 07] = 'n';
            Core[8, 08] = 'o';
            Core[8, 09] = 'p';
            Core[8, 10] = 'q';
            Core[8, 11] = 'r';
            Core[8, 12] = 's';
            Core[8, 13] = 't';
            Core[8, 14] = 'u';
            Core[8, 15] = 'v';
            Core[8, 16] = 'w';
            Core[8, 17] = 'x';
            Core[8, 18] = 'y';
            Core[8, 19] = 'z';
            Core[8, 20] = 'a';
            Core[8, 21] = 'b';
            Core[8, 22] = 'c';
            Core[8, 23] = 'd';
            Core[8, 24] = 'e';
            Core[8, 25] = 'f';
            Core[8, 26] = 'g';
            //floor9
            Core[9, 01] = 'i';
            Core[9, 02] = 'j';
            Core[9, 03] = 'k';
            Core[9, 04] = 'l';
            Core[9, 05] = 'm';
            Core[9, 06] = 'n';
            Core[9, 07] = 'o';
            Core[9, 08] = 'p';
            Core[9, 09] = 'q';
            Core[9, 10] = 'r';
            Core[9, 11] = 's';
            Core[9, 12] = 't';
            Core[9, 13] = 'u';
            Core[9, 14] = 'v';
            Core[9, 15] = 'w';
            Core[9, 16] = 'x';
            Core[9, 17] = 'y';
            Core[9, 18] = 'z';
            Core[9, 19] = 'a';
            Core[9, 20] = 'b';
            Core[9, 21] = 'c';
            Core[9, 22] = 'd';
            Core[9, 23] = 'e';
            Core[9, 24] = 'f';
            Core[9, 25] = 'g';
            Core[9, 26] = 'h';
            //floor10
            Core[10, 01] = 'j';
            Core[10, 02] = 'k';
            Core[10, 03] = 'l';
            Core[10, 04] = 'm';
            Core[10, 05] = 'n';
            Core[10, 06] = 'o';
            Core[10, 07] = 'p';
            Core[10, 08] = 'q';
            Core[10, 09] = 'r';
            Core[10, 10] = 's';
            Core[10, 11] = 't';
            Core[10, 12] = 'u';
            Core[10, 13] = 'v';
            Core[10, 14] = 'w';
            Core[10, 15] = 'x';
            Core[10, 16] = 'y';
            Core[10, 17] = 'z';
            Core[10, 18] = 'a';
            Core[10, 19] = 'b';
            Core[10, 20] = 'c';
            Core[10, 21] = 'd';
            Core[10, 22] = 'e';
            Core[10, 23] = 'f';
            Core[10, 24] = 'g';
            Core[10, 25] = 'h';
            Core[10, 26] = 'i';
            //floor11
            Core[11, 01] = 'k';
            Core[11, 02] = 'l';
            Core[11, 03] = 'm';
            Core[11, 04] = 'n';
            Core[11, 05] = 'o';
            Core[11, 06] = 'p';
            Core[11, 07] = 'q';
            Core[11, 08] = 'r';
            Core[11, 09] = 's';
            Core[11, 10] = 't';
            Core[11, 11] = 'u';
            Core[11, 12] = 'v';
            Core[11, 13] = 'w';
            Core[11, 14] = 'x';
            Core[11, 15] = 'y';
            Core[11, 16] = 'z';
            Core[11, 17] = 'a';
            Core[11, 18] = 'b';
            Core[11, 19] = 'c';
            Core[11, 20] = 'd';
            Core[11, 21] = 'e';
            Core[11, 22] = 'f';
            Core[11, 23] = 'g';
            Core[11, 24] = 'h';
            Core[11, 25] = 'i';
            Core[11, 26] = 'j';
            //floor12
            Core[12, 01] = 'l';
            Core[12, 02] = 'm';
            Core[12, 03] = 'n';
            Core[12, 04] = 'o';
            Core[12, 05] = 'p';
            Core[12, 06] = 'q';
            Core[12, 07] = 'r';
            Core[12, 08] = 's';
            Core[12, 09] = 't';
            Core[12, 10] = 'u';
            Core[12, 11] = 'v';
            Core[12, 12] = 'w';
            Core[12, 13] = 'x';
            Core[12, 14] = 'y';
            Core[12, 15] = 'z';
            Core[12, 16] = 'a';
            Core[12, 17] = 'b';
            Core[12, 18] = 'c';
            Core[12, 19] = 'd';
            Core[12, 20] = 'e';
            Core[12, 21] = 'f';
            Core[12, 22] = 'g';
            Core[12, 23] = 'h';
            Core[12, 24] = 'i';
            Core[12, 25] = 'j';
            Core[12, 26] = 'k';
            //floor13
            Core[13, 01] = 'm';
            Core[13, 02] = 'n';
            Core[13, 03] = 'o';
            Core[13, 04] = 'p';
            Core[13, 05] = 'q';
            Core[13, 06] = 'r';
            Core[13, 07] = 's';
            Core[13, 08] = 't';
            Core[13, 09] = 'u';
            Core[13, 10] = 'v';
            Core[13, 11] = 'w';
            Core[13, 12] = 'x';
            Core[13, 13] = 'y';
            Core[13, 14] = 'z';
            Core[13, 15] = 'a';
            Core[13, 16] = 'b';
            Core[13, 17] = 'c';
            Core[13, 18] = 'd';
            Core[13, 19] = 'e';
            Core[13, 20] = 'f';
            Core[13, 21] = 'g';
            Core[13, 22] = 'h';
            Core[13, 23] = 'i';
            Core[13, 24] = 'j';
            Core[13, 25] = 'k';
            Core[13, 26] = 'l';
            //floor14
            Core[14, 01] = 'n';
            Core[14, 02] = 'o';
            Core[14, 03] = 'p';
            Core[14, 04] = 'q';
            Core[14, 05] = 'r';
            Core[14, 06] = 's';
            Core[14, 07] = 't';
            Core[14, 08] = 'u';
            Core[14, 09] = 'v';
            Core[14, 10] = 'w';
            Core[14, 11] = 'x';
            Core[14, 12] = 'y';
            Core[14, 13] = 'z';
            Core[14, 14] = 'a';
            Core[14, 15] = 'b';
            Core[14, 16] = 'c';
            Core[14, 17] = 'd';
            Core[14, 18] = 'e';
            Core[14, 19] = 'f';
            Core[14, 20] = 'g';
            Core[14, 21] = 'h';
            Core[14, 22] = 'i';
            Core[14, 23] = 'j';
            Core[14, 24] = 'k';
            Core[14, 25] = 'l';
            Core[14, 26] = 'm';
            //floor15
            Core[15, 01] = 'o';
            Core[15, 02] = 'p';
            Core[15, 03] = 'q';
            Core[15, 04] = 'r';
            Core[15, 05] = 's';
            Core[15, 06] = 't';
            Core[15, 07] = 'u';
            Core[15, 08] = 'v';
            Core[15, 09] = 'w';
            Core[15, 10] = 'x';
            Core[15, 11] = 'y';
            Core[15, 12] = 'z';
            Core[15, 13] = 'a';
            Core[15, 14] = 'b';
            Core[15, 15] = 'c';
            Core[15, 16] = 'd';
            Core[15, 17] = 'e';
            Core[15, 18] = 'f';
            Core[15, 19] = 'g';
            Core[15, 20] = 'h';
            Core[15, 21] = 'i';
            Core[15, 22] = 'j';
            Core[15, 23] = 'k';
            Core[15, 24] = 'l';
            Core[15, 25] = 'm';
            Core[15, 26] = 'n';
            //floor16
            Core[16, 01] = 'p';
            Core[16, 02] = 'q';
            Core[16, 03] = 'r';
            Core[16, 04] = 's';
            Core[16, 05] = 't';
            Core[16, 06] = 'u';
            Core[16, 07] = 'v';
            Core[16, 08] = 'w';
            Core[16, 09] = 'x';
            Core[16, 10] = 'y';
            Core[16, 11] = 'z';
            Core[16, 12] = 'a';
            Core[16, 13] = 'b';
            Core[16, 14] = 'c';
            Core[16, 15] = 'd';
            Core[16, 16] = 'e';
            Core[16, 17] = 'f';
            Core[16, 18] = 'g';
            Core[16, 19] = 'h';
            Core[16, 20] = 'i';
            Core[16, 21] = 'j';
            Core[16, 22] = 'k';
            Core[16, 23] = 'l';
            Core[16, 24] = 'm';
            Core[16, 25] = 'n';
            Core[16, 26] = 'o';
            //floor17
            Core[17, 01] = 'q';
            Core[17, 02] = 'r';
            Core[17, 03] = 's';
            Core[17, 04] = 't';
            Core[17, 05] = 'u';
            Core[17, 06] = 'v';
            Core[17, 07] = 'w';
            Core[17, 08] = 'x';
            Core[17, 09] = 'y';
            Core[17, 10] = 'z';
            Core[17, 11] = 'a';
            Core[17, 12] = 'b';
            Core[17, 13] = 'c';
            Core[17, 14] = 'd';
            Core[17, 15] = 'e';
            Core[17, 16] = 'f';
            Core[17, 17] = 'g';
            Core[17, 18] = 'h';
            Core[17, 19] = 'i';
            Core[17, 20] = 'j';
            Core[17, 21] = 'k';
            Core[17, 22] = 'l';
            Core[17, 23] = 'm';
            Core[17, 24] = 'n';
            Core[17, 25] = 'o';
            Core[17, 26] = 'p';
            //floor18
            Core[18, 01] = 'r';
            Core[18, 02] = 's';
            Core[18, 03] = 't';
            Core[18, 04] = 'u';
            Core[18, 05] = 'v';
            Core[18, 06] = 'w';
            Core[18, 07] = 'x';
            Core[18, 08] = 'y';
            Core[18, 09] = 'z';
            Core[18, 10] = 'a';
            Core[18, 11] = 'b';
            Core[18, 12] = 'c';
            Core[18, 13] = 'd';
            Core[18, 14] = 'e';
            Core[18, 15] = 'f';
            Core[18, 16] = 'g';
            Core[18, 17] = 'h';
            Core[18, 18] = 'i';
            Core[18, 19] = 'j';
            Core[18, 20] = 'k';
            Core[18, 21] = 'l';
            Core[18, 22] = 'm';
            Core[18, 23] = 'n';
            Core[18, 24] = 'o';
            Core[18, 25] = 'p';
            Core[18, 26] = 'q';
            //floor19
            Core[19, 01] = 's';
            Core[19, 02] = 't';
            Core[19, 03] = 'u';
            Core[19, 04] = 'v';
            Core[19, 05] = 'w';
            Core[19, 06] = 'x';
            Core[19, 07] = 'y';
            Core[19, 08] = 'z';
            Core[19, 09] = 'a';
            Core[19, 10] = 'b';
            Core[19, 11] = 'c';
            Core[19, 12] = 'd';
            Core[19, 13] = 'e';
            Core[19, 14] = 'f';
            Core[19, 15] = 'g';
            Core[19, 16] = 'h';
            Core[19, 17] = 'i';
            Core[19, 18] = 'j';
            Core[19, 19] = 'k';
            Core[19, 20] = 'l';
            Core[19, 21] = 'm';
            Core[19, 22] = 'n';
            Core[19, 23] = 'o';
            Core[19, 24] = 'p';
            Core[19, 25] = 'q';
            Core[19, 26] = 'r';
            //floor20
            Core[20, 01] = 't';
            Core[20, 02] = 'u';
            Core[20, 03] = 'v';
            Core[20, 04] = 'w';
            Core[20, 05] = 'x';
            Core[20, 06] = 'y';
            Core[20, 07] = 'z';
            Core[20, 08] = 'a';
            Core[20, 09] = 'b';
            Core[20, 10] = 'c';
            Core[20, 11] = 'd';
            Core[20, 12] = 'e';
            Core[20, 13] = 'f';
            Core[20, 14] = 'g';
            Core[20, 15] = 'h';
            Core[20, 16] = 'i';
            Core[20, 17] = 'j';
            Core[20, 18] = 'k';
            Core[20, 19] = 'l';
            Core[20, 20] = 'm';
            Core[20, 21] = 'n';
            Core[20, 22] = 'o';
            Core[20, 23] = 'p';
            Core[20, 24] = 'q';
            Core[20, 25] = 'r';
            Core[20, 26] = 's';
            //floor21
            Core[21, 01] = 'u';
            Core[21, 02] = 'v';
            Core[21, 03] = 'w';
            Core[21, 04] = 'x';
            Core[21, 05] = 'y';
            Core[21, 06] = 'z';
            Core[21, 07] = 'a';
            Core[21, 08] = 'b';
            Core[21, 09] = 'c';
            Core[21, 10] = 'd';
            Core[21, 11] = 'e';
            Core[21, 12] = 'f';
            Core[21, 13] = 'g';
            Core[21, 14] = 'h';
            Core[21, 15] = 'i';
            Core[21, 16] = 'j';
            Core[21, 17] = 'k';
            Core[21, 18] = 'l';
            Core[21, 19] = 'm';
            Core[21, 20] = 'n';
            Core[21, 21] = 'o';
            Core[21, 22] = 'p';
            Core[21, 23] = 'q';
            Core[21, 24] = 'r';
            Core[21, 25] = 's';
            Core[21, 26] = 't';
            //floor22
            Core[22, 01] = 'v';
            Core[22, 02] = 'w';
            Core[22, 03] = 'x';
            Core[22, 04] = 'y';
            Core[22, 05] = 'z';
            Core[22, 06] = 'a';
            Core[22, 07] = 'b';
            Core[22, 08] = 'c';
            Core[22, 09] = 'd';
            Core[22, 10] = 'e';
            Core[22, 11] = 'f';
            Core[22, 12] = 'g';
            Core[22, 13] = 'h';
            Core[22, 14] = 'i';
            Core[22, 15] = 'j';
            Core[22, 16] = 'k';
            Core[22, 17] = 'l';
            Core[22, 18] = 'm';
            Core[22, 19] = 'n';
            Core[22, 20] = 'o';
            Core[22, 21] = 'p';
            Core[22, 22] = 'q';
            Core[22, 23] = 'r';
            Core[22, 24] = 's';
            Core[22, 25] = 't';
            Core[22, 26] = 'u';
            //floor23
            Core[23, 01] = 'w';
            Core[23, 02] = 'x';
            Core[23, 03] = 'y';
            Core[23, 04] = 'z';
            Core[23, 05] = 'a';
            Core[23, 06] = 'b';
            Core[23, 07] = 'c';
            Core[23, 08] = 'd';
            Core[23, 09] = 'e';
            Core[23, 10] = 'f';
            Core[23, 11] = 'g';
            Core[23, 12] = 'h';
            Core[23, 13] = 'i';
            Core[23, 14] = 'j';
            Core[23, 15] = 'k';
            Core[23, 16] = 'l';
            Core[23, 17] = 'm';
            Core[23, 18] = 'n';
            Core[23, 19] = 'o';
            Core[23, 20] = 'p';
            Core[23, 21] = 'q';
            Core[23, 22] = 'r';
            Core[23, 23] = 's';
            Core[23, 24] = 't';
            Core[23, 25] = 'u';
            Core[23, 26] = 'v';
            //floor24
            Core[24, 01] = 'x';
            Core[24, 02] = 'y';
            Core[24, 03] = 'z';
            Core[24, 04] = 'a';
            Core[24, 05] = 'b';
            Core[24, 06] = 'c';
            Core[24, 07] = 'd';
            Core[24, 08] = 'e';
            Core[24, 09] = 'f';
            Core[24, 10] = 'g';
            Core[24, 11] = 'h';
            Core[24, 12] = 'i';
            Core[24, 13] = 'j';
            Core[24, 14] = 'k';
            Core[24, 15] = 'l';
            Core[24, 16] = 'm';
            Core[24, 17] = 'n';
            Core[24, 18] = 'o';
            Core[24, 19] = 'p';
            Core[24, 20] = 'q';
            Core[24, 21] = 'r';
            Core[24, 22] = 's';
            Core[24, 23] = 't';
            Core[24, 24] = 'u';
            Core[24, 25] = 'v';
            Core[24, 26] = 'w';
            //floor25
            Core[25, 01] = 'y';
            Core[25, 02] = 'z';
            Core[25, 03] = 'a';
            Core[25, 04] = 'b';
            Core[25, 05] = 'c';
            Core[25, 06] = 'd';
            Core[25, 07] = 'e';
            Core[25, 08] = 'f';
            Core[25, 09] = 'g';
            Core[25, 10] = 'h';
            Core[25, 11] = 'i';
            Core[25, 12] = 'j';
            Core[25, 13] = 'k';
            Core[25, 14] = 'l';
            Core[25, 15] = 'm';
            Core[25, 16] = 'n';
            Core[25, 17] = 'o';
            Core[25, 18] = 'p';
            Core[25, 19] = 'q';
            Core[25, 20] = 'r';
            Core[25, 21] = 's';
            Core[25, 22] = 't';
            Core[25, 23] = 'u';
            Core[25, 24] = 'v';
            Core[25, 25] = 'w';
            Core[25, 26] = 'x';
            //floor26
            Core[26, 01] = 'z';
            Core[26, 02] = 'a';
            Core[26, 03] = 'b';
            Core[26, 04] = 'c';
            Core[26, 05] = 'd';
            Core[26, 06] = 'e';
            Core[26, 07] = 'f';
            Core[26, 08] = 'g';
            Core[26, 09] = 'h';
            Core[26, 10] = 'i';
            Core[26, 11] = 'j';
            Core[26, 12] = 'k';
            Core[26, 13] = 'l';
            Core[26, 14] = 'm';
            Core[26, 15] = 'n';
            Core[26, 16] = 'o';
            Core[26, 17] = 'p';
            Core[26, 18] = 'q';
            Core[26, 19] = 'r';
            Core[26, 20] = 's';
            Core[26, 21] = 't';
            Core[26, 22] = 'u';
            Core[26, 23] = 'v';
            Core[26, 24] = 'w';
            Core[26, 25] = 'x';
            Core[26, 26] = 'y';


            #endregion
        }
        private static int ConvertCharToInt(char a)
        {
            var ret = 0;
            switch (a)
            {
                case 'a': ret = 1; break;
                case 'b': ret = 2; break;
                case 'c': ret = 3; break;
                case 'd': ret = 4; break;
                case 'e': ret = 5; break;
                case 'f': ret = 6; break;
                case 'g': ret = 7; break;
                case 'h': ret = 8; break;
                case 'i': ret = 9; break;
                case 'j': ret = 10; break;
                case 'k': ret = 11; break;
                case 'l': ret = 12; break;
                case 'm': ret = 13; break;
                case 'n': ret = 14; break;
                case 'o': ret = 15; break;
                case 'p': ret = 16; break;
                case 'q': ret = 17; break;
                case 'r': ret = 18; break;
                case 's': ret = 19; break;
                case 't': ret = 20; break;
                case 'u': ret = 21; break;
                case 'v': ret = 22; break;
                case 'w': ret = 23; break;
                case 'x': ret = 24; break;
                case 'y': ret = 25; break;
                case 'z': ret = 26; break;
                default: break;
            }
            return ret;
        }
        private static char ConvertIntToChar(int a)
        {
            var ret = ' ';
            switch (a)
            {
                case 1: ret = 'a'; break;
                case 2: ret = 'b'; break;
                case 3: ret = 'c'; break;
                case 4: ret = 'd'; break;
                case 5: ret = 'e'; break;
                case 6: ret = 'f'; break;
                case 7: ret = 'g'; break;
                case 8: ret = 'h'; break;
                case 9: ret = 'i'; break;
                case 10: ret = 'j'; break;
                case 11: ret = 'k'; break;
                case 12: ret = 'l'; break;
                case 13: ret = 'm'; break;
                case 14: ret = 'n'; break;
                case 15: ret = 'o'; break;
                case 16: ret = 'p'; break;
                case 17: ret = 'q'; break;
                case 18: ret = 'r'; break;
                case 19: ret = 's'; break;
                case 20: ret = 't'; break;
                case 21: ret = 'u'; break;
                case 22: ret = 'v'; break;
                case 23: ret = 'w'; break;
                case 24: ret = 'x'; break;
                case 25: ret = 'y'; break;
                case 26:
                    ret = 'z'; break;
                default: break;
            }
            return ret;
        }
        private static char GetCoder2(char a)
        {
            if (a == ' ')
            {
                ForReturn += "$$";
                return a;
            }
            var i = 0;
            var rand = Random.Next(0, 27);
            var tools = ConvertCharToInt(a);
            for (i = 1; i <= 26; i++)
            {
                if (Core[rand, i] != a) continue;
                while (true)
                {
                    var gij = Random.Next(0, 4);
                    if (gij == 1)
                    {
                        ForReturn += ConvertIntToChar(rand).ToString();
                        while (true)
                        {
                            gij = Random.Next(0, 7);
                            if (gij == 1)
                            {
                                break;
                            }
                            else if (gij == 2)
                            {
                                ForReturn += "@";
                            }
                            else if (gij == 3)
                            {
                                ForReturn += Random.Next(0, 200);
                            }
                            else if (gij == 4)
                            {
                                ForReturn += "#";
                            }
                            else
                            {
                                ForReturn += (char)Random.Next('A', 'Z');
                                break;
                            }
                        }
                        ForReturn += ConvertIntToChar(i).ToString();
                        break;
                    }
                    else if (gij == 3)
                    {
                        ForReturn += Random.Next(0, 200);
                    }
                    else
                    {
                        ForReturn += "#";
                    }
                }

                //Console.WriteLine(ConvertIntToChar(rand).ToString() + ConvertIntToChar(i).ToString());
                //ForReturn += ConvertIntToChar(rand).ToString();
                //ForReturn += ConvertIntToChar(i).ToString();
                //ForReturn += rand.ToString();
                //ForReturn += "-";
                //ForReturn += i.ToString();
                //ForReturn += " ";

                break;
            }
            //ForReturn = ForReturn.Replace("##", "$");
            //ForReturn = ForReturn.Replace("###", "$");
            //ForReturn = ForReturn.Replace("####", "$");
            //ForReturn = ForReturn.Replace("#####", "$");
            //ForReturn = ForReturn.Replace("######", "$");
            //ForReturn = ForReturn.Replace("#######", "$");
            //ForReturn = ForReturn.Replace("########", "$");
            //ForReturn = ForReturn.Replace("#########", "$");
            return a;
        }
        private static void GetCoder(string input)
        {
            foreach (var b in input.Select(a => GetCoder2(a)))
            {
            }
        }
        private static void Decoder(string input)
        {
            ForReturn = "";

            char a, b;
            int A, B;
            for (int i = 0; i <= input.Length + 1; i += 2)
            {
                try
                {
                    a = input[i];
                    b = input[i + 1];
                    if (a == '$' && b == '$')
                    {
                        ForReturn += " ";
                        continue;
                    }
                    A = ConvertCharToInt(a);
                    B = ConvertCharToInt(b);
                    //Console.WriteLine(allThings[B, A] + a.ToString() + b.ToString() + A.ToString() + B.ToString());
                    //Console.WriteLine(allThings[B, A]);
                    ForReturn += Core[B, A];
                }
                catch (Exception)
                {

                    break;
                }

            }
        }
        private static string ClearDecoder(string input)
        {
            input = input.Replace("@", "");
            input = input.Replace("#", "");
            input = input.Replace("1", "");
            input = input.Replace("0", "");
            input = input.Replace("2", "");
            input = input.Replace("3", "");
            input = input.Replace("4", "");
            input = input.Replace("5", "");
            input = input.Replace("6", "");
            input = input.Replace("7", "");
            input = input.Replace("8", "");
            input = input.Replace("9", "");
            input = input.Replace("10", "");
            input = input.Replace("11", "");
            input = input.Replace("12", "");
            input = input.Replace("13", "");
            input = input.Replace("14", "");
            input = input.Replace("15", "");
            input = input.Replace("16", "");
            input = input.Replace("17", "");
            input = input.Replace("18", "");
            input = input.Replace("19", "");
            input = input.Replace("20", "");
            input = input.Replace("21", "");
            input = input.Replace("22", "");
            input = input.Replace("23", "");
            input = input.Replace("24", "");
            input = input.Replace("25", "");
            input = input.Replace("26", "");
            input = input.Replace("A", "");
            input = input.Replace("B", "");
            input = input.Replace("C", "");
            input = input.Replace("D", "");
            input = input.Replace("E", "");
            input = input.Replace("F", "");
            input = input.Replace("G", "");
            input = input.Replace("H", "");
            input = input.Replace("I", "");
            input = input.Replace("J", "");
            input = input.Replace("K", "");
            input = input.Replace("L", "");
            input = input.Replace("M", "");
            input = input.Replace("N", "");
            input = input.Replace("O", "");
            input = input.Replace("P", "");
            input = input.Replace("Q", "");
            input = input.Replace("R", "");
            input = input.Replace("S", "");
            input = input.Replace("T", "");
            input = input.Replace("U", "");
            input = input.Replace("V", "");
            input = input.Replace("W", "");
            input = input.Replace("X", "");
            input = input.Replace("Y", "");
            input = input.Replace("Z", "");
            return input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (PasswordTxt.Text != "sina")
            {
                MessageBox.Show("Password Is Incorrect !");
                return;
            }
            var input = InputDecodeTxt.Text;
            var clearS = ClearDecoder(input);
            Decoder(clearS);
            OutputDecoderTxt.Text = ForReturn;
        }

        private void CodeCopyBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(OutputText.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(OutputDecoderTxt.Text);
        }

        private void TestBtn_Click(object sender, EventArgs e)
        {
            if (PasswordTxt.Text != "sina")
            {
                MessageBox.Show("Password Is Incorrect !");
                return;
            }
            InputText.Text = ClearDecoder(InputText.Text.ToLower());

            while (true)
            {
                ForReturn = "";
                var input = InputText.Text;
                input = ClearDecoder(input.ToLower());
                GetCoder(input);
                OutputText.Text = ForReturn;
                InputDecodeTxt.Text = OutputText.Text;
                input = InputDecodeTxt.Text;
                var clearS = ClearDecoder(input);
                Decoder(clearS);
                OutputDecoderTxt.Text = ForReturn;
                if (InputText.Text == OutputDecoderTxt.Text)
                {
                    break;
                }
            }
        }
    }
}
