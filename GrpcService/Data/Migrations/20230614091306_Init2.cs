using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GrpcServer.Data.Migrations
{
    public partial class Init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "PublishedYear", "Title" },
                values: new object[,]
                {
                    { 2, "Test=2", 2022, "Test=2" },
                    { 3, "Test=3", 2022, "Test=3" },
                    { 4, "Test=4", 2022, "Test=4" },
                    { 5, "Test=5", 2022, "Test=5" },
                    { 6, "Test=6", 2022, "Test=6" },
                    { 7, "Test=7", 2022, "Test=7" },
                    { 8, "Test=8", 2022, "Test=8" },
                    { 9, "Test=9", 2022, "Test=9" },
                    { 10, "Test=10", 2022, "Test=10" },
                    { 11, "Test=11", 2022, "Test=11" },
                    { 12, "Test=12", 2022, "Test=12" },
                    { 13, "Test=13", 2022, "Test=13" },
                    { 14, "Test=14", 2022, "Test=14" },
                    { 15, "Test=15", 2022, "Test=15" },
                    { 16, "Test=16", 2022, "Test=16" },
                    { 17, "Test=17", 2022, "Test=17" },
                    { 18, "Test=18", 2022, "Test=18" },
                    { 19, "Test=19", 2022, "Test=19" },
                    { 20, "Test=20", 2022, "Test=20" },
                    { 21, "Test=21", 2022, "Test=21" },
                    { 22, "Test=22", 2022, "Test=22" },
                    { 23, "Test=23", 2022, "Test=23" },
                    { 24, "Test=24", 2022, "Test=24" },
                    { 25, "Test=25", 2022, "Test=25" },
                    { 26, "Test=26", 2022, "Test=26" },
                    { 27, "Test=27", 2022, "Test=27" },
                    { 28, "Test=28", 2022, "Test=28" },
                    { 29, "Test=29", 2022, "Test=29" },
                    { 30, "Test=30", 2022, "Test=30" },
                    { 31, "Test=31", 2022, "Test=31" },
                    { 32, "Test=32", 2022, "Test=32" },
                    { 33, "Test=33", 2022, "Test=33" },
                    { 34, "Test=34", 2022, "Test=34" },
                    { 35, "Test=35", 2022, "Test=35" },
                    { 36, "Test=36", 2022, "Test=36" },
                    { 37, "Test=37", 2022, "Test=37" },
                    { 38, "Test=38", 2022, "Test=38" },
                    { 39, "Test=39", 2022, "Test=39" },
                    { 40, "Test=40", 2022, "Test=40" },
                    { 41, "Test=41", 2022, "Test=41" },
                    { 42, "Test=42", 2022, "Test=42" },
                    { 43, "Test=43", 2022, "Test=43" },
                    { 44, "Test=44", 2022, "Test=44" },
                    { 45, "Test=45", 2022, "Test=45" },
                    { 46, "Test=46", 2022, "Test=46" },
                    { 47, "Test=47", 2022, "Test=47" },
                    { 48, "Test=48", 2022, "Test=48" },
                    { 49, "Test=49", 2022, "Test=49" },
                    { 50, "Test=50", 2022, "Test=50" },
                    { 51, "Test=51", 2022, "Test=51" },
                    { 52, "Test=52", 2022, "Test=52" },
                    { 53, "Test=53", 2022, "Test=53" },
                    { 54, "Test=54", 2022, "Test=54" },
                    { 55, "Test=55", 2022, "Test=55" },
                    { 56, "Test=56", 2022, "Test=56" },
                    { 57, "Test=57", 2022, "Test=57" },
                    { 58, "Test=58", 2022, "Test=58" },
                    { 59, "Test=59", 2022, "Test=59" },
                    { 60, "Test=60", 2022, "Test=60" },
                    { 61, "Test=61", 2022, "Test=61" },
                    { 62, "Test=62", 2022, "Test=62" },
                    { 63, "Test=63", 2022, "Test=63" },
                    { 64, "Test=64", 2022, "Test=64" },
                    { 65, "Test=65", 2022, "Test=65" },
                    { 66, "Test=66", 2022, "Test=66" },
                    { 67, "Test=67", 2022, "Test=67" },
                    { 68, "Test=68", 2022, "Test=68" },
                    { 69, "Test=69", 2022, "Test=69" },
                    { 70, "Test=70", 2022, "Test=70" },
                    { 71, "Test=71", 2022, "Test=71" },
                    { 72, "Test=72", 2022, "Test=72" },
                    { 73, "Test=73", 2022, "Test=73" },
                    { 74, "Test=74", 2022, "Test=74" },
                    { 75, "Test=75", 2022, "Test=75" },
                    { 76, "Test=76", 2022, "Test=76" },
                    { 77, "Test=77", 2022, "Test=77" },
                    { 78, "Test=78", 2022, "Test=78" },
                    { 79, "Test=79", 2022, "Test=79" },
                    { 80, "Test=80", 2022, "Test=80" },
                    { 81, "Test=81", 2022, "Test=81" },
                    { 82, "Test=82", 2022, "Test=82" },
                    { 83, "Test=83", 2022, "Test=83" },
                    { 84, "Test=84", 2022, "Test=84" },
                    { 85, "Test=85", 2022, "Test=85" },
                    { 86, "Test=86", 2022, "Test=86" },
                    { 87, "Test=87", 2022, "Test=87" },
                    { 88, "Test=88", 2022, "Test=88" },
                    { 89, "Test=89", 2022, "Test=89" },
                    { 90, "Test=90", 2022, "Test=90" },
                    { 91, "Test=91", 2022, "Test=91" },
                    { 92, "Test=92", 2022, "Test=92" },
                    { 93, "Test=93", 2022, "Test=93" },
                    { 94, "Test=94", 2022, "Test=94" },
                    { 95, "Test=95", 2022, "Test=95" },
                    { 96, "Test=96", 2022, "Test=96" },
                    { 97, "Test=97", 2022, "Test=97" },
                    { 98, "Test=98", 2022, "Test=98" },
                    { 99, "Test=99", 2022, "Test=99" },
                    { 100, "Test=100", 2022, "Test=100" },
                    { 101, "Test=101", 2022, "Test=101" },
                    { 102, "Test=102", 2022, "Test=102" },
                    { 103, "Test=103", 2022, "Test=103" },
                    { 104, "Test=104", 2022, "Test=104" },
                    { 105, "Test=105", 2022, "Test=105" },
                    { 106, "Test=106", 2022, "Test=106" },
                    { 107, "Test=107", 2022, "Test=107" },
                    { 108, "Test=108", 2022, "Test=108" },
                    { 109, "Test=109", 2022, "Test=109" },
                    { 110, "Test=110", 2022, "Test=110" },
                    { 111, "Test=111", 2022, "Test=111" },
                    { 112, "Test=112", 2022, "Test=112" },
                    { 113, "Test=113", 2022, "Test=113" },
                    { 114, "Test=114", 2022, "Test=114" },
                    { 115, "Test=115", 2022, "Test=115" },
                    { 116, "Test=116", 2022, "Test=116" },
                    { 117, "Test=117", 2022, "Test=117" },
                    { 118, "Test=118", 2022, "Test=118" },
                    { 119, "Test=119", 2022, "Test=119" },
                    { 120, "Test=120", 2022, "Test=120" },
                    { 121, "Test=121", 2022, "Test=121" },
                    { 122, "Test=122", 2022, "Test=122" },
                    { 123, "Test=123", 2022, "Test=123" },
                    { 124, "Test=124", 2022, "Test=124" },
                    { 125, "Test=125", 2022, "Test=125" },
                    { 126, "Test=126", 2022, "Test=126" },
                    { 127, "Test=127", 2022, "Test=127" },
                    { 128, "Test=128", 2022, "Test=128" },
                    { 129, "Test=129", 2022, "Test=129" },
                    { 130, "Test=130", 2022, "Test=130" },
                    { 131, "Test=131", 2022, "Test=131" },
                    { 132, "Test=132", 2022, "Test=132" },
                    { 133, "Test=133", 2022, "Test=133" },
                    { 134, "Test=134", 2022, "Test=134" },
                    { 135, "Test=135", 2022, "Test=135" },
                    { 136, "Test=136", 2022, "Test=136" },
                    { 137, "Test=137", 2022, "Test=137" },
                    { 138, "Test=138", 2022, "Test=138" },
                    { 139, "Test=139", 2022, "Test=139" },
                    { 140, "Test=140", 2022, "Test=140" },
                    { 141, "Test=141", 2022, "Test=141" },
                    { 142, "Test=142", 2022, "Test=142" },
                    { 143, "Test=143", 2022, "Test=143" },
                    { 144, "Test=144", 2022, "Test=144" },
                    { 145, "Test=145", 2022, "Test=145" },
                    { 146, "Test=146", 2022, "Test=146" },
                    { 147, "Test=147", 2022, "Test=147" },
                    { 148, "Test=148", 2022, "Test=148" },
                    { 149, "Test=149", 2022, "Test=149" },
                    { 150, "Test=150", 2022, "Test=150" },
                    { 151, "Test=151", 2022, "Test=151" },
                    { 152, "Test=152", 2022, "Test=152" },
                    { 153, "Test=153", 2022, "Test=153" },
                    { 154, "Test=154", 2022, "Test=154" },
                    { 155, "Test=155", 2022, "Test=155" },
                    { 156, "Test=156", 2022, "Test=156" },
                    { 157, "Test=157", 2022, "Test=157" },
                    { 158, "Test=158", 2022, "Test=158" },
                    { 159, "Test=159", 2022, "Test=159" },
                    { 160, "Test=160", 2022, "Test=160" },
                    { 161, "Test=161", 2022, "Test=161" },
                    { 162, "Test=162", 2022, "Test=162" },
                    { 163, "Test=163", 2022, "Test=163" },
                    { 164, "Test=164", 2022, "Test=164" },
                    { 165, "Test=165", 2022, "Test=165" },
                    { 166, "Test=166", 2022, "Test=166" },
                    { 167, "Test=167", 2022, "Test=167" },
                    { 168, "Test=168", 2022, "Test=168" },
                    { 169, "Test=169", 2022, "Test=169" },
                    { 170, "Test=170", 2022, "Test=170" },
                    { 171, "Test=171", 2022, "Test=171" },
                    { 172, "Test=172", 2022, "Test=172" },
                    { 173, "Test=173", 2022, "Test=173" },
                    { 174, "Test=174", 2022, "Test=174" },
                    { 175, "Test=175", 2022, "Test=175" },
                    { 176, "Test=176", 2022, "Test=176" },
                    { 177, "Test=177", 2022, "Test=177" },
                    { 178, "Test=178", 2022, "Test=178" },
                    { 179, "Test=179", 2022, "Test=179" },
                    { 180, "Test=180", 2022, "Test=180" },
                    { 181, "Test=181", 2022, "Test=181" },
                    { 182, "Test=182", 2022, "Test=182" },
                    { 183, "Test=183", 2022, "Test=183" },
                    { 184, "Test=184", 2022, "Test=184" },
                    { 185, "Test=185", 2022, "Test=185" },
                    { 186, "Test=186", 2022, "Test=186" },
                    { 187, "Test=187", 2022, "Test=187" },
                    { 188, "Test=188", 2022, "Test=188" },
                    { 189, "Test=189", 2022, "Test=189" },
                    { 190, "Test=190", 2022, "Test=190" },
                    { 191, "Test=191", 2022, "Test=191" },
                    { 192, "Test=192", 2022, "Test=192" },
                    { 193, "Test=193", 2022, "Test=193" },
                    { 194, "Test=194", 2022, "Test=194" },
                    { 195, "Test=195", 2022, "Test=195" },
                    { 196, "Test=196", 2022, "Test=196" },
                    { 197, "Test=197", 2022, "Test=197" },
                    { 198, "Test=198", 2022, "Test=198" },
                    { 199, "Test=199", 2022, "Test=199" },
                    { 200, "Test=200", 2022, "Test=200" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 200);
        }
    }
}
