using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BankSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDataToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "id_client", "address", "birth_date", "bonus", "email", "name", "order_amount", "order_number", "passport_details", "phone_number", "surname" },
                values: new object[,]
                {
                    { new Guid("00a5032f-f7c6-d121-5db7-bd4701cac45a"), "Germany", new DateTime(2009, 10, 23, 6, 7, 52, 515, DateTimeKind.Utc).AddTicks(9562), 790.36779703027000m, "Bernardo_Crist0@hotmail.com", "Clemens", 600m, 997, "Architecto est.", "(445) 349-4999", "Toy" },
                    { new Guid("0111978d-13c6-6bee-a881-78b170a3b5b9"), "Guernsey", new DateTime(1956, 6, 11, 5, 24, 29, 157, DateTimeKind.Utc).AddTicks(7378), 79.4832002258531000m, "Minerva.McGlynn94@yahoo.com", "Helen", 500m, 411, "Optio aut.", "1-846-617-2012 x8230", "Lynch" },
                    { new Guid("0147b5b0-4542-2bfa-86fd-342f4d6b8921"), "Guam", new DateTime(1933, 6, 8, 4, 55, 27, 108, DateTimeKind.Utc).AddTicks(6883), 88.5426742897456000m, "Deshawn_Buckridge34@gmail.com", "Brielle", 700m, 439, "Rerum voluptatem.", "860.606.1932 x69407", "Ferry" },
                    { new Guid("01e13fc1-0b9f-432a-7da5-34d6d8a80044"), "Liechtenstein", new DateTime(2015, 10, 10, 23, 48, 30, 316, DateTimeKind.Utc).AddTicks(6506), 202.116167103118000m, "Aracely97@hotmail.com", "Clark", 500m, 542, "Id nulla.", "813-726-9679 x6730", "Wyman" },
                    { new Guid("02160680-b6fa-c22a-9824-9836105b6ec8"), "Wallis and Futuna", new DateTime(1959, 7, 3, 4, 31, 26, 720, DateTimeKind.Utc).AddTicks(1762), 175.372530500451000m, "Roosevelt_Walter22@gmail.com", "Amara", 500m, 129, "Recusandae sed.", "1-659-441-6807 x9277", "Mosciski" },
                    { new Guid("021d3645-1ba8-77bd-691c-3a8480f00028"), "Marshall Islands", new DateTime(2011, 7, 9, 23, 18, 34, 973, DateTimeKind.Utc).AddTicks(5141), 498.82202575428000m, "Precious_Kuhlman32@gmail.com", "Elisabeth", 600m, 28, "In ea.", "1-822-449-8541 x3992", "Sanford" },
                    { new Guid("024eb533-5585-2662-b917-7ff5d4196a3d"), "Malaysia", new DateTime(1980, 4, 28, 2, 35, 17, 89, DateTimeKind.Utc).AddTicks(6743), 811.059543192248000m, "Frank_McDermott@hotmail.com", "Jocelyn", 500m, 927, "Officia sapiente.", "475.665.0169 x489", "Marquardt" },
                    { new Guid("025be73d-ffce-884d-e381-302cf3077cff"), "Kazakhstan", new DateTime(1956, 5, 23, 6, 1, 9, 875, DateTimeKind.Utc).AddTicks(9598), 104.775212189201000m, "Roma_Jones15@yahoo.com", "Dolores", 500m, 39, "Rem culpa.", "806.852.3254", "Hudson" },
                    { new Guid("02c21a56-e7ed-b73a-871a-3d6715946210"), "Benin", new DateTime(1951, 12, 14, 19, 15, 32, 887, DateTimeKind.Utc).AddTicks(8299), 314.040963625579000m, "Terrance.Abbott@hotmail.com", "Kendall", 900m, 273, "Dolorem velit.", "716-270-3940", "Lang" },
                    { new Guid("02ea14d3-5d16-266f-f39f-ea226ac3c07f"), "Guernsey", new DateTime(1936, 9, 29, 0, 40, 59, 534, DateTimeKind.Utc).AddTicks(8994), 428.991808491455000m, "Brisa.Yundt8@gmail.com", "Nikki", 1000m, 482, "Quam maiores.", "451.581.6189 x1295", "Schiller" },
                    { new Guid("033384aa-74a6-66da-bf35-45e127468e52"), "Cook Islands", new DateTime(1959, 5, 6, 3, 40, 37, 210, DateTimeKind.Utc).AddTicks(1656), 436.586573457728000m, "Bette_Harris86@yahoo.com", "Anya", 700m, 583, "Non voluptatem.", "647-284-7025 x87991", "Weimann" },
                    { new Guid("03ece077-f465-6858-df5f-8fa69bf3737a"), "Brazil", new DateTime(1952, 12, 6, 8, 58, 10, 215, DateTimeKind.Utc).AddTicks(1110), 12.9455739387718000m, "Curtis.Will@hotmail.com", "Reuben", 500m, 719, "Laborum quam.", "1-257-517-8096", "Murazik" },
                    { new Guid("041143c7-b296-f8a1-8df0-e4c6f871754c"), "Republic of Korea", new DateTime(1941, 4, 15, 22, 34, 12, 666, DateTimeKind.Utc).AddTicks(1905), 921.597524492128000m, "Damian.Huels@hotmail.com", "Demetrius", 900m, 914, "Magnam voluptas.", "640-765-2537", "Kuphal" },
                    { new Guid("045b93a7-b86a-3d57-daea-1b640bed1901"), "Christmas Island", new DateTime(1971, 6, 14, 3, 28, 19, 878, DateTimeKind.Utc).AddTicks(7198), 463.263445682265000m, "Mariana65@hotmail.com", "Ezra", 600m, 188, "Necessitatibus odio.", "1-333-949-2823", "Brakus" },
                    { new Guid("0485d652-b904-5cba-c62a-20d0b010521f"), "Turkey", new DateTime(1986, 8, 3, 16, 17, 48, 382, DateTimeKind.Utc).AddTicks(2284), 874.7372443959000m, "Colleen92@yahoo.com", "Cassandra", 900m, 93, "Quia occaecati.", "(687) 441-5002", "Crist" },
                    { new Guid("04e0030b-f8c4-1e7b-0dbc-2f836ccc3247"), "France", new DateTime(1991, 6, 16, 5, 53, 25, 116, DateTimeKind.Utc).AddTicks(7804), 446.857155084065000m, "Glennie_Howe23@hotmail.com", "Deshawn", 1000m, 725, "Sapiente rerum.", "(410) 781-7640", "Effertz" },
                    { new Guid("050518e5-b133-b4f5-bb0a-2f8a09697392"), "Colombia", new DateTime(1965, 12, 7, 5, 29, 41, 117, DateTimeKind.Utc).AddTicks(1151), 125.337477151363000m, "Carey_Erdman@gmail.com", "Nicholaus", 500m, 459, "Omnis consequatur.", "1-425-582-7654", "Wolff" },
                    { new Guid("05090f1f-46ec-4731-d44e-e4cd94dba41b"), "Sao Tome and Principe", new DateTime(1958, 3, 10, 11, 36, 51, 103, DateTimeKind.Utc).AddTicks(1292), 153.317245096931000m, "Forest.Russel71@gmail.com", "Enos", 600m, 40, "Ipsa et.", "576.419.2271", "Vandervort" },
                    { new Guid("05097801-25f0-cb7d-6548-ab9712962130"), "Tajikistan", new DateTime(1943, 11, 3, 12, 47, 13, 905, DateTimeKind.Utc).AddTicks(8148), 636.813477519212000m, "Willow_Beier52@hotmail.com", "Trinity", 1000m, 140, "Accusantium voluptas.", "829.388.4613 x8466", "Denesik" },
                    { new Guid("05246b48-ac71-4314-f935-73ae9a6302eb"), "Mongolia", new DateTime(2012, 10, 6, 11, 38, 37, 538, DateTimeKind.Utc).AddTicks(1854), 231.622136805144000m, "Maritza_Bayer@yahoo.com", "Dandre", 800m, 162, "Nesciunt est.", "752-568-3029 x22424", "Stoltenberg" },
                    { new Guid("059fe254-ed03-348b-72b0-53b0b63fd664"), "Macao", new DateTime(2003, 11, 23, 14, 41, 37, 724, DateTimeKind.Utc).AddTicks(4693), 467.477883861304000m, "Cathy_Kiehn@yahoo.com", "Mellie", 900m, 515, "Iusto tempora.", "667.247.6311 x9801", "Pacocha" },
                    { new Guid("06295574-9771-f1e0-e20b-e72e5d39852d"), "Venezuela", new DateTime(1954, 11, 9, 8, 52, 21, 48, DateTimeKind.Utc).AddTicks(6346), 103.080625810037000m, "Richie.Beahan74@gmail.com", "Breana", 800m, 638, "Aut recusandae.", "282.241.6462", "Hessel" },
                    { new Guid("0668d09f-da20-695f-11be-ba7bfc77c693"), "Finland", new DateTime(1988, 9, 25, 7, 4, 20, 788, DateTimeKind.Utc).AddTicks(9668), 833.334747637682000m, "Mathew65@hotmail.com", "Modesta", 500m, 936, "Harum unde.", "1-429-914-0362", "Mosciski" },
                    { new Guid("068e96a5-8d8e-c3e3-948e-ece17908d986"), "Turks and Caicos Islands", new DateTime(1963, 7, 7, 3, 45, 13, 845, DateTimeKind.Utc).AddTicks(3056), 766.145511385436000m, "Bill_Nienow33@gmail.com", "Claudine", 500m, 320, "Dolorem non.", "208.372.8191 x494", "Prosacco" },
                    { new Guid("06ee3d5c-c819-d6d0-d6df-20c3d694660b"), "Mexico", new DateTime(2009, 7, 26, 21, 55, 32, 607, DateTimeKind.Utc).AddTicks(7976), 163.776941128551000m, "Erika52@hotmail.com", "Kaitlin", 900m, 562, "Quisquam consequatur.", "1-541-752-5687 x357", "Koepp" },
                    { new Guid("06fe120f-908a-5be2-5aa9-0f57d0e668c1"), "Belarus", new DateTime(1996, 2, 4, 19, 42, 45, 542, DateTimeKind.Utc).AddTicks(3955), 491.532241264221000m, "Karlie.Schimmel@gmail.com", "Osbaldo", 800m, 568, "Eaque pariatur.", "511-482-8792 x4959", "Pagac" },
                    { new Guid("074de468-9cfe-cd15-71b2-8a23829d1e62"), "Brunei Darussalam", new DateTime(2003, 8, 10, 10, 57, 12, 282, DateTimeKind.Utc).AddTicks(966), 327.431798154341000m, "Eloy88@gmail.com", "Stewart", 600m, 776, "Sed dolores.", "(325) 200-9812 x848", "Hauck" },
                    { new Guid("07992549-335f-0c1d-1ec3-9e168c6c44de"), "Dominican Republic", new DateTime(2003, 11, 4, 22, 42, 57, 347, DateTimeKind.Utc).AddTicks(5833), 251.667486578521000m, "Blanca_Bahringer29@hotmail.com", "Keshawn", 700m, 690, "Dolores est.", "1-271-565-5514 x3083", "Gutkowski" },
                    { new Guid("07ab722c-5130-f87c-30b2-b6ab8d84c4b3"), "Rwanda", new DateTime(1956, 12, 31, 17, 17, 25, 345, DateTimeKind.Utc).AddTicks(7538), 96.51246776155000m, "Scotty.Funk20@yahoo.com", "Howell", 1000m, 701, "Voluptate deleniti.", "1-405-725-6951 x2718", "Cummings" },
                    { new Guid("07cd8768-e0ab-13ff-0d58-4d4ee3e7938c"), "Democratic People's Republic of Korea", new DateTime(2021, 3, 16, 22, 54, 50, 290, DateTimeKind.Utc).AddTicks(8501), 537.927268311691000m, "Hannah_Lesch66@hotmail.com", "Ludwig", 500m, 585, "Voluptates et.", "(636) 805-9895 x7779", "Spencer" },
                    { new Guid("083f3089-2bb0-3b71-1bab-3d6a52914e22"), "Micronesia", new DateTime(1934, 2, 13, 3, 9, 58, 529, DateTimeKind.Utc).AddTicks(2731), 716.040240245176000m, "Kattie.Hamill57@hotmail.com", "Bennie", 900m, 709, "Facilis placeat.", "(668) 789-5880 x5227", "Miller" },
                    { new Guid("08b4abaf-ca17-817e-c2a3-fbe88fe1ae7f"), "Ecuador", new DateTime(1977, 1, 12, 20, 14, 14, 451, DateTimeKind.Utc).AddTicks(9194), 459.139746232662000m, "Dave51@yahoo.com", "Isac", 700m, 643, "Asperiores eos.", "1-672-976-7271 x8524", "Trantow" },
                    { new Guid("08c36232-9ab8-718d-90eb-c62765c91e16"), "Armenia", new DateTime(1997, 6, 17, 5, 56, 7, 478, DateTimeKind.Utc).AddTicks(1689), 557.734361161713000m, "Germaine44@hotmail.com", "Madyson", 700m, 481, "Mollitia et.", "435-318-3918 x9911", "Wiegand" },
                    { new Guid("08dbd89d-852b-b33c-49a8-a09e50d4a614"), "Romania", new DateTime(1950, 7, 23, 11, 43, 26, 327, DateTimeKind.Utc).AddTicks(6483), 610.979203229988000m, "Destiny_Turner@yahoo.com", "Antwan", 500m, 480, "Error quibusdam.", "1-912-582-0241", "Kuhn" },
                    { new Guid("094b2d1a-1919-811c-ec2b-64e97113d068"), "Monaco", new DateTime(1934, 9, 22, 11, 31, 42, 888, DateTimeKind.Utc).AddTicks(6578), 49.0125603112327000m, "Scarlett41@gmail.com", "Jaleel", 800m, 507, "Error dolores.", "(743) 849-0709 x800", "Haag" },
                    { new Guid("096d3eab-2665-d0c3-b2e9-f5dfc56c94b2"), "Jordan", new DateTime(1970, 7, 18, 20, 26, 57, 424, DateTimeKind.Utc).AddTicks(3853), 378.588818344695000m, "Harry.Swift@yahoo.com", "Mozell", 600m, 610, "Sint itaque.", "825.235.0008 x14774", "Schamberger" },
                    { new Guid("099ce7d5-cdda-545e-92ed-8920730b885a"), "New Zealand", new DateTime(1979, 9, 9, 23, 38, 1, 137, DateTimeKind.Utc).AddTicks(1302), 353.60697275374000m, "Marion34@gmail.com", "Addie", 1000m, 373, "Commodi autem.", "1-444-986-1075 x0165", "Heidenreich" },
                    { new Guid("09b811d3-d3c7-364a-4f19-b1b8107f1f5a"), "Sri Lanka", new DateTime(2019, 2, 18, 21, 4, 43, 790, DateTimeKind.Utc).AddTicks(4709), 887.896394204921000m, "Leopold.Hoppe@yahoo.com", "Ahmad", 1000m, 495, "Est omnis.", "603.828.9923 x1435", "Dickens" },
                    { new Guid("09babca5-e967-9460-4eb7-317afa84d919"), "Mauritius", new DateTime(1959, 12, 25, 19, 59, 50, 691, DateTimeKind.Utc).AddTicks(6247), 764.912083438325000m, "Eusebio.Senger88@yahoo.com", "Ayla", 700m, 199, "Minima quo.", "928.763.0287 x099", "Walker" },
                    { new Guid("09c769a8-6b4b-3259-3b4b-0d98a3158117"), "Portugal", new DateTime(1997, 10, 3, 20, 26, 28, 536, DateTimeKind.Utc).AddTicks(8547), 110.668328489229000m, "Genoveva36@gmail.com", "Mazie", 900m, 132, "Quam autem.", "431.530.0525 x545", "Reinger" },
                    { new Guid("09d57690-fed1-b2fa-188e-ae40645fbab5"), "Northern Mariana Islands", new DateTime(2016, 10, 19, 13, 27, 50, 964, DateTimeKind.Utc).AddTicks(7728), 527.802327978426000m, "Loma2@yahoo.com", "Wilfred", 1000m, 319, "Et aut.", "916.477.5978 x94488", "Lueilwitz" },
                    { new Guid("09ec6ad8-9cb7-c424-4919-1cd1012faed5"), "Puerto Rico", new DateTime(1972, 10, 22, 22, 21, 45, 692, DateTimeKind.Utc).AddTicks(9010), 744.720137428231000m, "Alva.Johnston1@hotmail.com", "Dasia", 600m, 391, "Consequuntur beatae.", "247-552-9253 x54591", "Jones" },
                    { new Guid("0a317315-1e92-cf08-08d8-5568d40d3305"), "Burkina Faso", new DateTime(2013, 6, 4, 18, 40, 9, 481, DateTimeKind.Utc).AddTicks(6514), 99.8363542300321000m, "Lonie32@gmail.com", "Jimmy", 900m, 254, "Est doloribus.", "916.319.0382 x533", "Wintheiser" },
                    { new Guid("0a5fd863-021f-aacc-7a30-028458565da8"), "Falkland Islands (Malvinas)", new DateTime(1934, 7, 31, 11, 27, 31, 60, DateTimeKind.Utc).AddTicks(856), 379.912713411237000m, "Reta75@gmail.com", "Finn", 1000m, 675, "Inventore nesciunt.", "1-538-734-0279", "Marquardt" },
                    { new Guid("0a6d5485-c628-c614-bef8-b78a336bd113"), "Indonesia", new DateTime(2005, 1, 20, 6, 30, 47, 642, DateTimeKind.Utc).AddTicks(7093), 722.023739946234000m, "Mac72@yahoo.com", "Dimitri", 900m, 888, "Quos commodi.", "311-408-3025 x1443", "Greenholt" },
                    { new Guid("0a72c9da-bd3b-acd7-79bc-76dbc7bc5a0b"), "Paraguay", new DateTime(2002, 7, 28, 16, 15, 8, 68, DateTimeKind.Utc).AddTicks(8238), 632.033863060107000m, "Norma77@yahoo.com", "Kelsi", 700m, 158, "Inventore et.", "1-782-673-0588", "Labadie" },
                    { new Guid("0af64c57-7f15-337a-9efa-5259a6779117"), "Haiti", new DateTime(1998, 5, 27, 7, 17, 31, 939, DateTimeKind.Utc).AddTicks(9153), 612.546141039376000m, "Cordia_Kiehn@yahoo.com", "Valentine", 1000m, 239, "Similique omnis.", "291-692-5226", "Hagenes" },
                    { new Guid("0b137cdf-8f04-bca2-e1bf-4c30cf663621"), "Bolivia", new DateTime(1938, 5, 9, 23, 39, 47, 418, DateTimeKind.Utc).AddTicks(6627), 965.516675106988000m, "Niko.Greenholt@gmail.com", "Kale", 700m, 971, "Eligendi rem.", "(768) 540-7258", "Turner" },
                    { new Guid("0b4d8b13-8a1e-30c6-3e41-f7230bcb691d"), "Nepal", new DateTime(1968, 6, 23, 14, 4, 5, 855, DateTimeKind.Utc).AddTicks(8098), 632.555977345688000m, "Kristopher.Walsh81@gmail.com", "Joel", 600m, 876, "Nobis ipsam.", "844.786.8374 x37971", "Hettinger" },
                    { new Guid("0b64274d-e950-7929-3c7e-d82ed5d0e2ce"), "Japan", new DateTime(1975, 2, 15, 5, 19, 52, 820, DateTimeKind.Utc).AddTicks(6603), 840.69916272571000m, "Luigi_Stamm75@gmail.com", "Maiya", 600m, 98, "Est possimus.", "268.351.0388 x76517", "Abbott" },
                    { new Guid("0c6d4701-fa4a-67f1-05f8-f4d12710ba66"), "Turkey", new DateTime(1941, 7, 11, 21, 34, 33, 172, DateTimeKind.Utc).AddTicks(5718), 915.859137177201000m, "Jarvis_Nikolaus@hotmail.com", "Effie", 700m, 274, "Dolor amet.", "1-820-289-1409 x8722", "Schneider" },
                    { new Guid("0cb4c38f-c26d-388f-0847-ffbfe6a0e309"), "Yemen", new DateTime(1934, 8, 15, 15, 48, 15, 817, DateTimeKind.Utc).AddTicks(5154), 126.533985382803000m, "Troy_Hammes@hotmail.com", "Llewellyn", 900m, 919, "Nisi voluptas.", "(330) 384-3057 x9438", "Torphy" },
                    { new Guid("0e036b28-34e6-43f4-f7f5-2595dd6bea4d"), "Bolivia", new DateTime(2010, 7, 10, 5, 10, 54, 746, DateTimeKind.Utc).AddTicks(9397), 837.593824413485000m, "Anabel.Rice67@yahoo.com", "Gerson", 500m, 446, "Et et.", "1-210-266-1150", "Kling" },
                    { new Guid("0e0f17a7-f1d0-66e6-d587-5809f5546501"), "Ukraine", new DateTime(1987, 10, 4, 20, 38, 47, 821, DateTimeKind.Utc).AddTicks(4264), 392.431291075441000m, "Lawrence57@yahoo.com", "Marisa", 800m, 126, "Nesciunt vel.", "874-882-2476 x863", "Connelly" },
                    { new Guid("0e61812d-1ef2-53c5-65d8-56844cb49409"), "Uruguay", new DateTime(1999, 6, 2, 9, 4, 4, 335, DateTimeKind.Utc).AddTicks(1242), 462.262163132238000m, "Hoyt.Raynor@yahoo.com", "Annamarie", 600m, 178, "Aut incidunt.", "566-457-7420", "Murray" },
                    { new Guid("0eeef62a-915f-e4b6-302b-2cedbe60602f"), "Kazakhstan", new DateTime(1948, 5, 9, 9, 56, 10, 754, DateTimeKind.Utc).AddTicks(2675), 4.81898576376805000m, "Brant.Bosco30@hotmail.com", "Jacynthe", 800m, 747, "Provident nihil.", "(612) 957-1775 x2068", "Pouros" },
                    { new Guid("0f514e6f-bf23-b9ff-d52a-97fd28588fa9"), "Bosnia and Herzegovina", new DateTime(1947, 7, 21, 16, 19, 57, 211, DateTimeKind.Utc).AddTicks(3696), 717.370146681117000m, "Alene.Cremin74@gmail.com", "Noemy", 600m, 167, "Nam voluptatem.", "820.999.1298 x2873", "Kirlin" },
                    { new Guid("0f67eca7-2e4c-b71b-6ac2-c781775687c9"), "Pitcairn Islands", new DateTime(1972, 4, 21, 0, 31, 40, 632, DateTimeKind.Utc).AddTicks(1782), 208.488201665385000m, "Austyn.Krajcik@yahoo.com", "Glen", 900m, 328, "Laboriosam explicabo.", "(907) 754-1321 x0876", "Bogisich" },
                    { new Guid("0fa1f50a-ff2f-f8a0-4d99-b2ddc9bbb47f"), "Uruguay", new DateTime(1932, 12, 3, 15, 44, 57, 491, DateTimeKind.Utc).AddTicks(1579), 793.529611734208000m, "Arthur_Welch75@yahoo.com", "Eugenia", 600m, 738, "Nihil iure.", "1-799-811-5285 x8962", "White" },
                    { new Guid("1028bffa-c23a-84fc-4a61-52d19e2442ca"), "Gibraltar", new DateTime(1931, 9, 3, 2, 16, 43, 421, DateTimeKind.Utc).AddTicks(9708), 846.649431844731000m, "Krystal.Fisher@hotmail.com", "Cathy", 700m, 775, "Repudiandae sed.", "(955) 570-9794 x5499", "Wiegand" },
                    { new Guid("10440ba8-a1f8-6e9a-c335-3e1104386432"), "Malaysia", new DateTime(2012, 6, 23, 14, 26, 53, 18, DateTimeKind.Utc).AddTicks(7454), 951.820636190054000m, "Odie_Lockman@hotmail.com", "Retha", 1000m, 593, "Voluptatem dicta.", "519.699.3356 x2205", "Tillman" },
                    { new Guid("1055481a-852f-df53-05bc-891def912877"), "Macao", new DateTime(1990, 4, 22, 17, 12, 38, 395, DateTimeKind.Utc).AddTicks(2245), 180.009392177935000m, "Melvina.Dickinson@gmail.com", "Bo", 900m, 116, "In beatae.", "(310) 608-6559 x3517", "Kuvalis" },
                    { new Guid("10b81a0b-0340-bd0f-4fe6-914a3af1654c"), "Canada", new DateTime(1976, 1, 8, 23, 47, 37, 800, DateTimeKind.Utc).AddTicks(2219), 916.575588461478000m, "Marielle_Johnson74@yahoo.com", "Rosetta", 600m, 204, "Voluptatem possimus.", "1-760-652-8039 x8005", "Upton" },
                    { new Guid("10e1de7f-fb9b-be0f-30ec-4d8a70f7a4b9"), "Chad", new DateTime(1998, 6, 8, 15, 33, 8, 258, DateTimeKind.Utc).AddTicks(2093), 90.0924896288298000m, "Cecilia_Kovacek@gmail.com", "Christophe", 800m, 824, "Cum eveniet.", "1-301-601-1689", "Boehm" },
                    { new Guid("11f1bafd-4268-1e83-c1d4-dd02f85723be"), "Cyprus", new DateTime(1938, 10, 17, 23, 23, 28, 222, DateTimeKind.Utc).AddTicks(9764), 632.875699431146000m, "Haley.Klocko79@gmail.com", "Craig", 900m, 904, "Tenetur molestiae.", "651-361-6706 x5460", "Stracke" },
                    { new Guid("1214ea69-62d9-a3b1-8e28-90bd9eb96cf5"), "Poland", new DateTime(1949, 1, 4, 1, 44, 28, 988, DateTimeKind.Utc).AddTicks(7307), 7.38754510787409000m, "Susanna_Rohan5@hotmail.com", "Lonzo", 900m, 839, "Ipsam voluptatem.", "709.374.7194 x99955", "Gusikowski" },
                    { new Guid("12bfd37b-dc34-ac82-dab0-bfba6f2d29ec"), "Philippines", new DateTime(1925, 12, 26, 19, 35, 50, 962, DateTimeKind.Utc).AddTicks(6723), 381.255431101111000m, "Richie.Fadel38@hotmail.com", "Elza", 500m, 753, "Amet asperiores.", "(442) 819-9895 x5379", "Stoltenberg" },
                    { new Guid("131cef0a-eba7-5b71-30c5-386a41125515"), "Malawi", new DateTime(1950, 6, 27, 12, 16, 20, 272, DateTimeKind.Utc).AddTicks(6156), 848.570354779389000m, "Talon63@yahoo.com", "Ana", 600m, 388, "Autem quam.", "998-357-2363 x6830", "Moore" },
                    { new Guid("1330516d-f96b-a781-6ee1-f490eef86a37"), "Senegal", new DateTime(1934, 12, 14, 4, 6, 12, 593, DateTimeKind.Utc).AddTicks(1856), 328.63906762874000m, "Christophe_Dach@yahoo.com", "Regan", 900m, 497, "Ducimus harum.", "(580) 299-6930 x566", "Runte" },
                    { new Guid("1353fe8b-ae65-a91a-99bc-42746b03ec2f"), "Sri Lanka", new DateTime(1971, 1, 26, 0, 30, 10, 952, DateTimeKind.Utc).AddTicks(852), 597.82993511411000m, "Stevie71@gmail.com", "Tobin", 700m, 671, "Qui veniam.", "1-988-711-9367 x9022", "Rohan" },
                    { new Guid("135b10a8-c77e-880c-c79b-1394a078088d"), "Norfolk Island", new DateTime(1930, 10, 28, 5, 38, 2, 751, DateTimeKind.Utc).AddTicks(8849), 600.282485812958000m, "Hope89@gmail.com", "Keaton", 800m, 75, "Omnis aut.", "466.263.8662 x529", "D'Amore" },
                    { new Guid("13d0c4b7-a2a1-bf73-751a-78b4869fd2f1"), "American Samoa", new DateTime(1983, 10, 24, 20, 20, 17, 935, DateTimeKind.Utc).AddTicks(5164), 234.032042998203000m, "Ova_Bradtke6@gmail.com", "Esta", 1000m, 762, "Qui quo.", "1-787-575-1159 x978", "Hilpert" },
                    { new Guid("13fcd18a-695e-0fe3-99de-ce1b97dc7262"), "Timor-Leste", new DateTime(1933, 6, 22, 4, 59, 14, 506, DateTimeKind.Utc).AddTicks(3529), 947.528730678548000m, "Antonio_Gerhold@gmail.com", "Emerald", 800m, 192, "Rem omnis.", "(966) 309-2143", "O'Reilly" },
                    { new Guid("1407b112-2e73-dedf-91bc-376d946cd3a2"), "Cambodia", new DateTime(1992, 4, 1, 14, 36, 54, 471, DateTimeKind.Utc).AddTicks(6488), 488.99524767981000m, "Nels43@yahoo.com", "Aiden", 900m, 13, "Et harum.", "(869) 286-8329 x3405", "Wyman" },
                    { new Guid("14135c79-bca4-9aa8-982c-ea6e92ef3f93"), "Guyana", new DateTime(1928, 4, 19, 12, 48, 59, 753, DateTimeKind.Utc).AddTicks(3786), 678.600086347943000m, "Destiny37@yahoo.com", "Zita", 700m, 549, "Cumque vero.", "(937) 950-6564", "Connelly" },
                    { new Guid("145b9af6-807f-8a6f-da06-3d787e99378b"), "Gibraltar", new DateTime(1965, 11, 30, 10, 46, 24, 714, DateTimeKind.Utc).AddTicks(5805), 504.881957367356000m, "Jesse_Hyatt@yahoo.com", "Kacie", 600m, 115, "Est laboriosam.", "1-211-600-7917", "Predovic" },
                    { new Guid("14dde31c-2158-2f43-010f-b5ddf3ab9be8"), "Nauru", new DateTime(1991, 8, 10, 14, 11, 7, 117, DateTimeKind.Utc).AddTicks(5174), 943.495063691086000m, "Lucienne.Kemmer78@hotmail.com", "George", 700m, 840, "Dignissimos qui.", "920.655.5366 x8225", "Baumbach" },
                    { new Guid("159ebe22-620d-9960-6cc2-5f4d98bb901b"), "Argentina", new DateTime(2010, 8, 14, 5, 32, 21, 769, DateTimeKind.Utc).AddTicks(1830), 136.490060803943000m, "Roger_Gibson39@yahoo.com", "Paris", 1000m, 248, "Quia ipsam.", "871-423-3282 x858", "Rohan" },
                    { new Guid("164c0b41-232f-de61-d04b-94a7785e58b6"), "Bahamas", new DateTime(1958, 6, 24, 20, 37, 12, 402, DateTimeKind.Utc).AddTicks(9079), 88.7324677669712000m, "Otilia.MacGyver30@hotmail.com", "Isaac", 500m, 423, "Aliquam voluptates.", "691-651-6415 x42314", "Stoltenberg" },
                    { new Guid("1653d3b0-23c2-36fc-fa91-58a9bf859bb0"), "France", new DateTime(1967, 9, 28, 20, 15, 39, 225, DateTimeKind.Utc).AddTicks(2745), 772.338307989273000m, "Elta.Stark72@yahoo.com", "Frank", 800m, 500, "Voluptate occaecati.", "(965) 975-8567", "Armstrong" },
                    { new Guid("16f1a881-1c77-bcdf-3437-f30dc1842412"), "Greece", new DateTime(1947, 9, 23, 9, 10, 43, 253, DateTimeKind.Utc).AddTicks(1529), 629.319127912929000m, "Margarita_Gusikowski76@hotmail.com", "Marcus", 800m, 654, "Consequatur sit.", "(456) 539-2154 x2670", "McKenzie" },
                    { new Guid("176fad9e-d783-114f-0688-6115a6c30a5a"), "Bouvet Island (Bouvetoya)", new DateTime(1937, 4, 27, 8, 33, 17, 986, DateTimeKind.Utc).AddTicks(8774), 721.990159827392000m, "Lilyan.Feil@gmail.com", "Dulce", 700m, 526, "Id est.", "419-932-1351 x85135", "Crist" },
                    { new Guid("17cbe43e-a9ef-0297-0901-f71d772872bc"), "Argentina", new DateTime(1987, 9, 13, 1, 0, 10, 152, DateTimeKind.Utc).AddTicks(8095), 678.920952487008000m, "Rhett_Douglas@hotmail.com", "Brionna", 900m, 90, "Consectetur nisi.", "1-364-417-5028 x0294", "Schmeler" },
                    { new Guid("17f0e947-798c-93bd-d989-f2de6025e90d"), "Marshall Islands", new DateTime(1941, 4, 25, 23, 8, 5, 157, DateTimeKind.Utc).AddTicks(9913), 238.660471713245000m, "Nia47@hotmail.com", "Cruz", 800m, 290, "Fugiat laboriosam.", "530.625.1858", "Mohr" },
                    { new Guid("183d516d-9419-cafd-3aa8-61c6dbb43ebe"), "Ethiopia", new DateTime(1946, 9, 19, 5, 50, 32, 5, DateTimeKind.Utc).AddTicks(199), 116.702174842438000m, "Mohammad.Ziemann@hotmail.com", "Sunny", 600m, 647, "Quod id.", "(293) 481-4936 x627", "Ritchie" },
                    { new Guid("18460192-2fea-78db-e25f-6d1d3b883d87"), "British Indian Ocean Territory (Chagos Archipelago)", new DateTime(1962, 2, 3, 19, 37, 43, 993, DateTimeKind.Utc).AddTicks(8539), 732.568684911366000m, "Ottilie_Sawayn@yahoo.com", "Hilma", 900m, 267, "Omnis debitis.", "277-445-9735", "Kerluke" },
                    { new Guid("1873f7a9-58e5-54ad-70b4-cdd4ff637335"), "Burundi", new DateTime(1991, 12, 25, 23, 30, 12, 845, DateTimeKind.Utc).AddTicks(1812), 378.820810438513000m, "Ericka.Jakubowski72@hotmail.com", "Lera", 500m, 408, "Velit repellat.", "1-767-332-9470 x4074", "Lakin" },
                    { new Guid("1887289b-c0f5-38c4-a52c-760e5b67a142"), "Hungary", new DateTime(1955, 12, 18, 13, 32, 39, 315, DateTimeKind.Utc).AddTicks(217), 348.478273820472000m, "Ian69@gmail.com", "Marta", 700m, 55, "Nihil corrupti.", "1-483-251-5816 x3689", "Heidenreich" },
                    { new Guid("18af8ed7-6bec-c182-46e2-e7e4a4480901"), "Ethiopia", new DateTime(1992, 11, 29, 9, 15, 54, 383, DateTimeKind.Utc).AddTicks(7418), 669.846260996117000m, "Courtney.Wunsch@hotmail.com", "Michale", 1000m, 896, "Odit est.", "763.536.9713 x210", "Batz" },
                    { new Guid("18c906cb-dc15-ba1e-b1f3-77c4f329e13b"), "Cape Verde", new DateTime(2011, 7, 24, 16, 11, 5, 544, DateTimeKind.Utc).AddTicks(4973), 817.701706422743000m, "Delfina_Gusikowski58@hotmail.com", "Micah", 1000m, 513, "Fuga assumenda.", "1-875-481-2845", "Breitenberg" },
                    { new Guid("18f34dd3-1d5e-7c6a-9a5c-e5c14774474d"), "Colombia", new DateTime(2005, 7, 19, 17, 31, 40, 208, DateTimeKind.Utc).AddTicks(4108), 576.823531313891000m, "Ellis_Kutch20@hotmail.com", "Alessandro", 500m, 197, "Aliquid perferendis.", "255-480-2124 x740", "Sawayn" },
                    { new Guid("19157c5f-d2b9-5454-447f-fd7365486176"), "Puerto Rico", new DateTime(2024, 4, 30, 23, 49, 21, 901, DateTimeKind.Utc).AddTicks(6020), 881.183964308232000m, "Katelyn_Bogisich@hotmail.com", "Precious", 900m, 222, "Rem maxime.", "1-263-240-7947 x5301", "Becker" },
                    { new Guid("193b9bb6-f1a4-ef35-541f-8f977a42330a"), "Mauritius", new DateTime(2012, 1, 12, 5, 24, 5, 118, DateTimeKind.Utc).AddTicks(6780), 23.8873820717442000m, "Mable.Kautzer@gmail.com", "Coby", 900m, 280, "Qui doloribus.", "913-276-6257 x520", "Leuschke" },
                    { new Guid("19535bee-6eac-334a-28e7-85c2e31d9c1d"), "Palestinian Territory", new DateTime(1951, 4, 26, 6, 22, 55, 800, DateTimeKind.Utc).AddTicks(9489), 320.955529373599000m, "Kolby.Greenfelder66@hotmail.com", "Preston", 700m, 673, "Omnis quo.", "1-816-322-5417", "Champlin" },
                    { new Guid("19aa5543-b682-4dc4-18b2-21a11485d90d"), "Bahamas", new DateTime(2002, 5, 23, 20, 25, 17, 303, DateTimeKind.Utc).AddTicks(9185), 402.806848420893000m, "Justus.Farrell@yahoo.com", "Esther", 800m, 954, "Corporis culpa.", "725-504-4916 x97215", "Dach" },
                    { new Guid("19d97078-71c7-97c9-3909-976016cba15c"), "Macao", new DateTime(1926, 8, 3, 21, 5, 9, 655, DateTimeKind.Utc).AddTicks(9714), 789.558781802799000m, "Serenity17@gmail.com", "Jamal", 700m, 902, "Sequi adipisci.", "1-900-391-4052 x9252", "McClure" },
                    { new Guid("19dbe816-9c16-61ed-c6e4-b646ed8c2b0a"), "United States of America", new DateTime(2006, 8, 16, 15, 22, 8, 785, DateTimeKind.Utc).AddTicks(2662), 353.801400898024000m, "Nina.Jacobi54@gmail.com", "Joesph", 900m, 60, "Nulla in.", "1-832-331-7658 x575", "Corkery" },
                    { new Guid("1a2dd853-3147-5e17-20ff-e725820cf2c5"), "Ireland", new DateTime(1938, 6, 25, 16, 52, 28, 280, DateTimeKind.Utc).AddTicks(1573), 114.246783294602000m, "Delilah.Ward@gmail.com", "Florence", 600m, 938, "Iure mollitia.", "1-442-670-0804", "Braun" },
                    { new Guid("1a3abb3b-3bd1-1e2e-c02d-1dc139b4b7fb"), "Eritrea", new DateTime(2006, 8, 15, 14, 44, 3, 903, DateTimeKind.Utc).AddTicks(4389), 320.345267042368000m, "Marilie65@gmail.com", "Abigail", 600m, 789, "Similique quae.", "(434) 484-2633", "Funk" },
                    { new Guid("1a43d088-3990-dff1-1b46-2f190a40f56c"), "Cape Verde", new DateTime(1959, 8, 25, 3, 51, 43, 783, DateTimeKind.Utc).AddTicks(9331), 504.157267298116000m, "Duane23@gmail.com", "Erick", 800m, 334, "Nemo sed.", "(431) 800-0405 x6973", "Krajcik" },
                    { new Guid("1a839a51-5661-ef74-872d-7074488b16f0"), "South Georgia and the South Sandwich Islands", new DateTime(2016, 2, 6, 9, 59, 41, 578, DateTimeKind.Utc).AddTicks(7428), 461.992943468299000m, "Declan94@gmail.com", "Meaghan", 900m, 781, "Temporibus laudantium.", "553.871.0576", "Block" },
                    { new Guid("1a85d98a-0974-b8e4-f0a0-517dce016ab0"), "French Guiana", new DateTime(1982, 9, 18, 20, 33, 26, 971, DateTimeKind.Utc).AddTicks(5431), 279.480161490301000m, "Alec.Considine82@hotmail.com", "Nella", 1000m, 600, "Quidem quod.", "896-462-5575 x7779", "Von" },
                    { new Guid("1bbcf22f-6cf4-e580-5144-e7e4efb4cb9d"), "Virgin Islands, U.S.", new DateTime(1976, 1, 26, 8, 33, 30, 785, DateTimeKind.Utc).AddTicks(3615), 91.7683422991247000m, "Ada.Rodriguez71@hotmail.com", "Major", 500m, 427, "Voluptatem molestias.", "1-304-334-3319 x1355", "Kling" },
                    { new Guid("1bcbcc49-2722-e3f9-17d2-d32598b9b812"), "Puerto Rico", new DateTime(1999, 8, 7, 0, 28, 20, 285, DateTimeKind.Utc).AddTicks(117), 985.801162624216000m, "Judy.Collier42@hotmail.com", "Allie", 600m, 282, "Vero eum.", "771-736-9273", "Wintheiser" },
                    { new Guid("1c5640cf-7093-963c-85de-0c2bdcf1c720"), "Montserrat", new DateTime(1960, 12, 15, 13, 45, 43, 118, DateTimeKind.Utc).AddTicks(6233), 95.0290898413971000m, "Assunta.Fay96@yahoo.com", "Michael", 700m, 187, "Assumenda quia.", "952.947.8050 x93879", "Corwin" },
                    { new Guid("1c625058-fa14-b391-1c81-286825cf4e84"), "Iran", new DateTime(1992, 2, 26, 2, 29, 14, 314, DateTimeKind.Utc).AddTicks(4033), 57.1490493946193000m, "Kari_Auer@gmail.com", "Amari", 600m, 486, "Quis unde.", "1-257-694-2923", "Greenholt" },
                    { new Guid("1cdadd4a-29f8-b31e-2343-e80c703c2dde"), "Japan", new DateTime(1971, 8, 8, 6, 5, 20, 75, DateTimeKind.Utc).AddTicks(6063), 465.096984955737000m, "Bertram_Collins79@hotmail.com", "Aubree", 1000m, 575, "Delectus ipsum.", "472.594.4604", "Wisoky" },
                    { new Guid("1d02aa3f-5202-2efd-41d1-1c185719e7f8"), "Mayotte", new DateTime(1966, 9, 23, 2, 56, 41, 627, DateTimeKind.Utc).AddTicks(4392), 96.8452080710219000m, "Fletcher_Cronin98@gmail.com", "Keven", 1000m, 516, "Sunt voluptatem.", "893-779-2832 x43292", "Ortiz" },
                    { new Guid("1d79ec58-a3cc-03f3-0407-896bfd2b3664"), "Cyprus", new DateTime(1975, 5, 11, 13, 41, 1, 471, DateTimeKind.Utc).AddTicks(2079), 431.224190706834000m, "Providenci_Adams@yahoo.com", "Donna", 900m, 790, "Sit aliquid.", "455-220-3196 x369", "Bogan" },
                    { new Guid("1d80a5c5-3709-426a-46cb-c9e0e5aa0e15"), "Liechtenstein", new DateTime(1979, 8, 25, 20, 3, 33, 630, DateTimeKind.Utc).AddTicks(5563), 770.309170820279000m, "Amalia_Skiles@yahoo.com", "Alexandria", 800m, 189, "Impedit quidem.", "1-513-451-3191", "McDermott" },
                    { new Guid("1d90c141-8a53-16cc-1066-e58f1951630e"), "Morocco", new DateTime(1956, 6, 18, 5, 18, 44, 532, DateTimeKind.Utc).AddTicks(9421), 278.910949902356000m, "Khalid.Grady0@yahoo.com", "Jada", 700m, 662, "Magnam ea.", "986-564-9031", "Rolfson" },
                    { new Guid("1e14d451-f1ea-a2ed-a742-fd25869fe5e9"), "Ukraine", new DateTime(1980, 1, 28, 12, 47, 19, 272, DateTimeKind.Utc).AddTicks(6785), 86.0510007498585000m, "Laurianne23@yahoo.com", "Vilma", 500m, 625, "Quia excepturi.", "500.347.7141", "Gusikowski" },
                    { new Guid("1e1cccfc-d3d7-7c17-eeb8-0d43dee5ae48"), "Saint Pierre and Miquelon", new DateTime(1956, 5, 6, 16, 9, 2, 183, DateTimeKind.Utc).AddTicks(1493), 365.618165795209000m, "Anabelle.Stark@yahoo.com", "Alene", 700m, 555, "Corporis tenetur.", "1-765-296-8233 x0713", "Olson" },
                    { new Guid("1e737738-6c20-9a32-16f2-1d1fe1bf6794"), "Saint Barthelemy", new DateTime(1968, 12, 30, 8, 30, 8, 785, DateTimeKind.Utc).AddTicks(758), 224.375974010906000m, "Emil.Upton@hotmail.com", "Rhoda", 800m, 540, "Ducimus atque.", "317-291-9995", "Orn" },
                    { new Guid("1ed26933-5124-faa2-2c12-43074c1f8206"), "Bosnia and Herzegovina", new DateTime(2018, 5, 7, 14, 43, 13, 913, DateTimeKind.Utc).AddTicks(5275), 603.75575113686000m, "Khalid_Ward@hotmail.com", "Christ", 600m, 527, "Voluptatibus aut.", "359.633.1064 x321", "Gottlieb" },
                    { new Guid("1ee45b99-6e27-5ed8-6c78-bdb4db02a0af"), "Antigua and Barbuda", new DateTime(2018, 4, 9, 4, 27, 52, 306, DateTimeKind.Utc).AddTicks(822), 137.024085011697000m, "Idell.Schimmel50@hotmail.com", "Arianna", 800m, 934, "Molestiae aliquam.", "1-855-234-7749 x726", "Prosacco" },
                    { new Guid("1fb51973-75bb-e4d0-1d60-2b2f1efa1537"), "Central African Republic", new DateTime(1926, 5, 14, 20, 33, 29, 842, DateTimeKind.Utc).AddTicks(1616), 811.644323438166000m, "Dorian.OKon@yahoo.com", "Arvel", 800m, 909, "Et saepe.", "1-654-701-1142 x035", "Hirthe" },
                    { new Guid("1ff0eacc-e33e-25d0-cc36-d83c39c8bb2a"), "Niger", new DateTime(1987, 5, 18, 15, 52, 30, 29, DateTimeKind.Utc).AddTicks(4264), 216.913278078585000m, "Kendra30@yahoo.com", "Eladio", 500m, 332, "Placeat est.", "(839) 572-6452 x2910", "Kunze" },
                    { new Guid("202824a4-111d-b751-da36-6cc348390257"), "Albania", new DateTime(2018, 7, 31, 19, 25, 43, 348, DateTimeKind.Utc).AddTicks(6056), 574.852199111342000m, "Jovany_Miller@yahoo.com", "Braeden", 500m, 726, "Aut accusamus.", "993.797.4324 x36891", "Larkin" },
                    { new Guid("203fcaa7-8dbe-17ad-ef6e-bdf36d798485"), "Cocos (Keeling) Islands", new DateTime(1952, 8, 3, 10, 48, 5, 491, DateTimeKind.Utc).AddTicks(7889), 940.045228337632000m, "Mustafa_Stracke@gmail.com", "Frank", 700m, 911, "Iusto sit.", "1-559-987-9854 x9316", "Jenkins" },
                    { new Guid("20e5f8dc-6ed3-3db2-bd1d-c8275c7688b7"), "Montserrat", new DateTime(2007, 3, 4, 22, 0, 28, 349, DateTimeKind.Utc).AddTicks(1441), 312.360713827819000m, "Immanuel3@gmail.com", "Cynthia", 800m, 572, "Quo dignissimos.", "904-410-1241", "Thompson" },
                    { new Guid("213edf6d-ff3a-0fbd-bcb3-11258adc5d74"), "Dominica", new DateTime(2022, 6, 28, 19, 11, 3, 515, DateTimeKind.Utc).AddTicks(969), 50.3281634680542000m, "Abagail63@gmail.com", "Agustina", 900m, 210, "Fugit quia.", "308.941.6798 x1318", "Schultz" },
                    { new Guid("2155c8fc-e5d4-b5e4-5899-288e867ddf52"), "Italy", new DateTime(1954, 11, 23, 11, 58, 52, 963, DateTimeKind.Utc).AddTicks(4905), 976.802105555753000m, "Trevor44@yahoo.com", "Eudora", 600m, 618, "Reprehenderit cum.", "842-264-7214", "McGlynn" },
                    { new Guid("2228fe08-39ae-f41e-0bb3-6a8d43a46111"), "Seychelles", new DateTime(1970, 1, 16, 15, 7, 2, 235, DateTimeKind.Utc).AddTicks(7829), 723.839061356148000m, "Ethelyn31@gmail.com", "Jerel", 1000m, 299, "Error et.", "317.532.9535 x270", "Spencer" },
                    { new Guid("22849655-d8e2-714b-211a-da9889ef7952"), "Kenya", new DateTime(1987, 3, 6, 13, 58, 7, 437, DateTimeKind.Utc).AddTicks(6526), 112.688753907062000m, "Ally37@yahoo.com", "Ola", 600m, 584, "Et ratione.", "(614) 226-0122 x3574", "Krajcik" },
                    { new Guid("22a46405-b210-7d9c-5c15-94d9494cc3c1"), "Malta", new DateTime(2003, 4, 13, 22, 46, 10, 955, DateTimeKind.Utc).AddTicks(5715), 914.136940679008000m, "Kade_Fadel@gmail.com", "Jack", 700m, 396, "Animi laboriosam.", "1-578-418-7623", "Considine" },
                    { new Guid("22b5ad7d-7c21-64ed-8cf6-0b9f688b0503"), "United States of America", new DateTime(1939, 11, 14, 9, 58, 0, 990, DateTimeKind.Utc).AddTicks(7741), 495.166231460551000m, "Nick.Stanton32@hotmail.com", "Rafael", 900m, 729, "Unde et.", "292.338.8356", "Pollich" },
                    { new Guid("2314e9ed-6b9d-f064-9b12-7d32b1485dbb"), "Indonesia", new DateTime(1969, 10, 28, 9, 42, 21, 906, DateTimeKind.Utc).AddTicks(5792), 873.624786404745000m, "Damian.Mayer75@gmail.com", "Gust", 800m, 35, "Sed nobis.", "(701) 743-8781", "Bartoletti" },
                    { new Guid("23bf9e55-bb81-24b9-7a90-46aab6eda0d2"), "British Indian Ocean Territory (Chagos Archipelago)", new DateTime(1958, 7, 26, 23, 2, 0, 934, DateTimeKind.Utc).AddTicks(5749), 252.151510647517000m, "Adrian.Beatty@gmail.com", "Dewayne", 800m, 940, "Voluptas ullam.", "1-393-636-8430 x841", "Denesik" },
                    { new Guid("23d918d5-2efd-f513-93a5-a8f8c6042282"), "Falkland Islands (Malvinas)", new DateTime(1956, 7, 16, 13, 7, 52, 178, DateTimeKind.Utc).AddTicks(5616), 775.323534169778000m, "Wilfrid39@hotmail.com", "Curt", 600m, 741, "Est qui.", "942.451.2392", "Balistreri" },
                    { new Guid("243d2580-3b94-400f-4a7c-2fc231c44806"), "Saint Lucia", new DateTime(1989, 10, 1, 7, 40, 13, 486, DateTimeKind.Utc).AddTicks(3094), 151.619259448009000m, "Shanny_Botsford63@gmail.com", "Camryn", 1000m, 343, "Laborum voluptatem.", "(552) 876-4174 x2410", "Williamson" },
                    { new Guid("24d0e00d-99d9-a066-4f49-f03a52ff233b"), "Libyan Arab Jamahiriya", new DateTime(1975, 1, 1, 17, 55, 46, 773, DateTimeKind.Utc).AddTicks(6497), 186.73275514252000m, "Alverta_Beier@hotmail.com", "Anabel", 1000m, 697, "Mollitia labore.", "1-271-909-7599", "Schumm" },
                    { new Guid("263b49a7-ec7b-3b4b-db6a-edd036d5b97c"), "Sierra Leone", new DateTime(1930, 7, 11, 12, 13, 27, 620, DateTimeKind.Utc).AddTicks(8234), 38.6033631540051000m, "Santino_Mosciski81@hotmail.com", "Oleta", 1000m, 389, "A placeat.", "268.909.0970", "Bosco" },
                    { new Guid("267e69b5-c90f-4eb2-0d64-8bab2c965d70"), "Palestinian Territory", new DateTime(1955, 6, 2, 20, 13, 58, 992, DateTimeKind.Utc).AddTicks(4780), 924.461360051007000m, "Ruben_Marks62@yahoo.com", "Zoila", 900m, 814, "Odio numquam.", "208-641-1181 x556", "Schoen" },
                    { new Guid("2731cbc3-aa6b-b5ee-f6a3-f43a13532af3"), "Croatia", new DateTime(1989, 5, 16, 20, 50, 13, 405, DateTimeKind.Utc).AddTicks(6356), 749.000002229832000m, "Keyshawn21@yahoo.com", "Gabriel", 900m, 217, "Quos similique.", "(307) 508-2339", "Wyman" },
                    { new Guid("275891ad-964e-e9f7-70d5-53d3313a56d1"), "Papua New Guinea", new DateTime(1983, 1, 1, 17, 38, 57, 771, DateTimeKind.Utc).AddTicks(7223), 631.422815651316000m, "Iliana89@yahoo.com", "Pamela", 1000m, 884, "Et perspiciatis.", "572-947-9816 x5890", "Krajcik" },
                    { new Guid("277c34f6-0c89-21f7-9256-2631f2e70bf6"), "Indonesia", new DateTime(2008, 9, 13, 18, 56, 15, 363, DateTimeKind.Utc).AddTicks(3341), 830.215732667686000m, "Leilani93@gmail.com", "Wava", 1000m, 95, "Est vero.", "1-978-783-6010", "Haag" },
                    { new Guid("27f87c42-33f7-d030-6919-d77df908728d"), "Zambia", new DateTime(1979, 11, 21, 20, 27, 55, 959, DateTimeKind.Utc).AddTicks(4356), 811.801519632889000m, "Clay_Gutmann5@hotmail.com", "Richard", 600m, 293, "Et esse.", "797.450.8395 x888", "Feest" },
                    { new Guid("28256165-3178-0ee1-5714-9a4f5762f6f4"), "Bosnia and Herzegovina", new DateTime(1980, 7, 25, 2, 25, 27, 294, DateTimeKind.Utc).AddTicks(1303), 252.888548053261000m, "Emelia_Reichert@hotmail.com", "Mikel", 1000m, 491, "Odio reiciendis.", "714-271-9687 x05260", "Kuvalis" },
                    { new Guid("28e7f848-5323-07ba-d80b-bafa966fcdc3"), "Burundi", new DateTime(1973, 4, 11, 5, 49, 4, 121, DateTimeKind.Utc).AddTicks(6776), 400.587580084673000m, "Marina_Blanda91@hotmail.com", "Dagmar", 900m, 283, "Vero est.", "987-996-8140", "Cruickshank" },
                    { new Guid("299a9555-0049-1f32-e690-9b3956867518"), "New Zealand", new DateTime(1928, 11, 19, 12, 7, 19, 463, DateTimeKind.Utc).AddTicks(7824), 886.369753631395000m, "Melody93@hotmail.com", "Breanne", 700m, 56, "Asperiores voluptas.", "627-331-2204 x9733", "Abernathy" },
                    { new Guid("29d45372-71b5-d72c-3309-b054a46afd2c"), "Georgia", new DateTime(1933, 5, 8, 4, 15, 22, 120, DateTimeKind.Utc).AddTicks(974), 32.4707065671472000m, "Carroll_Halvorson11@gmail.com", "Breana", 700m, 72, "Quasi atque.", "1-967-730-7497 x0547", "Reichel" },
                    { new Guid("29de16e0-1416-2f09-4f7e-06fd09178822"), "Uruguay", new DateTime(1989, 5, 19, 21, 41, 25, 428, DateTimeKind.Utc).AddTicks(35), 629.746321282973000m, "Cathy7@yahoo.com", "Chanel", 500m, 10, "Non rerum.", "1-713-361-0641 x8363", "Marquardt" },
                    { new Guid("2a2b2e37-4237-31da-5fa3-a4b781e4605c"), "Iceland", new DateTime(1932, 5, 22, 10, 6, 25, 981, DateTimeKind.Utc).AddTicks(5002), 456.146700594791000m, "Mack_Cummings@gmail.com", "Adelle", 600m, 33, "Quod nobis.", "402-325-3072 x48363", "Bernier" },
                    { new Guid("2a7ecb56-db25-2488-4fd3-959e7874f910"), "Egypt", new DateTime(1957, 1, 5, 11, 14, 5, 159, DateTimeKind.Utc).AddTicks(9726), 822.226949268155000m, "Elvera_Brakus@hotmail.com", "Favian", 900m, 271, "Dignissimos natus.", "(768) 384-1514", "Roberts" },
                    { new Guid("2abc4cbb-c010-3b18-509b-364b62a20fa8"), "Jersey", new DateTime(1937, 11, 11, 15, 10, 40, 315, DateTimeKind.Utc).AddTicks(1194), 664.675940760981000m, "Paolo41@hotmail.com", "Rudolph", 1000m, 712, "Laborum eligendi.", "(891) 429-1257", "Green" },
                    { new Guid("2afe2516-3af3-4e5c-a0e2-171286342119"), "Palestinian Territory", new DateTime(1985, 12, 16, 21, 3, 3, 595, DateTimeKind.Utc).AddTicks(9255), 375.9626999365000m, "Jonatan87@yahoo.com", "Raul", 1000m, 924, "Rerum hic.", "214-727-6007 x51058", "Purdy" },
                    { new Guid("2b208252-521b-787a-4211-3b54d3be429e"), "Palau", new DateTime(1988, 10, 25, 16, 49, 12, 725, DateTimeKind.Utc).AddTicks(9791), 975.786533518144000m, "Scot.Streich13@hotmail.com", "Myrtice", 900m, 665, "Iusto adipisci.", "(463) 601-3316 x2967", "Lockman" },
                    { new Guid("2b49267e-0fe2-6dd7-23d7-fb00ff7852df"), "Bahrain", new DateTime(1979, 9, 25, 18, 44, 48, 26, DateTimeKind.Utc).AddTicks(1740), 201.159642027507000m, "Missouri_Waelchi95@yahoo.com", "Marlene", 900m, 4, "Vero quos.", "(974) 429-1110 x794", "MacGyver" },
                    { new Guid("2b4bb993-7ad1-552d-853e-3a5b2d05fe10"), "Oman", new DateTime(1980, 5, 28, 18, 53, 30, 419, DateTimeKind.Utc).AddTicks(4978), 128.341204983524000m, "Amy.Schaefer54@yahoo.com", "Louisa", 900m, 574, "Consequuntur eos.", "(222) 831-0529 x917", "Schmidt" },
                    { new Guid("2ba9b243-794d-ff3f-d4d8-3573646de74c"), "Madagascar", new DateTime(2016, 4, 17, 3, 27, 9, 532, DateTimeKind.Utc).AddTicks(6449), 388.756820504263000m, "Geovanni_Botsford@hotmail.com", "Yasmine", 700m, 547, "Vel quo.", "(534) 579-8894", "Torp" },
                    { new Guid("2bb56234-4395-c5e9-b919-b38d8d4839ca"), "Argentina", new DateTime(1969, 11, 13, 7, 55, 53, 285, DateTimeKind.Utc).AddTicks(9513), 924.130004076451000m, "Levi.Grimes67@yahoo.com", "Deontae", 900m, 644, "Vel iste.", "1-936-726-7362 x877", "Toy" },
                    { new Guid("2bb8e333-4bb7-d016-bcba-049371805f84"), "Barbados", new DateTime(1947, 8, 14, 21, 53, 38, 516, DateTimeKind.Utc).AddTicks(3612), 626.390995917113000m, "Etha.Nicolas15@yahoo.com", "Rowland", 700m, 92, "Cupiditate aut.", "(764) 793-0899 x3382", "Morissette" },
                    { new Guid("2bbdceb2-1dee-1e20-a9a3-0e715738bc29"), "Malta", new DateTime(1947, 12, 28, 12, 32, 5, 389, DateTimeKind.Utc).AddTicks(7269), 587.837958137347000m, "Lue.Kilback96@gmail.com", "Shayna", 900m, 139, "Exercitationem rem.", "377.449.0514 x657", "Williamson" },
                    { new Guid("2c2f0ee1-dfd9-2ee2-a5c6-8bfd8dbd24bc"), "Belgium", new DateTime(2012, 8, 24, 15, 27, 19, 890, DateTimeKind.Utc).AddTicks(5576), 363.644209317927000m, "Veda_Ruecker5@yahoo.com", "Dane", 1000m, 767, "Doloribus vitae.", "(476) 542-5392", "Armstrong" },
                    { new Guid("2c41ff4d-4036-4f5c-92a0-6ccc270ec424"), "Serbia", new DateTime(2013, 3, 31, 7, 17, 31, 375, DateTimeKind.Utc).AddTicks(8213), 481.715144309364000m, "Sophia49@yahoo.com", "Sven", 900m, 672, "Necessitatibus at.", "(761) 806-9821 x8623", "Bergstrom" },
                    { new Guid("2c980578-2f1d-43f8-c93b-50fe7da682d0"), "Thailand", new DateTime(1960, 3, 11, 14, 58, 40, 797, DateTimeKind.Utc).AddTicks(9942), 571.976401574698000m, "Twila67@gmail.com", "Joey", 500m, 306, "Itaque sunt.", "(350) 891-0787", "Thiel" },
                    { new Guid("2cafdcb6-e324-f23c-78e7-76a98103c65f"), "Poland", new DateTime(1998, 4, 25, 18, 28, 38, 593, DateTimeKind.Utc).AddTicks(1241), 808.187147057534000m, "Larue.Johnston30@hotmail.com", "Narciso", 600m, 407, "Omnis ducimus.", "758-724-2264", "Labadie" },
                    { new Guid("2cd7bafe-499e-0e71-9728-2a2c93f87038"), "Nigeria", new DateTime(1979, 1, 5, 18, 12, 53, 626, DateTimeKind.Utc).AddTicks(1860), 284.624371815957000m, "Raphael_Breitenberg20@yahoo.com", "Greta", 500m, 472, "Nostrum mollitia.", "734-566-2395", "Boehm" },
                    { new Guid("2d09f2a7-7958-fd95-3143-8846651d3c31"), "Tokelau", new DateTime(1967, 12, 6, 14, 40, 44, 882, DateTimeKind.Utc).AddTicks(1866), 880.819959917775000m, "Trinity_Lueilwitz@hotmail.com", "Stephania", 700m, 682, "Deserunt doloribus.", "1-718-484-8004 x975", "Sawayn" },
                    { new Guid("2d53da1e-b331-a03c-65c7-b995cb79efaf"), "Palestinian Territory", new DateTime(1957, 2, 2, 11, 15, 35, 998, DateTimeKind.Utc).AddTicks(1414), 419.828327392237000m, "Allen.Donnelly@yahoo.com", "Donnie", 900m, 608, "Hic quibusdam.", "363.297.0013 x676", "Cartwright" },
                    { new Guid("2d5b5bcc-ee0c-2241-e941-cff5f6487989"), "Mayotte", new DateTime(2010, 11, 22, 20, 30, 57, 696, DateTimeKind.Utc).AddTicks(8293), 684.486416562299000m, "Estelle20@hotmail.com", "Celia", 800m, 384, "Voluptate laboriosam.", "(486) 457-0320", "Zemlak" },
                    { new Guid("2d6a6767-a9b6-4123-e4e8-9dec9954ecbd"), "Ukraine", new DateTime(1987, 4, 10, 10, 19, 49, 143, DateTimeKind.Utc).AddTicks(6473), 506.79640159623000m, "Emmett_Hammes25@yahoo.com", "Glennie", 600m, 648, "Nostrum quas.", "1-213-427-5671 x728", "Hand" },
                    { new Guid("2dfcdc96-14e5-aa0b-a2ab-b127ba79003a"), "Norfolk Island", new DateTime(1958, 8, 19, 3, 55, 6, 461, DateTimeKind.Utc).AddTicks(263), 30.7904611826142000m, "Vita.Hauck@yahoo.com", "Antonio", 800m, 87, "Perspiciatis nam.", "(367) 993-7858", "Kulas" },
                    { new Guid("2e636a3b-ad9f-0603-223f-050d4984229a"), "Kenya", new DateTime(2016, 1, 20, 22, 23, 39, 145, DateTimeKind.Utc).AddTicks(5616), 798.611965459069000m, "Quinten_Heathcote67@hotmail.com", "Sedrick", 800m, 251, "Nulla quod.", "1-833-256-9674", "Huels" },
                    { new Guid("2e7ab621-6806-a492-274e-b82ad16203ac"), "Congo", new DateTime(1990, 1, 22, 8, 29, 33, 965, DateTimeKind.Utc).AddTicks(2209), 195.924655830293000m, "Coty86@hotmail.com", "Fausto", 900m, 899, "Laborum nam.", "1-206-216-7179", "Dietrich" },
                    { new Guid("2e9ec634-4f66-b2ac-9585-bbeec45fec60"), "Palestinian Territory", new DateTime(2012, 4, 18, 12, 1, 41, 623, DateTimeKind.Utc).AddTicks(2602), 145.771882860975000m, "Alberta.Hermiston36@hotmail.com", "Genesis", 600m, 946, "Minus ea.", "(348) 410-9807 x2741", "Rolfson" },
                    { new Guid("2eb4780d-a4a7-fd58-cd1f-5723351ea405"), "Bouvet Island (Bouvetoya)", new DateTime(2016, 8, 21, 10, 20, 36, 395, DateTimeKind.Utc).AddTicks(9495), 534.657050804132000m, "Dave29@yahoo.com", "Jany", 600m, 713, "Esse officiis.", "742-787-6477 x802", "Gibson" },
                    { new Guid("2eedc64b-5189-6c0e-6a20-39e27e0570a0"), "Zimbabwe", new DateTime(1993, 2, 20, 2, 53, 35, 214, DateTimeKind.Utc).AddTicks(7786), 444.886412170772000m, "Alycia_Corkery@gmail.com", "Guy", 1000m, 905, "Rerum aut.", "750-208-0232", "Anderson" },
                    { new Guid("2f25dd73-5672-a52f-5e97-765d80e3b0cb"), "Sao Tome and Principe", new DateTime(1991, 4, 9, 4, 30, 50, 589, DateTimeKind.Utc).AddTicks(5017), 388.355527333413000m, "Conrad.Schinner94@gmail.com", "Ulices", 1000m, 777, "Dolores dolor.", "469-268-6868 x63014", "Pollich" },
                    { new Guid("2f4d2963-d06d-020a-dd0a-0de5af15748f"), "Albania", new DateTime(1951, 10, 4, 20, 59, 30, 722, DateTimeKind.Utc).AddTicks(1862), 934.388454077633000m, "Zackary.Welch76@gmail.com", "Iliana", 600m, 928, "Ut totam.", "(904) 843-3989", "Schimmel" },
                    { new Guid("2fca88c6-27e3-bac1-0116-22119cc849b4"), "Armenia", new DateTime(2009, 9, 27, 11, 21, 20, 352, DateTimeKind.Utc).AddTicks(9455), 690.079994117475000m, "Daphney.Kuvalis@hotmail.com", "Jason", 700m, 508, "Dolorum minima.", "1-331-472-3742 x6238", "Christiansen" },
                    { new Guid("2ff91bda-9d2a-8033-79a2-e66412ccc79d"), "Costa Rica", new DateTime(2020, 11, 19, 14, 24, 48, 401, DateTimeKind.Utc).AddTicks(5942), 227.540731485256000m, "Tyrique84@gmail.com", "Dewitt", 900m, 531, "Distinctio quam.", "530-571-5755 x662", "Durgan" },
                    { new Guid("3005ddf5-309e-97e6-1658-3b9da1dff27d"), "Canada", new DateTime(1985, 8, 7, 19, 7, 56, 941, DateTimeKind.Utc).AddTicks(3753), 721.737225419681000m, "Dominic9@yahoo.com", "Kaci", 800m, 752, "Harum eos.", "526.379.7070 x128", "Murray" },
                    { new Guid("303bfca7-ab7c-639a-1582-44daf380cdb3"), "Niger", new DateTime(1977, 3, 17, 18, 19, 38, 583, DateTimeKind.Utc).AddTicks(3738), 569.462862497576000m, "Evie.Bailey@gmail.com", "Dayton", 1000m, 804, "Temporibus aliquid.", "1-935-684-0427 x3487", "Walker" },
                    { new Guid("30d90617-4d37-92b9-e081-2fcf8fdd33fd"), "Finland", new DateTime(1948, 5, 9, 22, 41, 8, 646, DateTimeKind.Utc).AddTicks(4619), 510.617663926764000m, "Sandra_Bartoletti@hotmail.com", "Kylie", 600m, 342, "Ea vel.", "943-867-5302 x3664", "Quigley" },
                    { new Guid("30f78fc2-23c4-4acb-7cfa-ca381a33400b"), "Ghana", new DateTime(1963, 3, 2, 0, 17, 33, 216, DateTimeKind.Utc).AddTicks(7707), 941.019080119374000m, "Evelyn_Leuschke@gmail.com", "Alda", 1000m, 393, "Debitis cupiditate.", "(278) 471-3014 x3623", "Swaniawski" },
                    { new Guid("3120604c-b1cd-63c0-bc94-e39d09fbd97d"), "Italy", new DateTime(1936, 6, 30, 9, 19, 25, 584, DateTimeKind.Utc).AddTicks(4212), 100.276522471458000m, "Ross.Torphy@yahoo.com", "Major", 600m, 137, "Consequuntur architecto.", "1-864-397-2947", "Waelchi" },
                    { new Guid("31466db7-2819-35c8-b398-39e2fca95ac4"), "El Salvador", new DateTime(1993, 9, 2, 0, 56, 17, 783, DateTimeKind.Utc).AddTicks(7889), 245.251774404786000m, "Haylee.Schneider11@gmail.com", "Eunice", 600m, 227, "Itaque aut.", "966-719-2743", "Legros" },
                    { new Guid("31622965-18dc-dcad-9336-1d96b185de07"), "Ukraine", new DateTime(2021, 12, 26, 1, 32, 47, 451, DateTimeKind.Utc).AddTicks(7312), 373.028438247911000m, "Austyn.Champlin@hotmail.com", "Lennie", 800m, 800, "Et et.", "(690) 682-5513", "Blick" },
                    { new Guid("31e16dd2-d43f-143c-3ab2-cc6323d0a33a"), "Slovenia", new DateTime(1958, 12, 23, 2, 30, 30, 658, DateTimeKind.Utc).AddTicks(9776), 631.903047465017000m, "Demetris22@hotmail.com", "Clara", 500m, 873, "Repellat enim.", "1-274-897-8847 x2944", "Altenwerth" },
                    { new Guid("3223e0a3-c658-96af-139a-8920f94316f3"), "Virgin Islands, British", new DateTime(1987, 2, 18, 0, 21, 42, 45, DateTimeKind.Utc).AddTicks(9281), 934.461316396421000m, "Gudrun_Zieme55@yahoo.com", "Ellsworth", 900m, 966, "Nihil voluptas.", "1-211-747-0617 x3649", "Bins" },
                    { new Guid("325e09d9-f67c-f727-d55b-1cd1706843a9"), "Egypt", new DateTime(2015, 10, 7, 7, 32, 7, 184, DateTimeKind.Utc).AddTicks(1287), 802.925987429666000m, "Hollis.Larson14@yahoo.com", "Edison", 1000m, 292, "Esse voluptatibus.", "739.658.7775 x71322", "Pagac" },
                    { new Guid("32861c95-8387-7f83-3a57-80caa5049b83"), "Guinea-Bissau", new DateTime(1994, 10, 2, 5, 55, 52, 678, DateTimeKind.Utc).AddTicks(7490), 744.221323137236000m, "Joel23@gmail.com", "Clarabelle", 900m, 307, "Eos earum.", "361.974.1268 x25486", "Leuschke" },
                    { new Guid("328e4f68-08c6-e82f-2167-22a30385cdf0"), "Cape Verde", new DateTime(2002, 2, 2, 5, 3, 4, 539, DateTimeKind.Utc).AddTicks(1740), 503.895952429273000m, "Ally70@gmail.com", "Robb", 700m, 477, "Debitis quod.", "1-989-244-1824 x9485", "Boyle" },
                    { new Guid("329d4abb-e846-72cc-17e3-e357cfab7e5e"), "Western Sahara", new DateTime(2011, 1, 27, 2, 12, 53, 79, DateTimeKind.Utc).AddTicks(1229), 94.6240298572061000m, "Gussie.Pfeffer@yahoo.com", "Carson", 900m, 281, "Harum iusto.", "(790) 939-7443 x514", "Kuhn" },
                    { new Guid("3314001f-02e8-89c0-6c6d-9ad5aedae2a5"), "Falkland Islands (Malvinas)", new DateTime(2024, 4, 21, 8, 0, 14, 94, DateTimeKind.Utc).AddTicks(3482), 721.547092792982000m, "Olin_Daniel@hotmail.com", "Katrina", 700m, 1, "Harum id.", "217-590-4819", "Aufderhar" },
                    { new Guid("335c1190-c85c-c2da-d3a1-767ede859707"), "Norway", new DateTime(1936, 9, 5, 12, 10, 51, 333, DateTimeKind.Utc).AddTicks(955), 872.86067182459000m, "Denis32@yahoo.com", "Blaze", 700m, 503, "Quibusdam necessitatibus.", "979.521.8696", "Homenick" },
                    { new Guid("3390c3b6-b46d-1f2c-3207-2cef404feb2b"), "Greece", new DateTime(1968, 5, 28, 6, 5, 35, 583, DateTimeKind.Utc).AddTicks(1381), 655.222668226676000m, "Albert20@hotmail.com", "Brad", 700m, 394, "Est in.", "571-240-1294", "Gulgowski" },
                    { new Guid("33ce96a6-9d6c-3aec-3ae5-cbab52c4c21e"), "Ukraine", new DateTime(1938, 6, 30, 18, 56, 37, 49, DateTimeKind.Utc).AddTicks(8714), 908.342694909558000m, "Arnulfo_Considine71@gmail.com", "Samson", 500m, 442, "Tenetur nemo.", "1-678-600-1075 x438", "Fritsch" },
                    { new Guid("33d74ec4-b1f1-6997-f081-858f38b5efde"), "Luxembourg", new DateTime(2019, 12, 30, 13, 19, 31, 89, DateTimeKind.Utc).AddTicks(2950), 711.350382347794000m, "Antonette_Doyle29@yahoo.com", "Jarod", 800m, 456, "Perspiciatis illum.", "990-536-1412 x381", "Ortiz" },
                    { new Guid("33eb1825-2e2f-9802-1ef8-afb0f1f65ef6"), "Mexico", new DateTime(1938, 3, 18, 11, 26, 34, 393, DateTimeKind.Utc).AddTicks(2659), 393.952596212642000m, "Roscoe_Spencer45@gmail.com", "Frankie", 500m, 344, "Non consequatur.", "1-631-843-9262 x1818", "Carter" },
                    { new Guid("33f94973-abb8-3a2b-70db-78e47f307760"), "Virgin Islands, British", new DateTime(1981, 6, 18, 0, 33, 36, 987, DateTimeKind.Utc).AddTicks(7004), 891.407437337624000m, "Mireille_Johnston@hotmail.com", "Melany", 800m, 371, "Facilis dolorum.", "1-273-476-0226 x176", "Hayes" },
                    { new Guid("34201f6c-a7d8-f29e-8a99-36ab903d80b7"), "Saint Pierre and Miquelon", new DateTime(1949, 4, 30, 3, 1, 48, 206, DateTimeKind.Utc).AddTicks(8459), 864.201908684683000m, "John.Reichert@hotmail.com", "Cyril", 1000m, 553, "Quia pariatur.", "201-645-8421 x322", "Heidenreich" },
                    { new Guid("3449162d-9f82-21e5-64f0-f97b8faad38d"), "Fiji", new DateTime(2004, 3, 31, 15, 6, 0, 439, DateTimeKind.Utc).AddTicks(3217), 30.0451620499669000m, "Dawson_Upton4@hotmail.com", "Brendon", 600m, 171, "Voluptatibus laboriosam.", "886.964.2350 x6174", "Veum" },
                    { new Guid("344abde7-c31f-f966-d113-73e91a7c13e7"), "Belarus", new DateTime(1970, 11, 9, 19, 50, 23, 951, DateTimeKind.Utc).AddTicks(1344), 631.769825911403000m, "Karianne1@hotmail.com", "Libbie", 1000m, 756, "Dolore voluptas.", "(309) 524-9238 x5490", "Yundt" },
                    { new Guid("345538f8-2e90-5c1d-8632-18bf05eeaabd"), "Singapore", new DateTime(1959, 5, 18, 12, 2, 43, 205, DateTimeKind.Utc).AddTicks(9605), 38.3568940952514000m, "Halle97@yahoo.com", "Donnell", 500m, 308, "Esse nam.", "492-941-0649 x517", "Ziemann" },
                    { new Guid("346b925b-dcd2-9161-be90-618d998fcb2e"), "New Zealand", new DateTime(2014, 9, 8, 12, 23, 39, 380, DateTimeKind.Utc).AddTicks(6651), 911.550142550166000m, "Reyes_Murazik45@hotmail.com", "Rafael", 600m, 877, "Quam molestiae.", "1-674-805-8130", "Balistreri" },
                    { new Guid("346ff74a-b3c0-1164-79a3-214ab8197d63"), "Malaysia", new DateTime(2021, 12, 25, 13, 48, 38, 869, DateTimeKind.Utc).AddTicks(3350), 16.8121484205961000m, "Bertram44@yahoo.com", "Justice", 500m, 743, "Cumque fugiat.", "(255) 476-7737", "Deckow" },
                    { new Guid("3497dd38-c41e-ac79-952e-3e05bb8c00d5"), "Brazil", new DateTime(2008, 5, 3, 8, 3, 38, 717, DateTimeKind.Utc).AddTicks(895), 23.7785328930504000m, "Caitlyn56@gmail.com", "Keely", 1000m, 420, "Reprehenderit et.", "1-529-970-1516 x0042", "Hintz" },
                    { new Guid("35223fef-7098-2ae5-f0f0-cf3eb04c8afe"), "Christmas Island", new DateTime(2019, 1, 29, 20, 10, 36, 94, DateTimeKind.Utc).AddTicks(325), 50.6946624732981000m, "Nicole_Fritsch55@hotmail.com", "Enos", 500m, 666, "Et eveniet.", "(456) 824-6423", "Hand" },
                    { new Guid("3595c5e7-6770-0299-3ef5-7a24d9bfc3fe"), "Belarus", new DateTime(2023, 3, 5, 13, 5, 11, 562, DateTimeKind.Utc).AddTicks(9433), 422.022290613258000m, "Rhiannon.Bergstrom@hotmail.com", "Joanne", 500m, 916, "Adipisci dolores.", "325.826.0232 x2070", "Pagac" },
                    { new Guid("35a62308-5ba4-0eac-9de6-5e2b8e4c2b88"), "Ukraine", new DateTime(1952, 11, 9, 7, 57, 59, 121, DateTimeKind.Utc).AddTicks(4227), 994.890592874222000m, "Stevie_Gleichner22@gmail.com", "Cielo", 1000m, 856, "Qui eum.", "1-517-361-2275 x002", "Brekke" },
                    { new Guid("36053568-a612-77a6-45e2-210a548d5dee"), "Reunion", new DateTime(2005, 6, 26, 19, 59, 33, 117, DateTimeKind.Utc).AddTicks(377), 702.066603242139000m, "Anderson.Baumbach80@yahoo.com", "Denis", 500m, 596, "Enim ea.", "1-654-620-5057 x4785", "Brown" },
                    { new Guid("361e0454-3263-3134-89f1-cb6214d66f7d"), "New Caledonia", new DateTime(1987, 8, 3, 3, 9, 29, 870, DateTimeKind.Utc).AddTicks(790), 133.941128727334000m, "Brice.Haley46@gmail.com", "Hector", 900m, 861, "Incidunt nulla.", "610-670-8787 x7605", "Lueilwitz" },
                    { new Guid("36f95d15-545c-441c-be9f-4c16124ee573"), "Macao", new DateTime(1934, 7, 29, 12, 7, 23, 976, DateTimeKind.Utc).AddTicks(6682), 397.098206850745000m, "Bulah.Gulgowski@gmail.com", "Chaz", 900m, 419, "Sed quod.", "543-952-6948", "Nicolas" },
                    { new Guid("370544e5-a0cb-8383-6366-4fe45778b8de"), "Sweden", new DateTime(1927, 1, 7, 21, 33, 46, 190, DateTimeKind.Utc).AddTicks(8062), 357.85666305629000m, "Morton_Schulist@hotmail.com", "Aubree", 800m, 105, "Ipsa et.", "765.450.1343 x762", "Oberbrunner" },
                    { new Guid("371f532f-e1d2-eab5-4ac5-eaefefcf471b"), "France", new DateTime(1930, 5, 17, 6, 53, 9, 160, DateTimeKind.Utc).AddTicks(3566), 72.227788479087000m, "Jackson66@hotmail.com", "Wilford", 700m, 925, "Optio sed.", "1-617-216-8576 x1042", "Ryan" },
                    { new Guid("37fe84ea-04e2-5b2f-d10b-1a7fdbec1ba2"), "Isle of Man", new DateTime(2024, 2, 18, 0, 19, 55, 948, DateTimeKind.Utc).AddTicks(1291), 473.035492786517000m, "Opal.Jacobi32@gmail.com", "Elyse", 600m, 539, "Sed pariatur.", "992-290-0343 x22911", "Williamson" },
                    { new Guid("382eae1e-69f4-c7fa-92b0-b155fa83345c"), "Sao Tome and Principe", new DateTime(2024, 5, 31, 21, 7, 39, 659, DateTimeKind.Utc).AddTicks(4749), 648.064111255944000m, "Estrella.King@gmail.com", "Christop", 700m, 302, "Amet nostrum.", "1-623-536-3928", "Johnson" },
                    { new Guid("383756f5-7a82-7374-af75-73b66c7bc126"), "Heard Island and McDonald Islands", new DateTime(1941, 12, 29, 23, 12, 17, 835, DateTimeKind.Utc).AddTicks(4572), 743.310374722851000m, "Bonita_Bins45@hotmail.com", "Kristin", 700m, 29, "Doloremque autem.", "755-573-9708 x1199", "Reichert" },
                    { new Guid("386f5aa0-a48a-58c9-991d-774657ad3bd9"), "Micronesia", new DateTime(2011, 4, 20, 21, 31, 0, 691, DateTimeKind.Utc).AddTicks(8424), 785.323097159136000m, "Marcelo.Feeney@hotmail.com", "Efrain", 800m, 755, "Sunt rerum.", "(621) 910-5062 x1518", "Hayes" },
                    { new Guid("3887688d-2942-e084-b47f-fa1ed4f7599e"), "Austria", new DateTime(2003, 6, 20, 4, 11, 6, 457, DateTimeKind.Utc).AddTicks(4410), 731.476440549512000m, "Valentin3@gmail.com", "Vernice", 800m, 133, "Laudantium sed.", "1-248-949-9380 x440", "Ritchie" },
                    { new Guid("388faf58-78bd-1b2b-d13a-dfaa729f59c2"), "South Georgia and the South Sandwich Islands", new DateTime(1927, 11, 3, 20, 50, 35, 797, DateTimeKind.Utc).AddTicks(4222), 78.1557150298852000m, "Hallie_Gulgowski@hotmail.com", "Guillermo", 800m, 793, "Nam repellendus.", "1-344-324-3550", "O'Hara" },
                    { new Guid("38a19326-3935-77ea-c909-2ad7ef9b5453"), "Honduras", new DateTime(1944, 11, 4, 2, 9, 40, 753, DateTimeKind.Utc).AddTicks(1715), 61.0923162377088000m, "Cyrus_Mayer7@hotmail.com", "Treva", 700m, 993, "Amet aut.", "1-816-265-9906 x5612", "Rosenbaum" },
                    { new Guid("38ca94a1-5605-8789-269d-d398260d31b1"), "Christmas Island", new DateTime(2011, 12, 28, 8, 51, 14, 144, DateTimeKind.Utc).AddTicks(9177), 708.361479512549000m, "Chaim.DAmore@gmail.com", "Delpha", 600m, 12, "In quo.", "496-361-2472", "Harber" },
                    { new Guid("38d4597b-228c-3e37-4f3a-41f619b9bafb"), "Trinidad and Tobago", new DateTime(1984, 9, 22, 19, 56, 16, 286, DateTimeKind.Utc).AddTicks(9485), 357.975201251331000m, "Cade.Abbott@hotmail.com", "Bobby", 1000m, 990, "Inventore vel.", "230-511-3477 x82212", "Kessler" },
                    { new Guid("38db7e2f-8a54-a769-d2e9-4cf650b264be"), "Tanzania", new DateTime(1957, 11, 30, 16, 4, 33, 716, DateTimeKind.Utc).AddTicks(7904), 323.562396966922000m, "Alfonzo_Hane70@yahoo.com", "Harvey", 800m, 968, "Excepturi accusantium.", "854.802.9509 x8070", "Ebert" },
                    { new Guid("395ffffb-ec4c-0719-e8cb-f10c92471371"), "Angola", new DateTime(1993, 6, 2, 20, 50, 6, 926, DateTimeKind.Utc).AddTicks(7256), 868.062695816514000m, "Murphy.Deckow@yahoo.com", "Charlene", 800m, 614, "Ut molestiae.", "1-979-525-8808", "Dickens" },
                    { new Guid("398288be-1783-a165-8783-b9e9174391ac"), "Ecuador", new DateTime(1995, 9, 27, 4, 5, 42, 107, DateTimeKind.Utc).AddTicks(8876), 411.506541076885000m, "Myriam.Kautzer27@hotmail.com", "Gerry", 600m, 368, "Eveniet et.", "(387) 613-4034", "Reichert" },
                    { new Guid("3997dbaf-5f34-2f55-8fbf-578f2f31ee27"), "Tuvalu", new DateTime(1976, 1, 21, 21, 38, 52, 727, DateTimeKind.Utc).AddTicks(5586), 246.657745947747000m, "Geo96@gmail.com", "Jessy", 1000m, 917, "Et sunt.", "723-984-9917 x479", "Keeling" },
                    { new Guid("39cae5a3-6599-d7eb-0165-5f5fdca49796"), "Fiji", new DateTime(1944, 12, 16, 5, 4, 53, 123, DateTimeKind.Utc).AddTicks(2865), 701.482174815683000m, "Ferne.Haag65@yahoo.com", "Adriana", 700m, 374, "Quis voluptate.", "715.896.2884 x882", "Goodwin" },
                    { new Guid("3a6759ee-943d-6152-6903-dcb6395d1b20"), "Ethiopia", new DateTime(1999, 4, 19, 9, 15, 0, 482, DateTimeKind.Utc).AddTicks(1844), 570.231073290847000m, "Valentin_Oberbrunner77@yahoo.com", "Reid", 600m, 469, "Doloremque nobis.", "265-218-8758 x8154", "Hauck" },
                    { new Guid("3a7bf0fb-20f2-ef7d-1342-c867e99f0230"), "Guatemala", new DateTime(2003, 11, 17, 15, 42, 29, 552, DateTimeKind.Utc).AddTicks(1180), 122.505809011414000m, "Ludwig89@hotmail.com", "Mertie", 700m, 769, "Vitae ut.", "222.744.5697", "Ritchie" },
                    { new Guid("3a9ab21d-6975-3699-20b9-a12eaee7c58d"), "Lebanon", new DateTime(1989, 7, 9, 18, 37, 42, 265, DateTimeKind.Utc).AddTicks(436), 992.951638206992000m, "Orin.Dare70@yahoo.com", "Reece", 1000m, 59, "Laudantium architecto.", "636.905.3294 x24964", "Yundt" },
                    { new Guid("3aa3d476-ae37-b066-3874-3cf1d216c971"), "Germany", new DateTime(1989, 4, 21, 16, 51, 54, 822, DateTimeKind.Utc).AddTicks(1575), 957.079749542082000m, "Andrew76@hotmail.com", "Eleonore", 700m, 541, "Voluptas dolor.", "(386) 763-0304 x6130", "Welch" },
                    { new Guid("3ad7ca89-4ae7-4bc9-c8fd-73fa882a2b2c"), "Virgin Islands, British", new DateTime(1964, 12, 1, 5, 14, 0, 990, DateTimeKind.Utc).AddTicks(6166), 529.189245136684000m, "Alanna_Wehner96@hotmail.com", "Hertha", 500m, 727, "Voluptatem ullam.", "1-829-832-2857 x552", "Weber" },
                    { new Guid("3af1ecb9-32b0-78c3-dc29-522efe93b42e"), "Japan", new DateTime(1978, 4, 21, 17, 56, 58, 958, DateTimeKind.Utc).AddTicks(2424), 918.088140275203000m, "Serenity.Wisoky46@hotmail.com", "Nichole", 1000m, 603, "Facere expedita.", "371-773-0640", "Huel" },
                    { new Guid("3afae1fa-8a06-980a-85dc-96cf911846f3"), "Mali", new DateTime(1984, 9, 4, 5, 19, 54, 489, DateTimeKind.Utc).AddTicks(8051), 355.984633836676000m, "Ana.Robel59@hotmail.com", "Quinton", 1000m, 849, "Quisquam a.", "(464) 828-3691 x9624", "Wunsch" },
                    { new Guid("3bed5056-2571-2bf9-36cd-d6514977901f"), "Angola", new DateTime(1991, 9, 13, 11, 52, 23, 153, DateTimeKind.Utc).AddTicks(6487), 638.601203260939000m, "Kyla_Moen@hotmail.com", "Halle", 700m, 349, "Qui porro.", "(595) 886-5150", "Mann" },
                    { new Guid("3bf16a23-f417-deeb-553e-d442e9622927"), "Denmark", new DateTime(1940, 4, 23, 7, 7, 33, 399, DateTimeKind.Utc).AddTicks(6836), 645.743566709872000m, "Mariah23@yahoo.com", "Velma", 800m, 405, "Voluptatum nesciunt.", "1-374-305-5136 x2564", "Morissette" },
                    { new Guid("3c1db86c-0228-0a90-ddb8-ff96a12c8d3d"), "Samoa", new DateTime(2000, 11, 26, 2, 32, 57, 831, DateTimeKind.Utc).AddTicks(7853), 922.476353770939000m, "Nickolas.Graham62@hotmail.com", "Freddy", 800m, 736, "Ut praesentium.", "(653) 509-1537 x179", "Flatley" },
                    { new Guid("3c64ab8c-b9cd-89cd-1e21-b19abc5e6ce5"), "Algeria", new DateTime(2010, 4, 4, 2, 18, 3, 151, DateTimeKind.Utc).AddTicks(4780), 667.901732398026000m, "Rebekah_Larson15@yahoo.com", "Consuelo", 700m, 186, "Nobis ab.", "1-216-313-7214", "Schaefer" },
                    { new Guid("3c8289dc-e5e2-b0c7-3011-f740b1607476"), "Albania", new DateTime(1955, 5, 17, 7, 9, 11, 140, DateTimeKind.Utc).AddTicks(7256), 653.05570385233000m, "Davin51@gmail.com", "Adolfo", 1000m, 325, "Ut esse.", "1-827-917-1447 x616", "Schmidt" },
                    { new Guid("3c8453bd-6a80-2cad-cb4a-99ec72eddfd7"), "Maldives", new DateTime(1941, 6, 8, 2, 53, 50, 410, DateTimeKind.Utc).AddTicks(335), 236.112943816178000m, "Branson94@yahoo.com", "Afton", 900m, 24, "Sint rerum.", "892-250-6761", "Kshlerin" },
                    { new Guid("3c961091-196f-b3c3-0d6a-1db15a7802ac"), "Fiji", new DateTime(1968, 11, 13, 16, 31, 30, 517, DateTimeKind.Utc).AddTicks(4391), 445.967392511151000m, "Yasmine.Sporer@yahoo.com", "Paris", 900m, 691, "Et vel.", "822.462.7375 x06593", "Hagenes" },
                    { new Guid("3ca920fe-8475-390d-147a-ab86871cfb90"), "Norfolk Island", new DateTime(1947, 4, 14, 3, 35, 12, 826, DateTimeKind.Utc).AddTicks(6209), 410.547729270002000m, "Leo38@gmail.com", "Cameron", 800m, 676, "Eos laboriosam.", "(959) 938-8447 x119", "Schneider" },
                    { new Guid("3cdfa7fe-921c-58d9-baba-92861a281534"), "Belgium", new DateTime(1969, 1, 2, 1, 43, 31, 734, DateTimeKind.Utc).AddTicks(6880), 813.693974649432000m, "Laurine85@hotmail.com", "Kobe", 600m, 86, "Adipisci perspiciatis.", "1-737-766-5225 x6199", "Weimann" },
                    { new Guid("3d27cf9e-a08a-e431-27a9-520fe844d3fc"), "Monaco", new DateTime(1950, 2, 10, 8, 45, 6, 326, DateTimeKind.Utc).AddTicks(5299), 329.441404366025000m, "Kaia_Runolfsdottir@hotmail.com", "Bradly", 600m, 352, "Qui reiciendis.", "(678) 283-5115 x7548", "Jenkins" },
                    { new Guid("3da4c442-3269-a831-0dae-272f4163ca5e"), "Guyana", new DateTime(2000, 3, 1, 15, 59, 36, 662, DateTimeKind.Utc).AddTicks(3398), 204.38075016999000m, "Jarvis_Hintz@hotmail.com", "Delphine", 900m, 413, "Unde nesciunt.", "(360) 830-7630 x964", "Bednar" },
                    { new Guid("3e1fb220-b08d-5cfc-2a7b-4d0e31ce115d"), "Niue", new DateTime(1984, 9, 18, 1, 31, 12, 962, DateTimeKind.Utc).AddTicks(6797), 352.250053672791000m, "Keenan_Homenick@hotmail.com", "Hayley", 600m, 875, "Atque vel.", "386.273.1468", "McKenzie" },
                    { new Guid("3eed4eb8-b5e7-a3aa-26bc-c79fcdec711e"), "Lithuania", new DateTime(1966, 12, 28, 9, 6, 18, 577, DateTimeKind.Utc).AddTicks(5646), 260.669096231152000m, "Seth72@yahoo.com", "Elmore", 600m, 890, "Magnam dicta.", "1-828-743-7927 x8132", "Schumm" },
                    { new Guid("3ef6b628-84e3-67f3-7d3a-d256a4453c77"), "El Salvador", new DateTime(2021, 10, 25, 7, 52, 3, 825, DateTimeKind.Utc).AddTicks(1447), 902.44701203923000m, "Albina_Kiehn15@gmail.com", "Zora", 600m, 91, "Explicabo maxime.", "749.577.4757", "Kling" },
                    { new Guid("3ef8b365-1a4a-f290-5c7d-3249b8241ad9"), "Japan", new DateTime(2000, 6, 18, 4, 57, 6, 750, DateTimeKind.Utc).AddTicks(1015), 448.23646723395000m, "Ozella_Hauck58@hotmail.com", "Ward", 800m, 972, "Quis iure.", "(340) 908-6866", "Dietrich" },
                    { new Guid("3f3d0db2-db1c-4252-b7da-4e1f3044da5a"), "Zambia", new DateTime(1971, 8, 13, 14, 3, 20, 366, DateTimeKind.Utc).AddTicks(1942), 929.512183256808000m, "Lorenza1@gmail.com", "Isabella", 700m, 147, "Et quo.", "395-517-4976", "Funk" },
                    { new Guid("3f6e547e-95ae-aff3-8cc6-d2b964b649a4"), "Timor-Leste", new DateTime(1932, 6, 15, 9, 35, 14, 280, DateTimeKind.Utc).AddTicks(6437), 317.888930661485000m, "Carmelo.Lang@yahoo.com", "Bonnie", 700m, 791, "Omnis veniam.", "803.718.1253 x214", "Graham" },
                    { new Guid("3f819446-d686-dfbc-2afb-01e44ff81c39"), "British Indian Ocean Territory (Chagos Archipelago)", new DateTime(1937, 6, 14, 6, 53, 36, 504, DateTimeKind.Utc).AddTicks(5928), 353.199992024902000m, "Elda.Larson83@yahoo.com", "Ewell", 500m, 605, "Excepturi voluptatem.", "1-411-234-7020", "Gislason" },
                    { new Guid("3fe86a38-e26a-35b1-a5af-79c0b86f5610"), "Malta", new DateTime(1984, 9, 1, 14, 11, 40, 231, DateTimeKind.Utc).AddTicks(9192), 183.563886553925000m, "David.Schmidt64@hotmail.com", "Vicente", 1000m, 813, "Rerum blanditiis.", "1-788-983-9374 x519", "Pfeffer" },
                    { new Guid("40174214-6589-1317-8de5-ab674c12d56d"), "Bulgaria", new DateTime(1928, 6, 7, 19, 2, 12, 268, DateTimeKind.Utc).AddTicks(726), 145.681971930407000m, "Linwood.Wolff92@hotmail.com", "Walker", 500m, 821, "Repudiandae accusantium.", "1-871-686-8885", "Hettinger" },
                    { new Guid("406a6865-51a9-c962-a35c-6dde07260f05"), "Lao People's Democratic Republic", new DateTime(1932, 3, 21, 19, 54, 34, 844, DateTimeKind.Utc).AddTicks(1472), 931.392756021069000m, "Joana18@hotmail.com", "Sterling", 600m, 461, "Quis asperiores.", "237-847-0875", "Jerde" },
                    { new Guid("40952757-19fc-ee67-cf63-d87a0ea1c411"), "Georgia", new DateTime(1972, 3, 5, 12, 30, 30, 265, DateTimeKind.Utc).AddTicks(5571), 236.93478609353000m, "Katheryn72@gmail.com", "Amani", 600m, 193, "Et nostrum.", "1-681-372-3955", "Nicolas" },
                    { new Guid("409a14ec-3660-09dc-8a32-202199e3334b"), "Virgin Islands, British", new DateTime(1936, 7, 6, 16, 2, 1, 622, DateTimeKind.Utc).AddTicks(7389), 5.73070489335137000m, "Reymundo61@gmail.com", "Maritza", 1000m, 494, "Doloremque sit.", "939-910-7534", "Davis" },
                    { new Guid("40c60e1c-4c2b-21a3-8a77-ebdf9a616a7d"), "Venezuela", new DateTime(1950, 2, 26, 22, 14, 39, 458, DateTimeKind.Utc).AddTicks(9917), 62.8552808957249000m, "Morris.Brekke12@gmail.com", "Palma", 800m, 447, "Repellat fugiat.", "(581) 956-7545 x3339", "Beer" },
                    { new Guid("40d12b3e-7e9c-39e2-68a7-d75bebb9b536"), "Vanuatu", new DateTime(1958, 12, 6, 17, 19, 3, 657, DateTimeKind.Utc).AddTicks(7165), 367.794159080761000m, "Mozell27@gmail.com", "Thad", 800m, 6, "Voluptas voluptate.", "966.826.2098 x151", "Auer" },
                    { new Guid("410e7466-43f1-159a-fbed-1db3271e05ca"), "Republic of Korea", new DateTime(1993, 2, 3, 21, 18, 14, 975, DateTimeKind.Utc).AddTicks(6968), 854.023571383015000m, "Evalyn83@yahoo.com", "Noble", 900m, 483, "Inventore accusamus.", "642.343.5342 x03094", "Mayer" },
                    { new Guid("41275a9f-cb55-1b4a-84c3-cf0d5aa8f81c"), "Cayman Islands", new DateTime(1934, 12, 29, 4, 9, 34, 367, DateTimeKind.Utc).AddTicks(900), 965.994018871629000m, "Zoe_Windler@gmail.com", "Rylee", 900m, 106, "Fugit et.", "1-481-845-2840", "Nicolas" },
                    { new Guid("4132e2e6-f51e-1b6b-6b35-159fc2ada9e1"), "Taiwan", new DateTime(1965, 8, 2, 17, 4, 56, 166, DateTimeKind.Utc).AddTicks(6194), 653.247120693632000m, "Aurelie_Gulgowski32@gmail.com", "Assunta", 1000m, 259, "Repellendus voluptatem.", "(322) 822-8047 x827", "Greenholt" },
                    { new Guid("419d83de-edac-8079-144c-e3f0356c57c5"), "Taiwan", new DateTime(1944, 2, 19, 1, 34, 35, 200, DateTimeKind.Utc).AddTicks(1159), 98.8560037378787000m, "Seth_Upton@gmail.com", "Assunta", 1000m, 977, "Voluptatem ex.", "926-783-7088 x6420", "Langworth" },
                    { new Guid("41cadbe9-6b42-f797-0254-edcdd72acf8d"), "Niger", new DateTime(2000, 11, 6, 4, 55, 46, 662, DateTimeKind.Utc).AddTicks(6533), 544.297958421725000m, "Ericka89@hotmail.com", "Hazel", 600m, 220, "Aut veniam.", "1-426-369-8141 x6220", "Murphy" },
                    { new Guid("41dfab9a-f0db-9aa8-40b9-528ef84733c1"), "Eritrea", new DateTime(1936, 7, 4, 10, 33, 2, 115, DateTimeKind.Utc).AddTicks(5335), 65.1880656740411000m, "Cordelia61@gmail.com", "Jasmin", 700m, 487, "Dolore laborum.", "337-455-2082 x292", "Abbott" },
                    { new Guid("41f3a865-3865-2f3f-38f5-873dc61acfaa"), "Malta", new DateTime(1931, 5, 8, 9, 2, 43, 895, DateTimeKind.Utc).AddTicks(8351), 540.296290872111000m, "Aileen.Kilback45@gmail.com", "Katharina", 800m, 9, "Dignissimos vero.", "1-875-718-0990", "Wolf" },
                    { new Guid("42251f30-0f2f-b8d3-f220-6fb63c363556"), "Spain", new DateTime(2009, 9, 18, 0, 34, 59, 327, DateTimeKind.Utc).AddTicks(2642), 216.336079724593000m, "Domenica.Jacobson18@gmail.com", "Kale", 800m, 616, "Assumenda rerum.", "(754) 588-2116 x735", "Luettgen" },
                    { new Guid("4260ca98-9f3b-c196-988f-ab6b09c69ba4"), "French Southern Territories", new DateTime(2024, 2, 5, 9, 21, 1, 530, DateTimeKind.Utc).AddTicks(2859), 686.986014937072000m, "Hanna_Legros@gmail.com", "Dalton", 800m, 305, "Sit est.", "1-485-485-7028 x351", "Mills" },
                    { new Guid("428fa322-065c-b98a-f7b3-9432c4936e56"), "Colombia", new DateTime(1991, 11, 13, 17, 42, 35, 586, DateTimeKind.Utc).AddTicks(8046), 7.50055406015981000m, "Marc_Daniel96@hotmail.com", "Maxine", 900m, 906, "Ducimus iure.", "1-281-468-7483 x9154", "Wehner" },
                    { new Guid("4294076c-bd30-2d53-2c2e-9569cd04d2cd"), "Nigeria", new DateTime(2006, 3, 28, 15, 43, 1, 937, DateTimeKind.Utc).AddTicks(4708), 551.661350021624000m, "Clara_Schmidt@hotmail.com", "Haylee", 700m, 602, "Aliquid vel.", "(903) 217-2078", "Daugherty" },
                    { new Guid("42d090f7-aaad-e6dc-50d8-269be5d9cc54"), "Poland", new DateTime(1989, 3, 1, 2, 14, 20, 718, DateTimeKind.Utc).AddTicks(155), 738.359701636486000m, "Pearlie.Hoppe@yahoo.com", "Quinton", 900m, 578, "Vel quia.", "765.706.6200", "Schmidt" },
                    { new Guid("4322a1fc-65c1-5dcd-386e-b97a3e3345a9"), "Poland", new DateTime(2003, 9, 20, 21, 28, 55, 927, DateTimeKind.Utc).AddTicks(2001), 840.633242336727000m, "Eudora_Rodriguez50@hotmail.com", "Deonte", 800m, 764, "Est sunt.", "814.550.2774 x8902", "Collins" },
                    { new Guid("4335a818-82c5-10bc-60ae-b66ef1c7fbe4"), "Dominican Republic", new DateTime(1959, 7, 20, 15, 6, 28, 64, DateTimeKind.Utc).AddTicks(3049), 192.176252631894000m, "Coy_Corkery@yahoo.com", "Krista", 900m, 428, "Est incidunt.", "672.408.6080 x156", "Kutch" },
                    { new Guid("43401dca-6950-dba0-f64e-3feec0f5c533"), "Georgia", new DateTime(1982, 3, 10, 17, 44, 56, 907, DateTimeKind.Utc).AddTicks(8239), 340.698704225311000m, "Freddy12@gmail.com", "Yessenia", 800m, 935, "Quia facilis.", "370.209.0213", "Schuster" },
                    { new Guid("43433227-cf43-d6c5-11e5-5906f91403cf"), "Cape Verde", new DateTime(1938, 6, 10, 18, 40, 11, 947, DateTimeKind.Utc).AddTicks(8075), 493.803897990699000m, "Willow96@yahoo.com", "Delia", 800m, 351, "Iste dignissimos.", "437-657-4431 x353", "Bogan" },
                    { new Guid("4349064e-e657-f3f6-42db-08a57d474a99"), "Malawi", new DateTime(1959, 12, 21, 8, 43, 41, 333, DateTimeKind.Utc).AddTicks(9707), 130.717847875026000m, "Emilia2@gmail.com", "Newell", 900m, 538, "Nesciunt nobis.", "1-988-717-5292", "Bartoletti" },
                    { new Guid("435a95f6-143f-e99a-a0b7-a260b48c19be"), "Saint Kitts and Nevis", new DateTime(1979, 3, 3, 6, 33, 11, 238, DateTimeKind.Utc).AddTicks(3047), 914.703286275279000m, "Opal_Howe@gmail.com", "Carolanne", 500m, 826, "Aut error.", "1-904-233-3636 x791", "Goldner" },
                    { new Guid("436c9787-e3e3-2d8f-62ba-096d743222d9"), "United States Minor Outlying Islands", new DateTime(1959, 1, 22, 10, 18, 46, 844, DateTimeKind.Utc).AddTicks(3611), 38.0210646351121000m, "Alexandrea_Jacobs93@gmail.com", "Elouise", 1000m, 104, "In tempora.", "332-687-1528", "Torphy" },
                    { new Guid("43ea3535-c1ae-bc59-7221-563467ea4f3a"), "Belgium", new DateTime(1992, 6, 28, 6, 22, 57, 667, DateTimeKind.Utc).AddTicks(7760), 978.601479236575000m, "Maximillia.Mayer54@yahoo.com", "Amir", 500m, 941, "Eum eum.", "768-600-6920 x81854", "Zboncak" },
                    { new Guid("44058857-8ef3-2219-6b3e-d78be1ac1e87"), "Somalia", new DateTime(1987, 10, 21, 4, 30, 46, 398, DateTimeKind.Utc).AddTicks(9414), 706.524660523572000m, "Jayne_Armstrong7@yahoo.com", "Ludie", 600m, 721, "Quia ducimus.", "(443) 596-8913 x634", "Rutherford" },
                    { new Guid("4457399a-f2a6-53f9-a616-875406aa0c25"), "Mauritania", new DateTime(2018, 7, 30, 9, 59, 38, 454, DateTimeKind.Utc).AddTicks(8924), 240.448821992858000m, "Monserrate.McClure77@hotmail.com", "Mittie", 500m, 103, "Voluptate in.", "1-690-390-8436 x7612", "Schmeler" },
                    { new Guid("447efbb9-3964-bd8c-2bc5-d4e3719f48f9"), "Iran", new DateTime(2001, 4, 23, 18, 7, 59, 686, DateTimeKind.Utc).AddTicks(9031), 830.594976012459000m, "Antonina.Schiller@gmail.com", "Macy", 1000m, 557, "Tenetur repudiandae.", "1-664-697-7801 x775", "Yost" },
                    { new Guid("4522463e-562c-d3c2-bfa0-d337f08566c6"), "Western Sahara", new DateTime(2023, 1, 15, 9, 2, 36, 289, DateTimeKind.Utc).AddTicks(8704), 155.195339429729000m, "Hildegard.Lang@gmail.com", "Nikolas", 700m, 681, "Qui dolores.", "1-710-223-7518 x9840", "Pacocha" },
                    { new Guid("45be9a16-8914-e206-a682-43a418d3dee4"), "Cuba", new DateTime(2006, 4, 25, 23, 21, 53, 360, DateTimeKind.Utc).AddTicks(506), 951.220105653895000m, "Emma67@hotmail.com", "Francis", 500m, 792, "Recusandae ut.", "(974) 824-4451", "Heaney" },
                    { new Guid("464d59a4-4e95-bce6-1047-ad1d82990915"), "Azerbaijan", new DateTime(2001, 4, 30, 6, 3, 35, 111, DateTimeKind.Utc).AddTicks(9871), 241.98705955134000m, "Amina.Von51@gmail.com", "Rozella", 1000m, 303, "Ducimus repellendus.", "794-241-0104 x7770", "Fahey" },
                    { new Guid("46e5da3b-3061-e490-4208-4eee20d93437"), "Guyana", new DateTime(1942, 12, 10, 19, 7, 53, 410, DateTimeKind.Utc).AddTicks(1083), 117.547470729947000m, "Ike43@yahoo.com", "Annamarie", 900m, 668, "Quia saepe.", "(830) 491-3424 x9342", "Feest" },
                    { new Guid("470c6f01-db69-c377-fec2-f47fd53dfbac"), "Sierra Leone", new DateTime(1925, 10, 18, 13, 34, 45, 947, DateTimeKind.Utc).AddTicks(5398), 903.34910333887000m, "Jean.Altenwerth@hotmail.com", "Jocelyn", 700m, 960, "Rerum qui.", "295-297-4962 x2181", "Windler" },
                    { new Guid("4727d4d7-3b85-d3f5-040c-ddf943c2c80c"), "Papua New Guinea", new DateTime(1990, 10, 28, 19, 2, 41, 432, DateTimeKind.Utc).AddTicks(873), 745.46493711692000m, "Sherman_Purdy98@hotmail.com", "Liam", 1000m, 545, "Quia commodi.", "230-706-5920", "Becker" },
                    { new Guid("477a986e-142b-271d-a98b-ac7628806db4"), "Christmas Island", new DateTime(1972, 5, 1, 0, 22, 38, 578, DateTimeKind.Utc).AddTicks(89), 328.051318273906000m, "Delphine64@gmail.com", "Sister", 500m, 587, "At rerum.", "1-604-300-4358", "Von" },
                    { new Guid("4801d579-9aa4-052b-682d-874f339bc971"), "Malaysia", new DateTime(1979, 6, 2, 10, 12, 57, 959, DateTimeKind.Utc).AddTicks(5237), 496.559978635035000m, "Alfonzo18@gmail.com", "Judge", 1000m, 264, "Temporibus distinctio.", "468.846.0680 x7770", "Larson" },
                    { new Guid("48309199-4db9-338b-1a61-abb3f7beeb68"), "Bouvet Island (Bouvetoya)", new DateTime(1937, 11, 8, 19, 6, 2, 654, DateTimeKind.Utc).AddTicks(2227), 141.466909086405000m, "Letha_Klocko@gmail.com", "Stacy", 700m, 109, "Est doloribus.", "1-220-747-0534 x4719", "Herzog" },
                    { new Guid("483cd2e2-dbca-8005-442e-f5f273c20e13"), "Latvia", new DateTime(2013, 10, 31, 12, 25, 58, 737, DateTimeKind.Utc).AddTicks(7790), 745.119159144442000m, "Nina_Hyatt47@gmail.com", "Felix", 500m, 66, "Nihil nulla.", "716.309.5909", "Kuhic" },
                    { new Guid("487c1352-0c2c-077c-ba2d-9f0b7f54d569"), "Solomon Islands", new DateTime(1943, 6, 28, 13, 34, 50, 283, DateTimeKind.Utc).AddTicks(8026), 195.616479415353000m, "Florine78@gmail.com", "Opal", 800m, 327, "Debitis exercitationem.", "618-948-8841 x11486", "Wyman" },
                    { new Guid("490da1c7-7c09-f186-6c9f-9719e01adab2"), "Peru", new DateTime(2024, 9, 10, 15, 47, 4, 700, DateTimeKind.Utc).AddTicks(419), 113.684328782157000m, "Yvette_Kuphal@yahoo.com", "Alek", 500m, 973, "Illum non.", "609-695-8337 x7833", "Harvey" },
                    { new Guid("491d5bd8-25d1-824a-855f-f82137f013a5"), "Lebanon", new DateTime(1960, 11, 29, 13, 42, 56, 802, DateTimeKind.Utc).AddTicks(8903), 386.938313389113000m, "Maxine.Kovacek63@yahoo.com", "Marcelle", 1000m, 443, "Ullam dolores.", "603.338.3227 x54098", "Aufderhar" },
                    { new Guid("493d8bcb-6788-55e9-0d2a-d0c1332a279f"), "Svalbard & Jan Mayen Islands", new DateTime(2017, 4, 28, 19, 8, 15, 288, DateTimeKind.Utc).AddTicks(4733), 538.731453768968000m, "Reyna25@gmail.com", "Cortez", 1000m, 184, "Eos odit.", "1-713-285-9969 x6343", "Pollich" },
                    { new Guid("494055d9-71ea-9680-ff36-774733342aac"), "Gabon", new DateTime(1984, 7, 30, 6, 54, 46, 438, DateTimeKind.Utc).AddTicks(5231), 90.315268950946000m, "Vinnie.Satterfield28@hotmail.com", "Florida", 900m, 664, "Accusamus rerum.", "1-765-717-0459", "Botsford" },
                    { new Guid("4945fe91-8e6e-5afb-ed79-2a1bbfcf5e25"), "Norway", new DateTime(1986, 9, 7, 2, 47, 0, 555, DateTimeKind.Utc).AddTicks(7574), 113.815081818855000m, "Jaylon_Reynolds@gmail.com", "Jevon", 800m, 933, "Aut cum.", "667-577-7075 x561", "Gleason" },
                    { new Guid("498e0191-4c6e-d990-c544-b78a54b2fec8"), "United Kingdom", new DateTime(2005, 4, 1, 19, 17, 2, 179, DateTimeKind.Utc).AddTicks(7386), 369.459283630652000m, "Elna.Lang@yahoo.com", "Frederic", 800m, 511, "Sit rerum.", "1-640-495-9218 x5487", "McLaughlin" },
                    { new Guid("49b8ffe2-deda-f1ca-4c36-24126edc9182"), "Dominican Republic", new DateTime(1946, 10, 14, 21, 5, 31, 269, DateTimeKind.Utc).AddTicks(7157), 409.751708322738000m, "Rogelio.Roberts@hotmail.com", "Frieda", 500m, 88, "Aspernatur est.", "(843) 408-5792 x835", "Fritsch" },
                    { new Guid("49cfe21b-7918-df1d-7c53-ed434d59d3ea"), "Cameroon", new DateTime(1931, 8, 5, 18, 2, 11, 935, DateTimeKind.Utc).AddTicks(1990), 709.410588174378000m, "Elias.Jakubowski@yahoo.com", "Haleigh", 700m, 437, "Possimus nulla.", "707.692.1242", "Pouros" },
                    { new Guid("49f0aa8d-1e4b-200e-0149-a7d0e01a7b5c"), "Mali", new DateTime(2016, 12, 15, 3, 39, 42, 422, DateTimeKind.Utc).AddTicks(7176), 449.341318356503000m, "Dorothea_Cassin@hotmail.com", "Mossie", 700m, 357, "Rerum voluptatum.", "1-486-712-7065 x0882", "Lind" },
                    { new Guid("4a120d65-1afd-c14e-9156-3c4c213afc16"), "Eritrea", new DateTime(2001, 12, 19, 11, 2, 14, 577, DateTimeKind.Utc).AddTicks(4200), 713.597753340699000m, "Amanda.Bahringer97@yahoo.com", "Celine", 500m, 470, "Excepturi sint.", "(647) 485-4545 x436", "O'Conner" },
                    { new Guid("4a2ddfaa-cfdf-671d-b74f-e8f4ab65ca1a"), "British Indian Ocean Territory (Chagos Archipelago)", new DateTime(1964, 7, 10, 15, 25, 39, 38, DateTimeKind.Utc).AddTicks(2077), 446.694459724512000m, "Demetrius.Ledner@yahoo.com", "Stacey", 600m, 312, "Itaque autem.", "(683) 904-1240 x4573", "Crona" },
                    { new Guid("4a99e866-1041-7a61-efb7-0711c4328678"), "Grenada", new DateTime(1975, 9, 10, 21, 56, 51, 374, DateTimeKind.Utc).AddTicks(5568), 418.611679550213000m, "Trycia_Hickle94@gmail.com", "Santina", 800m, 161, "Rerum necessitatibus.", "(831) 230-2850 x2674", "Conroy" },
                    { new Guid("4ab82cb3-3af7-c939-fe9f-520a46fc2777"), "Austria", new DateTime(1981, 1, 18, 3, 30, 56, 504, DateTimeKind.Utc).AddTicks(7577), 88.964091659168000m, "Georgette_Hodkiewicz94@hotmail.com", "Skye", 1000m, 311, "Aut perspiciatis.", "1-866-741-6585 x2586", "Crooks" },
                    { new Guid("4abc2b9b-5d50-0843-07b8-3385719a1115"), "Turkey", new DateTime(1946, 11, 27, 2, 39, 42, 500, DateTimeKind.Utc).AddTicks(4139), 135.242402631559000m, "Helene52@gmail.com", "Marianne", 800m, 57, "Non impedit.", "816.894.3916 x7482", "Wilderman" },
                    { new Guid("4b77c489-0fab-af68-36a0-02349b7e2b86"), "Ukraine", new DateTime(1937, 12, 13, 11, 32, 34, 658, DateTimeKind.Utc).AddTicks(8049), 826.489531227266000m, "Shaylee91@yahoo.com", "Alison", 1000m, 569, "Dicta totam.", "(848) 225-7780 x8548", "Dickens" },
                    { new Guid("4b7bbae8-1f2d-c4bc-9734-9fb4a18d1514"), "Denmark", new DateTime(1940, 2, 19, 20, 32, 9, 782, DateTimeKind.Utc).AddTicks(1646), 243.577201639394000m, "Diamond.Nikolaus34@yahoo.com", "Martina", 700m, 346, "Nobis excepturi.", "(419) 432-1323 x824", "O'Conner" },
                    { new Guid("4c5a762c-16e8-63ef-e301-e8ebf9de3ecd"), "Saudi Arabia", new DateTime(1973, 11, 7, 15, 12, 59, 124, DateTimeKind.Utc).AddTicks(6972), 434.995213683742000m, "Garry42@hotmail.com", "Andy", 1000m, 463, "Quaerat provident.", "288.347.7909", "Bashirian" },
                    { new Guid("4cb7c202-cb62-3216-501f-2b4c22003e88"), "Kiribati", new DateTime(1940, 12, 7, 16, 35, 14, 544, DateTimeKind.Utc).AddTicks(359), 85.586563919013000m, "Zachery86@gmail.com", "Marlon", 800m, 136, "Repellendus inventore.", "304.351.0010 x234", "Roob" },
                    { new Guid("4cbbb1f8-57f8-e9ff-e21e-7ca999b3e053"), "Central African Republic", new DateTime(1938, 10, 13, 19, 12, 17, 638, DateTimeKind.Utc).AddTicks(3615), 718.119704252106000m, "Roberta.Sauer@gmail.com", "Frankie", 600m, 573, "Molestias velit.", "385.464.1043 x5180", "Sanford" },
                    { new Guid("4d448b4a-8901-d397-9214-1bcf07d7ebbe"), "Rwanda", new DateTime(2020, 4, 2, 8, 51, 47, 613, DateTimeKind.Utc).AddTicks(5950), 664.040321589268000m, "Josie.Breitenberg@gmail.com", "Elinore", 600m, 143, "Id impedit.", "321-982-8979", "Christiansen" },
                    { new Guid("4dab3f8c-cde3-e3ce-c537-eb1807059bfc"), "Western Sahara", new DateTime(1964, 1, 14, 20, 52, 12, 334, DateTimeKind.Utc).AddTicks(7406), 899.166972898982000m, "Florence_Zemlak57@yahoo.com", "Terrill", 800m, 929, "Et sunt.", "(862) 731-2740 x1836", "Blick" },
                    { new Guid("4de2f340-0ecd-1356-95fe-6df2809d173a"), "Nepal", new DateTime(1940, 7, 20, 17, 30, 12, 231, DateTimeKind.Utc).AddTicks(9783), 459.222363872932000m, "Stuart_Rolfson61@yahoo.com", "Malcolm", 500m, 479, "Ex aut.", "(925) 767-2712 x902", "Christiansen" },
                    { new Guid("4e00c0e0-77b8-22be-c7cf-c5b610041551"), "Bolivia", new DateTime(1967, 7, 21, 17, 25, 49, 402, DateTimeKind.Utc).AddTicks(4797), 60.9572250577466000m, "Rowena.Ritchie@yahoo.com", "Alivia", 800m, 111, "Molestiae necessitatibus.", "(743) 893-4637 x821", "Bashirian" },
                    { new Guid("4e06894a-bbeb-b732-73bc-e33188047d98"), "Saint Kitts and Nevis", new DateTime(2001, 6, 1, 22, 18, 37, 443, DateTimeKind.Utc).AddTicks(3146), 46.2818853317456000m, "Kennedy_Kertzmann90@gmail.com", "Dedrick", 600m, 908, "Sed sit.", "(967) 737-0152", "Crona" },
                    { new Guid("4e12b3ca-1b34-8f8b-9d22-32ee24a85d3f"), "Romania", new DateTime(1930, 8, 7, 16, 59, 55, 388, DateTimeKind.Utc).AddTicks(2453), 550.237365659384000m, "Boyd_Rosenbaum@hotmail.com", "Kenton", 1000m, 347, "Ea consequatur.", "(553) 597-5968", "Kozey" },
                    { new Guid("4e6c7075-00b6-1f11-b8e4-103673a7cb0a"), "Central African Republic", new DateTime(2012, 8, 6, 19, 36, 30, 909, DateTimeKind.Utc).AddTicks(7700), 702.847966284552000m, "Rosa_Grimes57@yahoo.com", "Gerda", 800m, 735, "Corporis aliquam.", "1-561-648-8574 x3149", "Prosacco" },
                    { new Guid("4e7a6929-fee9-35e5-7eff-e1b6a4a15e71"), "Antigua and Barbuda", new DateTime(1989, 10, 2, 22, 6, 47, 757, DateTimeKind.Utc).AddTicks(1319), 819.997197246946000m, "Kayla.Keebler@yahoo.com", "Nicholas", 600m, 202, "Saepe at.", "1-468-841-9093 x1175", "Paucek" },
                    { new Guid("4ecfd8a1-1d4a-789d-7756-8e7be28a2365"), "Iran", new DateTime(1983, 7, 28, 21, 36, 50, 486, DateTimeKind.Utc).AddTicks(2332), 576.724451050498000m, "Luigi89@yahoo.com", "Alfred", 500m, 750, "Placeat velit.", "599.297.4960", "Medhurst" },
                    { new Guid("4f14159d-986f-c32f-a90a-c18d9f8c715e"), "Thailand", new DateTime(1933, 6, 10, 19, 41, 7, 384, DateTimeKind.Utc).AddTicks(6182), 389.838017983156000m, "Omari.Stroman@hotmail.com", "Alessia", 500m, 348, "Aliquam illo.", "316-718-2322", "Lakin" },
                    { new Guid("4f1da4c5-d31c-c449-6297-dcca6aec2425"), "Antarctica (the territory South of 60 deg S)", new DateTime(2011, 10, 19, 4, 30, 56, 985, DateTimeKind.Utc).AddTicks(2193), 498.981297127565000m, "Quentin16@gmail.com", "Roberta", 500m, 492, "Ex sed.", "452-528-8608 x767", "Emmerich" },
                    { new Guid("4f29d8fb-1e3c-c8bf-f619-0205d02bc2aa"), "South Georgia and the South Sandwich Islands", new DateTime(1929, 3, 29, 22, 11, 4, 251, DateTimeKind.Utc).AddTicks(5972), 237.555133548254000m, "Chance58@hotmail.com", "Jaquelin", 1000m, 984, "Qui labore.", "(404) 875-7100 x1043", "Bosco" },
                    { new Guid("4fcd4e53-5f14-6a4f-1710-78f577970136"), "Cape Verde", new DateTime(2012, 10, 3, 11, 6, 3, 708, DateTimeKind.Utc).AddTicks(4458), 82.1396193484378000m, "Elaina.Pouros0@hotmail.com", "Manley", 800m, 155, "Quo minus.", "1-444-604-0652", "Schroeder" },
                    { new Guid("5059d37f-8bce-9c2a-ca7c-298a2f707375"), "Monaco", new DateTime(2022, 11, 23, 6, 47, 49, 931, DateTimeKind.Utc).AddTicks(2499), 884.559466757698000m, "Maxie_Parisian83@gmail.com", "Laney", 800m, 51, "Quidem quis.", "(640) 769-7065 x9860", "Ernser" },
                    { new Guid("51bb9f6e-d907-c61f-45d5-0ad1b268610b"), "Romania", new DateTime(1928, 11, 9, 4, 5, 11, 619, DateTimeKind.Utc).AddTicks(342), 977.406182226976000m, "Arielle64@gmail.com", "Ken", 500m, 387, "Sunt quo.", "1-267-950-0676 x896", "Murray" },
                    { new Guid("51cac733-c096-af2f-9047-0e41d5dab830"), "Faroe Islands", new DateTime(1997, 5, 5, 9, 19, 19, 833, DateTimeKind.Utc).AddTicks(7928), 239.818203691337000m, "Arianna97@hotmail.com", "Zander", 900m, 79, "Eveniet cupiditate.", "1-929-681-5334", "O'Connell" },
                    { new Guid("5215cc7b-c4e4-0c5d-d06d-16b856ae7475"), "Timor-Leste", new DateTime(1971, 5, 1, 22, 30, 40, 942, DateTimeKind.Utc).AddTicks(7615), 547.53795406088000m, "Alvena.Jenkins@hotmail.com", "Jedidiah", 800m, 422, "Facere natus.", "825.293.6984 x0389", "Ritchie" },
                    { new Guid("524482b9-944d-98a0-449e-650ea0a7cf57"), "New Zealand", new DateTime(2013, 12, 20, 22, 59, 46, 150, DateTimeKind.Utc).AddTicks(3533), 827.674495984214000m, "Nannie_Wisozk@hotmail.com", "Devyn", 1000m, 698, "Autem atque.", "829.402.4579", "Botsford" },
                    { new Guid("52643705-50ad-15b4-ace7-0a579f72a4a9"), "Estonia", new DateTime(2010, 6, 29, 0, 40, 44, 933, DateTimeKind.Utc).AddTicks(8913), 128.071566934333000m, "Shanie_Jakubowski53@yahoo.com", "Davonte", 500m, 318, "Magnam aspernatur.", "897.855.6014", "Lind" },
                    { new Guid("52b099b9-49c7-9ac2-6364-00468fbef186"), "Monaco", new DateTime(2020, 2, 15, 17, 2, 19, 510, DateTimeKind.Utc).AddTicks(2831), 530.138042510846000m, "Levi_Bosco51@gmail.com", "Kaela", 700m, 996, "Quos expedita.", "1-706-435-7651", "Mosciski" },
                    { new Guid("52e9b21f-2de6-12d5-7fe0-f86528b3dacb"), "Congo", new DateTime(1931, 12, 10, 20, 18, 36, 84, DateTimeKind.Utc).AddTicks(3970), 468.312526895853000m, "Forrest.Emard61@yahoo.com", "Jaylen", 1000m, 270, "Nostrum praesentium.", "666.701.7343 x957", "Walter" },
                    { new Guid("53027ea9-afdd-c3fe-4247-775ea350a484"), "Iceland", new DateTime(1958, 11, 3, 0, 36, 20, 661, DateTimeKind.Utc).AddTicks(7610), 452.975802198564000m, "Jerald_Dare@yahoo.com", "Sasha", 500m, 235, "Nobis officiis.", "920-409-6188 x9975", "Ullrich" },
                    { new Guid("5318a82e-485e-9e7a-0036-2e86191fe46b"), "Northern Mariana Islands", new DateTime(2011, 8, 30, 8, 8, 32, 608, DateTimeKind.Utc).AddTicks(9729), 934.974494968147000m, "Dora_Bailey@yahoo.com", "Harvey", 600m, 490, "Eum aut.", "417-203-9380 x38731", "D'Amore" },
                    { new Guid("5351e240-ba01-2ef6-3151-952a57c659e8"), "Zambia", new DateTime(2017, 2, 25, 8, 45, 31, 443, DateTimeKind.Utc).AddTicks(644), 847.300441118004000m, "Shanie_Flatley82@hotmail.com", "Geraldine", 900m, 630, "In ipsam.", "(500) 301-3596 x3442", "Bednar" },
                    { new Guid("53a81c03-d986-470a-66ba-a734ad0976a2"), "Ireland", new DateTime(1928, 10, 9, 15, 35, 36, 843, DateTimeKind.Utc).AddTicks(9611), 578.576367493198000m, "Simone52@yahoo.com", "Gabe", 600m, 250, "Et eveniet.", "(343) 874-1676", "Goodwin" },
                    { new Guid("53a88993-ccdc-ea4b-4c3b-9e8f62f89e62"), "Turkey", new DateTime(1928, 1, 25, 5, 53, 46, 614, DateTimeKind.Utc).AddTicks(4527), 917.011090591018000m, "Orlo.Schroeder94@yahoo.com", "Melisa", 1000m, 123, "Est rerum.", "710-521-5923 x9207", "Abernathy" },
                    { new Guid("53da8b75-b84f-396b-88c0-9b893f0fc41d"), "Denmark", new DateTime(1973, 7, 19, 18, 29, 2, 24, DateTimeKind.Utc).AddTicks(4739), 919.52137970929000m, "Keyshawn.King3@yahoo.com", "Shirley", 600m, 942, "Repudiandae in.", "1-513-235-5752 x3971", "Lindgren" },
                    { new Guid("540143e2-7e7f-2b8b-c2a4-4231877c5633"), "Malawi", new DateTime(1984, 9, 29, 14, 48, 28, 837, DateTimeKind.Utc).AddTicks(8937), 31.7320470765686000m, "Kale.Mertz42@yahoo.com", "Addie", 700m, 853, "Et aperiam.", "528-621-6196", "Hoeger" },
                    { new Guid("5552a97b-1da1-ef27-4756-2a884a107b7c"), "Iran", new DateTime(2006, 5, 13, 23, 47, 19, 289, DateTimeKind.Utc).AddTicks(4312), 953.423729230535000m, "Ladarius.Pouros@yahoo.com", "Liliane", 800m, 238, "Eum et.", "844.912.0589 x25084", "Kiehn" },
                    { new Guid("5568973e-2405-a48b-480f-ffa68c3f3b55"), "French Polynesia", new DateTime(1933, 2, 1, 23, 10, 18, 108, DateTimeKind.Utc).AddTicks(2500), 321.434381969755000m, "Jazlyn.Prohaska@hotmail.com", "Estefania", 700m, 34, "Qui et.", "1-611-853-8729 x495", "Schulist" },
                    { new Guid("55a4fe41-3bea-8b85-8017-99d0a45212ae"), "Nauru", new DateTime(2001, 1, 22, 9, 9, 38, 898, DateTimeKind.Utc).AddTicks(2788), 588.829410131868000m, "Reese28@gmail.com", "Mariane", 700m, 285, "Fuga voluptatem.", "(676) 837-2098 x331", "Murazik" },
                    { new Guid("55c4797b-7e90-8217-2757-9850fa1e6234"), "Burkina Faso", new DateTime(1986, 7, 19, 23, 30, 44, 837, DateTimeKind.Utc).AddTicks(2700), 582.313564916004000m, "Trevion_Braun@gmail.com", "Uriah", 800m, 219, "Similique necessitatibus.", "1-284-437-1803", "Ortiz" },
                    { new Guid("55d78144-0ed7-155a-c87e-0f2e4473c66f"), "United Kingdom", new DateTime(1962, 7, 28, 18, 28, 36, 388, DateTimeKind.Utc).AddTicks(6461), 197.045339929697000m, "Ilene.Sporer@gmail.com", "Johathan", 900m, 421, "Laborum libero.", "862.375.1996 x3433", "Kuvalis" },
                    { new Guid("55eb2e89-2910-3164-87c7-4bdfa2e8a62b"), "Kyrgyz Republic", new DateTime(1954, 4, 10, 7, 15, 43, 27, DateTimeKind.Utc).AddTicks(4673), 762.818151087025000m, "Noel_Kerluke43@gmail.com", "Eleanore", 1000m, 89, "Aspernatur eligendi.", "219.409.8123 x2178", "Conroy" },
                    { new Guid("56325f6b-7797-db13-f2de-0523305ad82e"), "Montserrat", new DateTime(1987, 9, 14, 22, 27, 41, 809, DateTimeKind.Utc).AddTicks(6353), 695.290828402412000m, "Gabrielle_Huels59@hotmail.com", "Genevieve", 600m, 833, "Aut et.", "954.387.5716", "Johnson" },
                    { new Guid("563d7c6a-c2cb-34a3-3c91-35ae7880c2c0"), "Sudan", new DateTime(1971, 12, 20, 7, 2, 19, 269, DateTimeKind.Utc).AddTicks(2598), 839.154056376111000m, "Joel.Schaefer@yahoo.com", "Sanford", 500m, 383, "Iure recusandae.", "(272) 284-9470", "Grimes" },
                    { new Guid("56a07d9f-ed85-c847-ff0a-d8a5ce8893cf"), "Tajikistan", new DateTime(2024, 9, 10, 3, 28, 34, 740, DateTimeKind.Utc).AddTicks(4122), 59.9997634000498000m, "Enola.Armstrong@gmail.com", "Regan", 600m, 715, "Animi placeat.", "(350) 499-9613", "Miller" },
                    { new Guid("56c6143a-e6e7-08aa-7034-2f7c291d1225"), "Isle of Man", new DateTime(2023, 12, 2, 0, 44, 5, 218, DateTimeKind.Utc).AddTicks(4673), 950.956462010704000m, "Eula.Pouros41@hotmail.com", "Aliyah", 900m, 297, "Occaecati est.", "1-635-770-9952 x379", "Pfeffer" },
                    { new Guid("574be2cb-b477-17f2-4edc-ee466fea9c16"), "Iran", new DateTime(2018, 12, 29, 4, 22, 49, 45, DateTimeKind.Utc).AddTicks(7703), 683.656084355668000m, "Jeffry26@hotmail.com", "Joesph", 600m, 744, "Dolorum delectus.", "580-569-2268", "Kozey" },
                    { new Guid("58b48382-f973-5c53-fa09-ce8a4bb673d0"), "Swaziland", new DateTime(1992, 5, 25, 7, 20, 59, 13, DateTimeKind.Utc).AddTicks(7962), 255.952750619849000m, "Myrl_Flatley37@hotmail.com", "Zoey", 600m, 759, "Fuga magnam.", "562-984-6921 x3424", "Sawayn" },
                    { new Guid("58f4c583-7e9f-dffd-e320-94370970e4f8"), "Brunei Darussalam", new DateTime(1978, 1, 29, 15, 29, 41, 795, DateTimeKind.Utc).AddTicks(3471), 687.017794573982000m, "Foster.Terry73@yahoo.com", "Astrid", 1000m, 881, "Et illo.", "1-592-872-8487 x4381", "Kiehn" },
                    { new Guid("5952ec37-ad47-4aaf-5db2-b14e2d4ab36e"), "Nigeria", new DateTime(1972, 12, 28, 22, 17, 38, 527, DateTimeKind.Utc).AddTicks(7260), 951.330125184066000m, "Marjorie64@yahoo.com", "Everett", 700m, 604, "Non magnam.", "502.217.6086 x0181", "Cummerata" },
                    { new Guid("595f252c-1357-cbcc-87de-0ec9f3de47da"), "Falkland Islands (Malvinas)", new DateTime(2011, 7, 15, 23, 16, 5, 513, DateTimeKind.Utc).AddTicks(752), 488.399680076289000m, "Sunny.Bergstrom@gmail.com", "Myrtle", 900m, 261, "Repudiandae praesentium.", "1-219-850-4095 x6493", "Sanford" },
                    { new Guid("59ae9483-be25-4f9d-8ac2-290ad1520a88"), "China", new DateTime(2003, 5, 23, 13, 1, 36, 664, DateTimeKind.Utc).AddTicks(5109), 307.946103328178000m, "Clare63@hotmail.com", "Colton", 1000m, 151, "Est possimus.", "(931) 356-9837", "Toy" },
                    { new Guid("5a02a7da-1d70-d041-441a-cad42f46f71a"), "Portugal", new DateTime(1973, 11, 28, 17, 1, 51, 309, DateTimeKind.Utc).AddTicks(8779), 513.573143527186000m, "Margarita31@yahoo.com", "Mathias", 1000m, 20, "Tempore unde.", "490.790.8344 x0421", "Langosh" },
                    { new Guid("5a5283e2-b3ab-2921-a5b8-f1e2d082487b"), "Uzbekistan", new DateTime(1994, 9, 16, 12, 50, 59, 751, DateTimeKind.Utc).AddTicks(9746), 958.39093271185000m, "Lenora36@yahoo.com", "Horacio", 800m, 700, "Culpa sapiente.", "(710) 946-2543", "Nitzsche" },
                    { new Guid("5a8fd88e-8ff4-9205-5450-152e2f7328ba"), "Malta", new DateTime(1982, 5, 6, 16, 30, 10, 692, DateTimeKind.Utc).AddTicks(8971), 935.592379495721000m, "Corrine_Wolf@hotmail.com", "Jeremie", 900m, 131, "Placeat at.", "(483) 910-4425 x9989", "Hand" },
                    { new Guid("5acce7ad-e256-6ecf-5067-80ddddc60f98"), "Sao Tome and Principe", new DateTime(1931, 1, 30, 16, 38, 11, 27, DateTimeKind.Utc).AddTicks(4923), 245.421088271502000m, "Queenie_Huel@yahoo.com", "Antoinette", 900m, 551, "Deleniti et.", "418-920-1261", "Ondricka" },
                    { new Guid("5b377e81-bd50-41eb-5650-80a9bcebf179"), "Morocco", new DateTime(1977, 5, 20, 13, 7, 43, 255, DateTimeKind.Utc).AddTicks(4160), 644.422629720034000m, "Roma.Emard@yahoo.com", "Luisa", 1000m, 112, "Id eum.", "(817) 389-1565", "Schulist" },
                    { new Guid("5ba4037e-1aae-cf66-28ad-cefb2bb9a2b5"), "Djibouti", new DateTime(1948, 7, 1, 14, 56, 26, 392, DateTimeKind.Utc).AddTicks(8719), 967.330908423172000m, "Clint1@hotmail.com", "Madonna", 600m, 961, "Quas voluptatum.", "729-853-5128 x606", "Koepp" },
                    { new Guid("5c23983f-4fd1-9b88-256d-1ed809ce5d75"), "Belarus", new DateTime(2009, 3, 5, 19, 52, 19, 563, DateTimeKind.Utc).AddTicks(6933), 344.990048962915000m, "Sam67@yahoo.com", "Jules", 500m, 649, "Dolores expedita.", "732.701.6255", "Toy" },
                    { new Guid("5c734db6-d02e-f107-7893-01738a8baa20"), "Mexico", new DateTime(1933, 3, 11, 18, 4, 42, 528, DateTimeKind.Utc).AddTicks(5024), 56.0454377426591000m, "Oren_Streich95@yahoo.com", "Koby", 1000m, 509, "Eos officia.", "602.394.9422 x1186", "Blick" },
                    { new Guid("5cf23ae3-eb18-6439-e057-b3e03944aa91"), "Bulgaria", new DateTime(1985, 7, 4, 9, 44, 53, 633, DateTimeKind.Utc).AddTicks(4774), 53.9882787252005000m, "Joey6@gmail.com", "Erik", 800m, 857, "Laborum ea.", "1-429-374-8142", "Stanton" },
                    { new Guid("5d3fcacd-12e3-60a5-7744-a71498bbca13"), "Guyana", new DateTime(1951, 6, 4, 9, 37, 33, 99, DateTimeKind.Utc).AddTicks(5205), 885.914229990671000m, "Ali_Ullrich@hotmail.com", "Faustino", 1000m, 947, "Ut sit.", "874-823-2699 x111", "Kuhn" },
                    { new Guid("5d4b0ecf-527b-ae92-45cc-07001c0068ce"), "Tanzania", new DateTime(1950, 10, 17, 10, 38, 28, 612, DateTimeKind.Utc).AddTicks(6551), 311.310466657552000m, "Alexanne_Zemlak@yahoo.com", "Ian", 1000m, 263, "Ut reprehenderit.", "1-883-539-8089", "Champlin" },
                    { new Guid("5d625c54-2ea5-adf6-ec42-18e96724a13a"), "Cameroon", new DateTime(1969, 8, 26, 10, 30, 17, 345, DateTimeKind.Utc).AddTicks(1219), 847.308687737446000m, "Kayden86@yahoo.com", "Phyllis", 700m, 397, "Vel sit.", "(986) 568-9254 x4234", "Towne" },
                    { new Guid("5d88f2c4-ec84-e005-2f63-ec6cfed919b9"), "Turks and Caicos Islands", new DateTime(1954, 7, 16, 6, 1, 13, 353, DateTimeKind.Utc).AddTicks(419), 660.959968480222000m, "Rodger.Bauch@yahoo.com", "Keith", 800m, 525, "Ullam qui.", "(248) 858-7326 x252", "Sawayn" },
                    { new Guid("5dbcfe48-6561-8de2-7524-201a9b754f24"), "Lebanon", new DateTime(1933, 1, 5, 6, 47, 49, 233, DateTimeKind.Utc).AddTicks(4705), 190.349330001627000m, "Howard.Reynolds97@yahoo.com", "Irwin", 700m, 165, "Qui quos.", "(485) 635-8386 x8176", "Schuppe" },
                    { new Guid("5eb18de9-13c3-16ea-9bab-9e4edaacba99"), "Botswana", new DateTime(1985, 2, 23, 6, 19, 7, 118, DateTimeKind.Utc).AddTicks(3360), 233.745498004827000m, "Lelah.Kub85@yahoo.com", "Allie", 700m, 949, "Perferendis impedit.", "1-268-420-0870 x158", "Marks" },
                    { new Guid("5f0fc63f-2983-1eab-2533-233c63aef8d7"), "Vanuatu", new DateTime(1932, 11, 25, 6, 33, 27, 754, DateTimeKind.Utc).AddTicks(4367), 768.844822667147000m, "Prince_Borer@gmail.com", "Emmanuelle", 700m, 240, "Blanditiis quia.", "385.709.7018 x077", "Rodriguez" },
                    { new Guid("5f1ffc66-98cf-df89-96a2-5a9bd0bfc9af"), "Somalia", new DateTime(1968, 2, 19, 22, 42, 46, 703, DateTimeKind.Utc).AddTicks(8151), 766.485819688054000m, "Colin62@yahoo.com", "Mariah", 1000m, 989, "Corporis quidem.", "(389) 576-1965 x1399", "Krajcik" },
                    { new Guid("5f296466-6e53-2ab2-39d4-2835168353c7"), "Virgin Islands, British", new DateTime(1941, 5, 16, 18, 47, 51, 967, DateTimeKind.Utc).AddTicks(5576), 276.042420169246000m, "Gillian8@hotmail.com", "Queenie", 500m, 121, "Quis in.", "508.306.0291 x5433", "Murray" },
                    { new Guid("5f863408-c80c-c3c5-a402-a8add7a1d6be"), "Saint Kitts and Nevis", new DateTime(1946, 1, 4, 16, 48, 12, 114, DateTimeKind.Utc).AddTicks(7958), 258.222001403442000m, "Carmine43@hotmail.com", "Vivien", 900m, 687, "Eveniet sint.", "(218) 646-0114 x125", "Mante" },
                    { new Guid("5fa19fa8-599c-b00c-87a9-0c05bfa75b7e"), "Germany", new DateTime(1972, 3, 7, 5, 40, 47, 34, DateTimeKind.Utc).AddTicks(2103), 169.32903456475000m, "Selina25@gmail.com", "Juvenal", 500m, 30, "Veritatis aut.", "1-869-691-5117", "Friesen" },
                    { new Guid("5fc6af5d-ecc5-4553-d096-eb7f53f0cb6b"), "Brazil", new DateTime(1967, 5, 24, 15, 7, 3, 613, DateTimeKind.Utc).AddTicks(2461), 859.623133528626000m, "Allan.Toy90@hotmail.com", "Tyson", 600m, 844, "Eum voluptatem.", "895-236-6213", "Watsica" },
                    { new Guid("5ff5d53b-2c3c-8d58-ba34-5a85e5919abe"), "Saudi Arabia", new DateTime(1997, 4, 19, 18, 21, 19, 24, DateTimeKind.Utc).AddTicks(5705), 380.341654539311000m, "Juvenal.Parisian48@gmail.com", "Orval", 1000m, 958, "Quia asperiores.", "792-603-8759 x3650", "Doyle" },
                    { new Guid("600dae9c-2708-450b-df9e-204f0b308028"), "Palestinian Territory", new DateTime(1941, 12, 14, 3, 37, 5, 318, DateTimeKind.Utc).AddTicks(4376), 578.88664186007000m, "Alysson_Pagac37@hotmail.com", "Jaquan", 900m, 159, "Consequuntur nihil.", "(242) 667-3081", "Deckow" },
                    { new Guid("605d19c4-037a-72be-038f-a42d5bd01dac"), "Ireland", new DateTime(1967, 11, 26, 20, 46, 20, 668, DateTimeKind.Utc).AddTicks(8378), 442.24386785425000m, "Einar_Crooks@hotmail.com", "Sylvia", 900m, 536, "Ratione velit.", "1-450-344-1374 x544", "Nitzsche" },
                    { new Guid("60829b83-be90-f5f6-47e8-8a0607405668"), "Qatar", new DateTime(1929, 4, 22, 14, 59, 58, 669, DateTimeKind.Utc).AddTicks(9057), 824.208892484588000m, "Teresa75@gmail.com", "Blaise", 600m, 650, "Consequatur inventore.", "412-253-3797 x7238", "Reichel" },
                    { new Guid("60e4d5c9-ea40-1632-dda2-6ced5086460f"), "Nepal", new DateTime(1931, 3, 13, 3, 56, 30, 609, DateTimeKind.Utc).AddTicks(4344), 447.723198201891000m, "Reta20@gmail.com", "Rosalind", 700m, 683, "Incidunt aliquam.", "1-296-969-3373", "Barrows" },
                    { new Guid("6174c48b-38d0-1047-05d1-d24112a34cb7"), "Croatia", new DateTime(1932, 10, 29, 8, 35, 28, 463, DateTimeKind.Utc).AddTicks(4540), 241.361902182687000m, "Merl_Kuhlman71@hotmail.com", "Oral", 900m, 768, "Eos sed.", "1-867-988-2558 x5494", "Lynch" },
                    { new Guid("61788436-22d3-7e83-1f26-0613c11afe37"), "Pakistan", new DateTime(1985, 1, 24, 22, 47, 35, 508, DateTimeKind.Utc).AddTicks(8498), 559.266614313666000m, "Keenan_Casper@hotmail.com", "Mossie", 700m, 309, "Molestiae autem.", "(373) 861-4332 x916", "Kozey" },
                    { new Guid("61af5569-13c2-3da0-0f56-cc5db5594015"), "French Polynesia", new DateTime(1977, 9, 10, 7, 19, 42, 678, DateTimeKind.Utc).AddTicks(8604), 650.249431443234000m, "Jacklyn_Bode40@hotmail.com", "Luigi", 900m, 951, "Adipisci iste.", "(558) 276-1365 x603", "Metz" },
                    { new Guid("61e24e10-7262-488a-db1a-ed4760f16c6e"), "Georgia", new DateTime(1991, 8, 16, 4, 18, 13, 216, DateTimeKind.Utc).AddTicks(1463), 697.679539897626000m, "Pedro.Hermiston38@yahoo.com", "Karli", 600m, 724, "Magnam repellat.", "640-445-5287", "Mann" },
                    { new Guid("61ef12df-cda2-216e-3053-7629e1449bd1"), "Monaco", new DateTime(1994, 7, 9, 15, 12, 10, 55, DateTimeKind.Utc).AddTicks(1018), 779.931348559174000m, "Odie_Keebler@gmail.com", "Arvilla", 700m, 817, "Quidem quia.", "245-842-4257 x2963", "Hilll" },
                    { new Guid("6254677f-516d-6304-7d72-38f771c0274c"), "Netherlands Antilles", new DateTime(1948, 8, 20, 22, 14, 10, 952, DateTimeKind.Utc).AddTicks(4818), 570.236717506148000m, "Crystel9@gmail.com", "Enoch", 900m, 485, "Alias voluptatum.", "1-526-684-6347 x437", "Flatley" },
                    { new Guid("631a0c4c-3c39-3444-348e-ae360701dcf9"), "Hungary", new DateTime(2021, 5, 20, 4, 18, 40, 96, DateTimeKind.Utc).AddTicks(8592), 387.676524400978000m, "Antone26@yahoo.com", "Evan", 700m, 978, "Voluptatibus voluptatem.", "733.962.6227 x35693", "Doyle" },
                    { new Guid("6323e3c8-4e02-eae1-26bf-b0c65d3bf926"), "Central African Republic", new DateTime(1967, 11, 1, 1, 21, 23, 267, DateTimeKind.Utc).AddTicks(3026), 799.777442272457000m, "Maximillia.Becker@gmail.com", "Zion", 500m, 615, "Repellendus sapiente.", "1-667-608-4682", "Schaefer" },
                    { new Guid("63453ec7-8fef-780a-ce9d-00ee95ab73ae"), "Benin", new DateTime(2022, 9, 27, 21, 36, 9, 567, DateTimeKind.Utc).AddTicks(4692), 162.045383828022000m, "Kendrick_Spencer@hotmail.com", "Justina", 1000m, 894, "Ipsam molestias.", "997-775-9019 x84363", "Hodkiewicz" },
                    { new Guid("634dbc91-024c-8bfb-c586-911985594e81"), "Malta", new DateTime(1993, 9, 29, 17, 17, 18, 691, DateTimeKind.Utc).AddTicks(7535), 418.159902886151000m, "Judah87@yahoo.com", "William", 700m, 8, "Eos officiis.", "(952) 505-7018 x3204", "Stiedemann" },
                    { new Guid("6352f511-517a-998d-a929-22a578586186"), "Benin", new DateTime(1968, 12, 4, 13, 34, 38, 520, DateTimeKind.Utc).AddTicks(2300), 294.864183645908000m, "Maximillian76@yahoo.com", "Sandra", 800m, 128, "Eligendi recusandae.", "(983) 769-1731", "Pfeffer" },
                    { new Guid("6363cd66-44db-3225-a04b-4823ab54eade"), "French Southern Territories", new DateTime(2001, 8, 18, 13, 29, 47, 613, DateTimeKind.Utc).AddTicks(4487), 156.671507666859000m, "Tommie_Wunsch@hotmail.com", "Eino", 500m, 350, "Omnis corrupti.", "1-488-838-3753 x0006", "Lehner" },
                    { new Guid("63735af9-04d5-3f5a-e7c2-7010c448df0e"), "Solomon Islands", new DateTime(1996, 10, 28, 8, 51, 42, 597, DateTimeKind.Utc).AddTicks(701), 344.931339947207000m, "Mckenna53@yahoo.com", "Maddison", 500m, 125, "Magni praesentium.", "(730) 671-7681", "Kunde" },
                    { new Guid("638835b4-a0a1-f647-582d-49fa75f46846"), "Guadeloupe", new DateTime(1963, 5, 14, 17, 32, 8, 699, DateTimeKind.Utc).AddTicks(5660), 856.804549088715000m, "Margie_Reilly@gmail.com", "Marie", 600m, 183, "Suscipit sed.", "936.821.2247 x7173", "Koepp" },
                    { new Guid("6414c1da-9b7b-9eee-43de-89ea676a4438"), "Macao", new DateTime(2004, 4, 9, 3, 56, 37, 878, DateTimeKind.Utc).AddTicks(1270), 162.58429814378000m, "Rossie74@yahoo.com", "Nicole", 700m, 945, "Ab animi.", "346-356-0348 x0366", "Grady" },
                    { new Guid("64952740-0aac-3a78-f81f-efcf6e56b573"), "Brunei Darussalam", new DateTime(1991, 12, 29, 20, 7, 19, 318, DateTimeKind.Utc).AddTicks(1431), 573.587573487699000m, "Damien64@yahoo.com", "Jesse", 1000m, 828, "Sit sed.", "216-614-7508 x29828", "Kirlin" },
                    { new Guid("64ad0362-ad54-06d7-1130-77bb0232c089"), "Honduras", new DateTime(1989, 9, 11, 18, 12, 1, 9, DateTimeKind.Utc).AddTicks(3272), 473.774444843292000m, "Uriah_Emard@yahoo.com", "Edgar", 700m, 441, "Qui est.", "(334) 452-8971 x0228", "Dickens" },
                    { new Guid("64c6e1dd-65ac-5d67-1b7e-18702bec3d24"), "Myanmar", new DateTime(2001, 4, 7, 8, 35, 44, 820, DateTimeKind.Utc).AddTicks(6786), 364.48433146381000m, "Cali.Marquardt@yahoo.com", "Beulah", 700m, 548, "Reprehenderit ratione.", "1-719-414-8534 x666", "Mills" },
                    { new Guid("64e1f4d8-5777-f050-1027-1dde1a60c6ee"), "British Indian Ocean Territory (Chagos Archipelago)", new DateTime(1964, 7, 29, 5, 20, 57, 142, DateTimeKind.Utc).AddTicks(9136), 690.714161318608000m, "Zackary41@yahoo.com", "Trevor", 500m, 822, "Tempore ducimus.", "734-538-4747", "Hand" },
                    { new Guid("64ef0baa-13f6-95d5-fc7d-10513a6efe66"), "Canada", new DateTime(1971, 10, 29, 12, 34, 7, 233, DateTimeKind.Utc).AddTicks(7727), 892.374898194494000m, "Brett.Leuschke62@hotmail.com", "Vladimir", 700m, 502, "Sed doloremque.", "564-227-9933 x142", "Tillman" },
                    { new Guid("655a21c0-4570-530e-976e-c97b6ce55f16"), "Liberia", new DateTime(1961, 3, 30, 8, 28, 41, 342, DateTimeKind.Utc).AddTicks(5792), 849.701342728272000m, "Ross_Watsica@gmail.com", "Trycia", 900m, 517, "Ea consequatur.", "727.388.8739 x3690", "Oberbrunner" },
                    { new Guid("65cac6b1-f59c-e8fa-a7c5-c57f4ffb5a10"), "Luxembourg", new DateTime(1969, 7, 31, 2, 5, 35, 49, DateTimeKind.Utc).AddTicks(5563), 512.1493205366000m, "Vergie6@hotmail.com", "Fermin", 900m, 377, "Neque sunt.", "(298) 815-7215", "Kreiger" },
                    { new Guid("65e06eb8-e9d7-4dfd-bee4-6b94cc9b5a5f"), "Gibraltar", new DateTime(2018, 9, 21, 5, 39, 3, 558, DateTimeKind.Utc).AddTicks(9241), 467.49639908608000m, "Domenick.Johnston61@gmail.com", "Meghan", 600m, 211, "Aspernatur soluta.", "757.854.9852 x75227", "Leuschke" },
                    { new Guid("66677998-f086-1b26-968e-b43fd3baf2ff"), "Kyrgyz Republic", new DateTime(2003, 1, 13, 8, 6, 20, 277, DateTimeKind.Utc).AddTicks(9333), 983.859756457889000m, "Rashad.VonRueden@gmail.com", "Margaret", 500m, 154, "Placeat ut.", "560-799-9961", "Heidenreich" },
                    { new Guid("666f100f-7acb-b33f-3de5-1fbfdb304791"), "Heard Island and McDonald Islands", new DateTime(2011, 4, 11, 21, 27, 9, 707, DateTimeKind.Utc).AddTicks(487), 441.729398555228000m, "Freda_Heathcote@hotmail.com", "Orrin", 800m, 247, "Quasi reprehenderit.", "(796) 234-0138", "McDermott" },
                    { new Guid("66b39dba-8d9a-edd0-d570-cd7851e7754d"), "Benin", new DateTime(1949, 4, 16, 13, 8, 43, 108, DateTimeKind.Utc).AddTicks(8548), 555.357671951264000m, "Vincenza.Medhurst50@hotmail.com", "Jewel", 1000m, 365, "Aut praesentium.", "(879) 764-2838", "Gutkowski" },
                    { new Guid("66be6157-d24b-6dc0-d547-55faae567545"), "Armenia", new DateTime(1950, 6, 14, 21, 23, 11, 822, DateTimeKind.Utc).AddTicks(9601), 855.879799474294000m, "Herminio_Bauch71@yahoo.com", "Destany", 700m, 878, "Occaecati eum.", "(789) 346-3929 x9575", "Ward" },
                    { new Guid("66d34181-a3c4-3ca3-40cf-8b6f2378dab5"), "France", new DateTime(1974, 6, 22, 8, 23, 46, 600, DateTimeKind.Utc).AddTicks(8259), 384.971070604751000m, "Chanel.Zieme@yahoo.com", "Jakob", 600m, 838, "Esse porro.", "1-793-282-0562 x1551", "Smitham" },
                    { new Guid("670868e8-9ef8-9b1b-de75-a167c218a7d0"), "Guyana", new DateTime(1964, 3, 26, 16, 31, 17, 660, DateTimeKind.Utc).AddTicks(2786), 359.430792318092000m, "Kory.Fisher@gmail.com", "Joelle", 700m, 637, "A cumque.", "653-355-1773 x79961", "Pfannerstill" },
                    { new Guid("672f0cb6-be72-cef5-7b51-16f921615e10"), "Canada", new DateTime(2013, 11, 16, 6, 33, 31, 269, DateTimeKind.Utc).AddTicks(7758), 70.5743299865538000m, "Arch.OKon@yahoo.com", "Gunner", 900m, 801, "Rerum voluptatem.", "826-337-6184", "Ward" },
                    { new Guid("67bed084-5d27-10e2-7433-1aa781529a15"), "Mozambique", new DateTime(1956, 12, 20, 13, 8, 38, 611, DateTimeKind.Utc).AddTicks(5648), 25.4003584311783000m, "Bertram.Swaniawski@hotmail.com", "Agustin", 800m, 436, "Aut consequatur.", "762-502-2798 x33134", "Muller" },
                    { new Guid("67cad329-e0f5-4e3d-755b-2c542dcbe3b4"), "Bhutan", new DateTime(1930, 2, 4, 3, 1, 37, 247, DateTimeKind.Utc).AddTicks(766), 990.375448071056000m, "Yvonne66@yahoo.com", "Kaylie", 800m, 48, "Sed pariatur.", "(333) 227-8789 x9350", "O'Hara" },
                    { new Guid("67d9cdc7-5faa-ffb6-4288-52411d0feed1"), "Tuvalu", new DateTime(1985, 12, 25, 18, 45, 11, 751, DateTimeKind.Utc).AddTicks(2919), 749.002148875128000m, "Elenora88@hotmail.com", "Paige", 500m, 401, "Reprehenderit aut.", "1-514-713-6547 x236", "Tillman" },
                    { new Guid("67fbe1a5-de85-0d5e-58af-532ba811dc18"), "Guatemala", new DateTime(1975, 9, 7, 0, 32, 55, 661, DateTimeKind.Utc).AddTicks(742), 937.941921553846000m, "Janelle74@hotmail.com", "Jamison", 600m, 731, "Id debitis.", "367.612.6274 x067", "Kilback" },
                    { new Guid("6843bb8d-b1c0-ed45-f4be-4d75145e258a"), "Spain", new DateTime(1975, 8, 1, 21, 54, 8, 403, DateTimeKind.Utc).AddTicks(281), 708.291841831964000m, "Priscilla_Hane@hotmail.com", "Yazmin", 700m, 232, "Sunt dolorum.", "897-992-0537 x9954", "Breitenberg" },
                    { new Guid("686d8e78-f2e0-12ae-c872-46e05ee4ef4f"), "Gabon", new DateTime(1980, 4, 23, 11, 15, 26, 970, DateTimeKind.Utc).AddTicks(2800), 948.826074126736000m, "Jason18@hotmail.com", "Rosalee", 800m, 963, "Iusto placeat.", "1-509-337-6132", "Wiegand" },
                    { new Guid("6898ec6b-de76-2953-7da5-7ba3d24b4075"), "Heard Island and McDonald Islands", new DateTime(1985, 3, 9, 10, 40, 27, 721, DateTimeKind.Utc).AddTicks(6638), 83.2347537637449000m, "Robert.Zboncak@hotmail.com", "Kaia", 900m, 153, "Sapiente ut.", "(823) 333-6153", "McGlynn" },
                    { new Guid("692ece8b-727d-2f0f-cf74-12696caef31a"), "Ecuador", new DateTime(1965, 8, 5, 6, 5, 28, 690, DateTimeKind.Utc).AddTicks(1156), 961.973586543181000m, "Benedict35@hotmail.com", "Daniela", 500m, 669, "Repellendus qui.", "(916) 778-1835 x9801", "Pollich" },
                    { new Guid("693a8e76-777c-6ead-2fe8-016b52b0c496"), "Benin", new DateTime(1992, 2, 10, 15, 37, 24, 117, DateTimeKind.Utc).AddTicks(8570), 322.05534035366000m, "Colin_Harber@yahoo.com", "Kevon", 800m, 242, "Beatae ipsam.", "1-972-394-9598", "Heller" },
                    { new Guid("69af5030-19f1-c7ea-6ee8-342945b38f5e"), "Northern Mariana Islands", new DateTime(1976, 12, 27, 8, 25, 4, 242, DateTimeKind.Utc).AddTicks(808), 171.918439429151000m, "Birdie.King85@hotmail.com", "Maggie", 800m, 512, "Quia est.", "591-469-3136 x30576", "Kozey" },
                    { new Guid("69dfc2bf-5694-3e76-1707-804affd59aff"), "Virgin Islands, U.S.", new DateTime(1948, 6, 22, 11, 13, 52, 706, DateTimeKind.Utc).AddTicks(5778), 929.886433542888000m, "Wanda.Bayer27@yahoo.com", "Giuseppe", 700m, 865, "Voluptate autem.", "1-387-478-9835 x0301", "Wisozk" },
                    { new Guid("69fda974-1c23-b273-3a6b-f558915f5714"), "Libyan Arab Jamahiriya", new DateTime(1954, 9, 17, 15, 1, 26, 73, DateTimeKind.Utc).AddTicks(6999), 239.380062925138000m, "Monserrat.Hackett47@hotmail.com", "Marielle", 700m, 862, "Tempora odit.", "925-232-5262", "Kihn" },
                    { new Guid("6a38705e-8e50-9a7b-0287-135d2f5fb734"), "Gambia", new DateTime(2019, 6, 20, 10, 39, 46, 900, DateTimeKind.Utc).AddTicks(3604), 856.927820622562000m, "Kellen.Stokes72@hotmail.com", "Jaqueline", 600m, 262, "Qui est.", "949.493.1883 x098", "Johns" },
                    { new Guid("6a3a4279-e398-e54d-d680-0c2eb41404a1"), "New Caledonia", new DateTime(1973, 4, 14, 23, 27, 33, 648, DateTimeKind.Utc).AddTicks(936), 774.377377074299000m, "Lucienne.Stamm@gmail.com", "Lou", 800m, 198, "In nemo.", "546.247.4225 x5022", "Crooks" },
                    { new Guid("6a41a6fe-4258-7f18-a084-d67088559032"), "Lao People's Democratic Republic", new DateTime(2016, 11, 8, 9, 24, 12, 453, DateTimeKind.Utc).AddTicks(3983), 453.432679365312000m, "Lou_DuBuque64@hotmail.com", "Bennie", 500m, 253, "Aliquam nam.", "1-638-850-1887 x167", "Welch" },
                    { new Guid("6a719712-3ecb-f08a-3eaa-6fa2db5489ff"), "Lebanon", new DateTime(1995, 9, 10, 4, 19, 23, 887, DateTimeKind.Utc).AddTicks(7189), 218.980109357346000m, "Simone_Murray@hotmail.com", "Grover", 500m, 208, "Et voluptatem.", "518.302.3931", "Hartmann" },
                    { new Guid("6ab62e65-c344-67ed-03e3-e699e4719fd8"), "Japan", new DateTime(1980, 1, 21, 23, 59, 43, 469, DateTimeKind.Utc).AddTicks(9388), 190.930483907612000m, "Norene.Bergstrom@gmail.com", "Britney", 900m, 414, "Omnis neque.", "676-907-0330 x75938", "Dickens" },
                    { new Guid("6aeb4853-3a68-5429-134b-66d806b4aa01"), "Tanzania", new DateTime(1926, 5, 6, 7, 26, 35, 703, DateTimeKind.Utc).AddTicks(3834), 506.129742094358000m, "Kailey_Gaylord@hotmail.com", "Ova", 900m, 582, "Veritatis ad.", "(474) 549-7779 x9212", "Doyle" },
                    { new Guid("6b50ce14-2eba-117c-707a-49f813acc64a"), "Tunisia", new DateTime(1927, 12, 3, 14, 34, 22, 563, DateTimeKind.Utc).AddTicks(3799), 763.257798933266000m, "Clarissa.Sawayn28@gmail.com", "Ines", 600m, 378, "Officia adipisci.", "563-829-5201", "Turcotte" },
                    { new Guid("6b9dba3b-c8af-c922-2a5c-e19ac77e176a"), "Paraguay", new DateTime(1992, 9, 30, 14, 7, 46, 445, DateTimeKind.Utc).AddTicks(7584), 69.0223172937653000m, "Christina.Bosco40@hotmail.com", "Alycia", 900m, 879, "Veritatis et.", "1-303-757-6063 x1066", "Kassulke" },
                    { new Guid("6c2e3d1e-f201-a87b-051b-ef3bdceb60fa"), "Kenya", new DateTime(2019, 11, 3, 18, 6, 17, 481, DateTimeKind.Utc).AddTicks(1486), 325.765067765542000m, "Carroll80@yahoo.com", "Dora", 600m, 867, "Adipisci sint.", "777-699-2631 x625", "Macejkovic" },
                    { new Guid("6c3790bd-b529-83fa-58a2-4ec74d4e4c03"), "Ukraine", new DateTime(1962, 11, 28, 14, 29, 42, 290, DateTimeKind.Utc).AddTicks(6451), 953.548855040921000m, "Blake32@hotmail.com", "Amely", 900m, 415, "Ea praesentium.", "558.874.7926", "Hills" },
                    { new Guid("6c71f18a-51e3-51d2-da4b-a3fb87b7958d"), "Jersey", new DateTime(1991, 8, 10, 11, 38, 47, 15, DateTimeKind.Utc).AddTicks(5299), 144.742945272165000m, "Sherwood.Dietrich32@hotmail.com", "Nolan", 800m, 14, "Ullam sit.", "330.842.8600 x73550", "Romaguera" },
                    { new Guid("6cd900b1-29fb-e06b-cb97-4ad20b6e541b"), "Maldives", new DateTime(1941, 3, 8, 20, 27, 7, 691, DateTimeKind.Utc).AddTicks(5390), 445.537827111932000m, "Maddison.Carroll2@gmail.com", "Leonard", 500m, 315, "Et quia.", "975-426-6328", "Bauch" },
                    { new Guid("6ce6bca9-0d68-8264-3d36-ff35aa5864e9"), "Macao", new DateTime(1976, 2, 24, 21, 21, 24, 767, DateTimeKind.Utc).AddTicks(1095), 936.487335339114000m, "Loma_Boehm73@gmail.com", "Marilou", 1000m, 571, "Unde sit.", "859.882.0770", "Crona" },
                    { new Guid("6cec6956-fba4-07fc-6e7d-5b438af25000"), "Armenia", new DateTime(1983, 1, 29, 18, 6, 56, 674, DateTimeKind.Utc).AddTicks(1321), 302.759175893526000m, "Benedict.Wyman@hotmail.com", "Micah", 800m, 85, "Et odit.", "1-511-509-0794", "Schiller" },
                    { new Guid("6d077ddb-68c7-f822-6a77-dfbf99d85a9a"), "Norfolk Island", new DateTime(1927, 10, 11, 2, 58, 6, 122, DateTimeKind.Utc).AddTicks(3528), 304.474122392852000m, "Keira_Lesch@hotmail.com", "Alberta", 800m, 430, "Quod illo.", "271.235.2223 x8683", "Bosco" },
                    { new Guid("6d47b20f-3525-94f6-674f-7076c4b1e27d"), "Bulgaria", new DateTime(1975, 10, 23, 7, 38, 49, 159, DateTimeKind.Utc).AddTicks(3880), 808.550657756952000m, "Kirsten_Willms@yahoo.com", "Anabelle", 500m, 720, "Officiis qui.", "1-695-335-6092", "Kirlin" },
                    { new Guid("6d6d6bde-8098-661b-1d6b-fbfa81dcdb76"), "Isle of Man", new DateTime(1933, 6, 29, 8, 22, 37, 970, DateTimeKind.Utc).AddTicks(5118), 266.629736570651000m, "Kevin24@hotmail.com", "Harrison", 600m, 361, "Ut hic.", "(645) 286-3664 x7366", "Hilpert" },
                    { new Guid("6dcf6abb-233b-2cbd-edf1-8f3a735ba370"), "Grenada", new DateTime(1959, 2, 22, 19, 26, 19, 688, DateTimeKind.Utc).AddTicks(9672), 874.580369253838000m, "Loraine_Champlin@hotmail.com", "Elbert", 600m, 976, "Cupiditate dolores.", "591.395.9809", "Hills" },
                    { new Guid("6dec2a40-f142-c5fe-d921-4c10b2e351e7"), "Cameroon", new DateTime(1990, 2, 11, 15, 5, 0, 203, DateTimeKind.Utc).AddTicks(1968), 284.291666592274000m, "Aurelie_Baumbach76@hotmail.com", "Harrison", 600m, 784, "Est quis.", "596-292-2467 x83398", "Walker" },
                    { new Guid("6df9a0da-8129-2bf0-7e2d-9dd3f488a97f"), "El Salvador", new DateTime(2015, 4, 19, 8, 13, 42, 935, DateTimeKind.Utc).AddTicks(6316), 627.73498868156000m, "Evan_Cremin@gmail.com", "Ida", 600m, 15, "Qui incidunt.", "480-691-0074", "Jakubowski" },
                    { new Guid("6e5cbc1b-faa2-0e16-8b5c-70450beab9a4"), "Aruba", new DateTime(2011, 5, 7, 23, 19, 50, 199, DateTimeKind.Utc).AddTicks(6329), 87.7134196049889000m, "Brooklyn67@gmail.com", "Ardella", 1000m, 918, "Necessitatibus veniam.", "(576) 570-9391", "Bogan" },
                    { new Guid("6ecb21f6-287d-ee19-6380-2b3bab92bd97"), "Mali", new DateTime(1927, 4, 4, 15, 45, 8, 996, DateTimeKind.Utc).AddTicks(198), 219.604411742625000m, "Brooke.DuBuque@hotmail.com", "Helene", 1000m, 467, "Nisi autem.", "(560) 683-2066", "Jerde" },
                    { new Guid("6ecb435a-c559-22a3-d5d2-564f35920ac3"), "Gambia", new DateTime(2000, 5, 23, 12, 12, 54, 501, DateTimeKind.Utc).AddTicks(9154), 918.569097063785000m, "Macy.Purdy@gmail.com", "Adele", 600m, 117, "Non excepturi.", "528-286-5093 x64135", "Emard" },
                    { new Guid("6ed99472-738f-6f05-3814-4a409a933785"), "Iceland", new DateTime(1957, 1, 30, 12, 16, 32, 467, DateTimeKind.Utc).AddTicks(2882), 771.952465680348000m, "Allie_Boyer@gmail.com", "Kendrick", 800m, 476, "Odit dolorem.", "767-719-0593", "Conroy" },
                    { new Guid("6ef498ad-4a1b-a418-b83b-372005f4b39f"), "Ukraine", new DateTime(1984, 12, 6, 17, 17, 47, 627, DateTimeKind.Utc).AddTicks(3847), 264.079467134544000m, "Jaida_Windler@gmail.com", "Bernie", 900m, 196, "Ea ut.", "(913) 754-4164", "Predovic" },
                    { new Guid("6f6350a3-1f6f-d55f-6a65-df97de21b587"), "Maldives", new DateTime(2016, 5, 2, 1, 33, 21, 691, DateTimeKind.Utc).AddTicks(528), 80.5378156459435000m, "Niko.Glover@yahoo.com", "Ezequiel", 500m, 842, "Omnis voluptatum.", "216.490.6826 x07919", "Jacobi" },
                    { new Guid("6fccf737-342c-4f36-077d-b97198b86ffd"), "Liechtenstein", new DateTime(1990, 6, 24, 7, 5, 30, 306, DateTimeKind.Utc).AddTicks(5427), 882.081271111636000m, "Annetta.Witting@hotmail.com", "Raul", 900m, 38, "Eum qui.", "(572) 257-0976", "Deckow" },
                    { new Guid("701931a6-b26a-1e2e-a5de-ad550c369d86"), "Ecuador", new DateTime(1958, 2, 11, 15, 13, 41, 466, DateTimeKind.Utc).AddTicks(8563), 98.0902581020916000m, "Marcella31@gmail.com", "Bria", 500m, 679, "In vel.", "349.877.3862 x90016", "Lynch" },
                    { new Guid("7070f030-c528-65ec-eb2b-5ac3291cba87"), "Montserrat", new DateTime(1963, 1, 3, 16, 24, 40, 682, DateTimeKind.Utc).AddTicks(9422), 25.533924157635000m, "Maxwell_Bogisich61@gmail.com", "Georgette", 600m, 570, "Aut hic.", "657.716.1219 x8037", "Beer" },
                    { new Guid("70b6b192-bcbb-eae4-d635-919e894336fd"), "Panama", new DateTime(1953, 2, 20, 19, 28, 37, 730, DateTimeKind.Utc).AddTicks(5948), 878.499387098751000m, "Broderick.Conroy@gmail.com", "Triston", 600m, 543, "Et repellendus.", "(989) 304-7800 x0451", "Huels" },
                    { new Guid("70e323ee-1eaa-c824-d78f-1e67dc1676fd"), "Puerto Rico", new DateTime(1971, 1, 27, 4, 8, 49, 695, DateTimeKind.Utc).AddTicks(529), 107.998190056237000m, "Marcos_Heller65@hotmail.com", "Easter", 500m, 659, "Sequi quia.", "872-612-2032 x892", "Kling" },
                    { new Guid("70e71989-2972-80d0-5e80-a26952f145ce"), "Algeria", new DateTime(2005, 7, 1, 13, 46, 52, 826, DateTimeKind.Utc).AddTicks(1309), 306.121900250676000m, "Rosalind.Kerluke82@hotmail.com", "Stan", 800m, 559, "Quis rerum.", "1-293-969-9360", "Howell" },
                    { new Guid("70fb285a-0a02-5deb-30f4-9d414db376c6"), "Cambodia", new DateTime(1948, 9, 22, 4, 32, 59, 654, DateTimeKind.Utc).AddTicks(8664), 316.262808083003000m, "Julio.Kozey@yahoo.com", "Marisol", 1000m, 631, "Iusto omnis.", "669-237-5259", "Green" },
                    { new Guid("71693a9b-8ef2-e564-abbf-d376ac0858be"), "Jordan", new DateTime(1949, 6, 12, 6, 5, 59, 170, DateTimeKind.Utc).AddTicks(2033), 130.962101475485000m, "Al28@gmail.com", "Everardo", 1000m, 412, "Et voluptatem.", "(647) 500-7420", "Bogisich" },
                    { new Guid("719c5ca8-a413-8cbe-32e0-b75742cf7653"), "Bolivia", new DateTime(1988, 9, 8, 15, 22, 9, 99, DateTimeKind.Utc).AddTicks(9689), 899.525208019291000m, "Amari56@gmail.com", "Sylvester", 1000m, 177, "Ullam eveniet.", "241.782.1259 x134", "Bergstrom" },
                    { new Guid("71ee2984-2153-c237-19b8-148a59869efd"), "China", new DateTime(1960, 2, 10, 2, 7, 42, 446, DateTimeKind.Utc).AddTicks(4145), 20.0418552189545000m, "Whitney3@gmail.com", "Alayna", 600m, 386, "Ut corporis.", "(267) 525-6741 x9251", "Donnelly" },
                    { new Guid("721ec482-f6ff-601a-a5d7-9dff5c5f21d1"), "Kuwait", new DateTime(1932, 1, 12, 20, 11, 37, 297, DateTimeKind.Utc).AddTicks(1939), 226.076013913058000m, "Adam.Reinger60@hotmail.com", "Chelsea", 500m, 854, "Vel nemo.", "520.232.8098 x6618", "Marks" },
                    { new Guid("737b03e1-1f7f-4e04-f554-b5219332a852"), "Republic of Korea", new DateTime(1987, 6, 18, 15, 27, 0, 95, DateTimeKind.Utc).AddTicks(1128), 851.276145083498000m, "Adonis75@yahoo.com", "Elouise", 1000m, 737, "Qui eos.", "904-218-9381 x0292", "Kling" },
                    { new Guid("739794f5-6245-c8db-f724-b432b27be3f0"), "Saint Martin", new DateTime(1958, 8, 2, 23, 7, 14, 983, DateTimeKind.Utc).AddTicks(2837), 387.106626175016000m, "Nicholas.Strosin72@gmail.com", "Grady", 500m, 770, "Et eaque.", "890-926-9939 x578", "Funk" },
                    { new Guid("73a45bf3-bab8-c9c2-5b2b-6f6836f6b51a"), "Turks and Caicos Islands", new DateTime(2019, 5, 1, 19, 41, 2, 283, DateTimeKind.Utc).AddTicks(8996), 215.857550110521000m, "Louisa_Hamill83@gmail.com", "Marco", 900m, 705, "Praesentium nobis.", "(655) 820-1195", "Turner" },
                    { new Guid("73a64638-f59b-1376-72f6-52075bf8c14a"), "Vietnam", new DateTime(1929, 12, 11, 13, 16, 58, 826, DateTimeKind.Utc).AddTicks(4780), 854.975057134571000m, "Abdul54@hotmail.com", "Gaetano", 1000m, 955, "Assumenda voluptate.", "(227) 615-3908 x8967", "Strosin" },
                    { new Guid("740ecebc-0435-3875-c7cc-1d4eb6ce9c78"), "New Caledonia", new DateTime(1960, 8, 20, 10, 41, 20, 845, DateTimeKind.Utc).AddTicks(5333), 636.548348980267000m, "Cassie_Mills@yahoo.com", "Rupert", 700m, 176, "Porro perspiciatis.", "(367) 257-7263", "Schuppe" },
                    { new Guid("74511b4c-eb7b-0a50-3192-df823f660b3a"), "Swaziland", new DateTime(2009, 8, 25, 5, 18, 17, 449, DateTimeKind.Utc).AddTicks(4148), 315.757124601269000m, "Moises.Kling47@hotmail.com", "Brooke", 500m, 402, "Consequatur modi.", "671.437.4068 x05022", "Hackett" },
                    { new Guid("749dcf66-b26b-e69f-5f79-f48340e1ded0"), "Antarctica (the territory South of 60 deg S)", new DateTime(1958, 2, 24, 18, 56, 55, 521, DateTimeKind.Utc).AddTicks(8532), 252.845551993475000m, "Noel.Kautzer72@gmail.com", "Kayley", 700m, 163, "Aut inventore.", "984.916.6025", "Langosh" },
                    { new Guid("74e45480-3918-5990-6c66-68b3f2cedf9d"), "Norfolk Island", new DateTime(1975, 5, 18, 5, 31, 38, 749, DateTimeKind.Utc).AddTicks(3836), 979.6419519813000m, "Leta_Toy9@hotmail.com", "Hailey", 700m, 181, "Quo eum.", "980-445-4327", "Von" },
                    { new Guid("751f529d-0483-954e-3358-8b9fbbe80399"), "Trinidad and Tobago", new DateTime(1995, 9, 8, 18, 11, 40, 512, DateTimeKind.Utc).AddTicks(7579), 356.631679943352000m, "Manley_Schamberger@hotmail.com", "Tillman", 700m, 635, "Asperiores eum.", "(283) 366-4290 x2938", "Hand" },
                    { new Guid("7667c8f3-0513-e74e-19c2-88b36806e745"), "Canada", new DateTime(2014, 6, 21, 5, 21, 23, 746, DateTimeKind.Utc).AddTicks(1724), 941.37942206874000m, "Dejon_Heller@yahoo.com", "Sibyl", 800m, 148, "Itaque accusantium.", "354.314.5004 x2004", "Harvey" },
                    { new Guid("76a0ac00-ae93-d419-d0a7-3e94ba0f957a"), "Bolivia", new DateTime(2011, 4, 22, 10, 32, 17, 269, DateTimeKind.Utc).AddTicks(8646), 436.752566559646000m, "Elise44@gmail.com", "Kory", 600m, 519, "Qui error.", "359.799.2972 x03708", "Spencer" },
                    { new Guid("77038cd9-da2c-61e4-13ef-44f57780c1af"), "New Caledonia", new DateTime(1947, 3, 15, 1, 42, 43, 553, DateTimeKind.Utc).AddTicks(8033), 730.686002087114000m, "Roberto25@hotmail.com", "Jeramy", 600m, 802, "Dignissimos eligendi.", "(230) 894-8986", "Hamill" },
                    { new Guid("77132cec-c669-c20e-80e1-59947e80c6d3"), "Mexico", new DateTime(1937, 6, 4, 15, 56, 41, 426, DateTimeKind.Utc).AddTicks(3), 370.264350685267000m, "Bettie.Trantow38@yahoo.com", "Ima", 800m, 277, "Doloribus nisi.", "803-374-2661 x4851", "Lubowitz" },
                    { new Guid("77353466-4cc0-8279-a686-2a9762dadb49"), "Lithuania", new DateTime(1964, 6, 17, 19, 37, 36, 781, DateTimeKind.Utc).AddTicks(6437), 886.346946470462000m, "Vita_Schaden67@yahoo.com", "Elenor", 800m, 533, "Dolores sunt.", "(972) 720-3475 x8198", "Lubowitz" },
                    { new Guid("7744f3b6-821c-a593-a995-25c4010408a5"), "San Marino", new DateTime(2019, 6, 24, 14, 31, 49, 110, DateTimeKind.Utc).AddTicks(7057), 979.424627322361000m, "Mazie_Parker@gmail.com", "Marjolaine", 1000m, 53, "Dolores sed.", "755.274.3438 x78391", "Schmitt" },
                    { new Guid("7750f634-9492-624d-f0ef-263f5b6965f8"), "Nigeria", new DateTime(1964, 4, 5, 20, 22, 2, 185, DateTimeKind.Utc).AddTicks(9896), 923.869905315606000m, "Sedrick54@gmail.com", "Marcellus", 600m, 859, "Ab animi.", "(461) 984-5482", "Will" },
                    { new Guid("7751a381-a7f8-3f10-ab7a-915b8754c265"), "Iraq", new DateTime(2011, 7, 6, 3, 2, 17, 904, DateTimeKind.Utc).AddTicks(3831), 822.223776843731000m, "Ozella.Tremblay98@yahoo.com", "Darrel", 600m, 61, "Sunt qui.", "1-652-771-9834", "Bergstrom" },
                    { new Guid("783fd678-ab5b-0c78-741f-a9b65806a2dd"), "Reunion", new DateTime(2015, 2, 18, 20, 34, 3, 496, DateTimeKind.Utc).AddTicks(3108), 553.811478689296000m, "Alexane.Fritsch@yahoo.com", "Keira", 600m, 203, "Porro mollitia.", "(744) 980-1196", "Muller" },
                    { new Guid("78d0467f-c455-8e5e-9619-1da24e0acddc"), "Falkland Islands (Malvinas)", new DateTime(2006, 9, 10, 17, 1, 14, 415, DateTimeKind.Utc).AddTicks(4629), 74.5929182121686000m, "Kailyn_King24@hotmail.com", "Sallie", 900m, 213, "Consectetur eius.", "362-754-5101 x306", "Kessler" },
                    { new Guid("7969b10c-96c5-4d01-cbaa-6a647db2abfe"), "United Arab Emirates", new DateTime(1928, 9, 19, 17, 30, 36, 698, DateTimeKind.Utc).AddTicks(4028), 942.318067236149000m, "Gordon.Tromp3@yahoo.com", "Donavon", 500m, 225, "Rem recusandae.", "887-847-0173", "Hyatt" },
                    { new Guid("79779255-0217-1def-c163-eaa3d8020ea4"), "Jordan", new DateTime(1994, 7, 16, 5, 19, 4, 381, DateTimeKind.Utc).AddTicks(9115), 673.2423724512000m, "Elmore86@gmail.com", "Jovani", 500m, 36, "Cum ut.", "219.595.6237 x384", "Kshlerin" },
                    { new Guid("79b98e33-7420-f06a-7239-17a408d4e1f4"), "Taiwan", new DateTime(1982, 9, 28, 10, 7, 41, 592, DateTimeKind.Utc).AddTicks(1510), 701.324618211637000m, "Raegan.Kling@hotmail.com", "Shania", 900m, 704, "Dolore ullam.", "723.336.2187 x074", "Von" },
                    { new Guid("79ba348b-192d-4659-9edb-72a5a57457a3"), "Guinea-Bissau", new DateTime(1982, 3, 9, 1, 12, 4, 576, DateTimeKind.Utc).AddTicks(6702), 894.390126354876000m, "Edgar19@yahoo.com", "Lane", 1000m, 980, "Perspiciatis molestias.", "512.917.7019", "Feil" },
                    { new Guid("79c70010-b750-1dfd-ff69-ee64589f99e8"), "Benin", new DateTime(1997, 10, 30, 22, 19, 29, 450, DateTimeKind.Utc).AddTicks(5604), 548.320958514386000m, "Coty_Mohr@hotmail.com", "Brady", 900m, 787, "Doloribus maxime.", "723.472.3520 x5958", "Grant" },
                    { new Guid("7a57bce5-0abb-14d0-7670-10cbf86889a4"), "Zambia", new DateTime(2010, 10, 12, 11, 42, 56, 81, DateTimeKind.Utc).AddTicks(6025), 669.877387673632000m, "Will.Wiza21@hotmail.com", "Conner", 800m, 773, "Omnis repudiandae.", "638-415-2148 x167", "Monahan" },
                    { new Guid("7a62990a-557a-854e-ad06-e0848049cd08"), "Solomon Islands", new DateTime(1956, 10, 19, 12, 29, 12, 908, DateTimeKind.Utc).AddTicks(3518), 205.644747758988000m, "Lori.Schumm@yahoo.com", "Jamison", 700m, 530, "Facilis incidunt.", "1-625-631-9417", "Schamberger" },
                    { new Guid("7a81be91-8869-0679-ec7c-3929db703c29"), "Micronesia", new DateTime(1979, 3, 10, 19, 45, 20, 5, DateTimeKind.Utc).AddTicks(172), 537.112791060482000m, "Luciano_Collins68@hotmail.com", "Laury", 900m, 739, "Deleniti amet.", "(580) 833-0456 x1382", "Quitzon" },
                    { new Guid("7abed367-e192-d41b-47af-0bf90a7e9329"), "Cocos (Keeling) Islands", new DateTime(1949, 7, 7, 17, 59, 24, 733, DateTimeKind.Utc).AddTicks(1464), 260.806465130798000m, "Skyla6@yahoo.com", "Elda", 700m, 475, "Rerum cupiditate.", "763-827-9941", "Littel" },
                    { new Guid("7aec075a-9056-817f-011e-af8e44fa8d37"), "Mexico", new DateTime(1997, 5, 7, 3, 21, 4, 198, DateTimeKind.Utc).AddTicks(9477), 477.715027515442000m, "Eriberto_Walker35@yahoo.com", "Wilfred", 1000m, 895, "Itaque repellat.", "(616) 837-1052", "Goodwin" },
                    { new Guid("7bf4a24d-a16e-e705-737b-a6f715d8086e"), "Cayman Islands", new DateTime(1993, 5, 24, 20, 35, 55, 373, DateTimeKind.Utc).AddTicks(6105), 376.849250430766000m, "Alan.Aufderhar93@gmail.com", "Norberto", 1000m, 852, "Sit natus.", "400.306.0812 x38551", "Cruickshank" },
                    { new Guid("7c715c5f-e246-6fd5-01a6-9c9495f0b588"), "Uganda", new DateTime(1964, 11, 24, 9, 54, 49, 528, DateTimeKind.Utc).AddTicks(7053), 622.916182928198000m, "Shyanne73@hotmail.com", "Axel", 800m, 294, "Minus tenetur.", "470.275.5744", "Morissette" },
                    { new Guid("7c8df571-fa0e-754c-409b-f682582b4632"), "Ireland", new DateTime(1941, 6, 14, 12, 28, 47, 903, DateTimeKind.Utc).AddTicks(220), 982.190164281803000m, "Valerie42@yahoo.com", "Lupe", 500m, 523, "Blanditiis voluptates.", "(232) 238-3506", "Emmerich" },
                    { new Guid("7d5fbc42-acc2-323e-ebec-2436dd267ff2"), "Bermuda", new DateTime(1926, 12, 17, 17, 5, 16, 996, DateTimeKind.Utc).AddTicks(7120), 875.119341197516000m, "Bart.Raynor22@yahoo.com", "Trinity", 1000m, 920, "Cumque dolorem.", "(951) 366-4489", "Roob" },
                    { new Guid("7d6edd8a-27ba-de4a-bcf9-61fe4ba73e48"), "Saint Helena", new DateTime(1973, 5, 14, 20, 5, 27, 772, DateTimeKind.Utc).AddTicks(4458), 827.075862009384000m, "Raul.Johnston84@hotmail.com", "Melvin", 1000m, 431, "Ducimus ratione.", "979-576-5428", "Stiedemann" },
                    { new Guid("7d8e57d9-2641-0ab6-974c-ed94423638f3"), "Svalbard & Jan Mayen Islands", new DateTime(1943, 9, 15, 22, 38, 58, 993, DateTimeKind.Utc).AddTicks(1407), 169.46144819768000m, "Juston.OKeefe6@hotmail.com", "Willa", 700m, 992, "Temporibus quis.", "1-959-297-8372", "Lebsack" },
                    { new Guid("7dc84b4d-194b-f8ea-6fb2-cdbb9661b927"), "Gabon", new DateTime(2018, 7, 4, 4, 27, 54, 349, DateTimeKind.Utc).AddTicks(2951), 130.520240400621000m, "Brenda22@gmail.com", "Alfredo", 1000m, 99, "Rerum animi.", "850-468-2696 x2033", "Armstrong" },
                    { new Guid("7de1f484-d1a0-110f-e4cc-f9b004b02ed7"), "Cote d'Ivoire", new DateTime(2021, 4, 18, 12, 59, 47, 533, DateTimeKind.Utc).AddTicks(3534), 638.042509065769000m, "Aiden_MacGyver32@yahoo.com", "Jerrod", 700m, 850, "Quo rerum.", "843-579-0136", "Wisozk" },
                    { new Guid("7e204c10-6961-ef1f-89fe-55163adcdc38"), "Comoros", new DateTime(1933, 3, 21, 22, 9, 41, 414, DateTimeKind.Utc).AddTicks(7989), 671.694381989945000m, "Marcelina_Schumm@hotmail.com", "Judson", 700m, 864, "Quasi explicabo.", "945-249-7081 x242", "Rippin" },
                    { new Guid("7e40792a-f9ea-c3c2-4b20-e0fb5712fac8"), "Virgin Islands, U.S.", new DateTime(1934, 9, 30, 8, 6, 5, 823, DateTimeKind.Utc).AddTicks(3310), 735.110551223744000m, "Sigmund70@yahoo.com", "Dorcas", 800m, 521, "Ea error.", "1-865-250-6976 x2512", "Pfeffer" },
                    { new Guid("7ed86292-50e7-cbe9-3c6a-307f15b01508"), "Bouvet Island (Bouvetoya)", new DateTime(1996, 7, 31, 13, 47, 0, 428, DateTimeKind.Utc).AddTicks(281), 374.384258544827000m, "Bria95@gmail.com", "Rolando", 600m, 120, "Sed harum.", "(328) 612-8712", "Tromp" },
                    { new Guid("7ee67557-5f9c-493f-b733-00302ad4f8df"), "Turks and Caicos Islands", new DateTime(1992, 12, 18, 12, 14, 50, 412, DateTimeKind.Utc).AddTicks(5904), 538.298163663939000m, "Rhianna.Schiller9@gmail.com", "Cassidy", 700m, 341, "Ut laborum.", "(462) 343-8425 x7622", "Botsford" },
                    { new Guid("7fb1fee0-fdc9-fb8e-7930-39e2fcec5dce"), "Egypt", new DateTime(1973, 5, 26, 14, 6, 17, 871, DateTimeKind.Utc).AddTicks(7344), 322.328806670224000m, "Narciso.Leuschke@yahoo.com", "Hipolito", 1000m, 546, "Ducimus iusto.", "(666) 410-2235", "Conn" },
                    { new Guid("7fc3668b-4c4c-eebd-81fe-e477baffb4e4"), "Italy", new DateTime(2009, 2, 11, 11, 10, 51, 196, DateTimeKind.Utc).AddTicks(5419), 732.29761606112000m, "Cassandre_Dicki@hotmail.com", "Javon", 500m, 355, "Reiciendis qui.", "(721) 665-9401 x7451", "Bartoletti" },
                    { new Guid("7fd73726-4be2-acae-8fb3-aaf1aefbe166"), "Hungary", new DateTime(1964, 5, 22, 3, 54, 42, 869, DateTimeKind.Utc).AddTicks(8068), 382.104485352137000m, "Gloria_Mohr@hotmail.com", "Giles", 700m, 969, "Praesentium eveniet.", "1-418-849-6787", "Morar" },
                    { new Guid("8078afa6-e250-4460-d12d-685d78c01965"), "Germany", new DateTime(1969, 12, 14, 2, 22, 25, 701, DateTimeKind.Utc).AddTicks(6339), 584.760345317851000m, "Delmer.Krajcik@hotmail.com", "Megane", 800m, 359, "Ut pariatur.", "(227) 598-8854 x4874", "Lueilwitz" },
                    { new Guid("80e71255-dfa1-35f8-2ef3-a5987796c184"), "Armenia", new DateTime(1936, 3, 4, 19, 27, 6, 94, DateTimeKind.Utc).AddTicks(6284), 817.043368833866000m, "Ulises_Graham@gmail.com", "Reese", 800m, 634, "Voluptates aperiam.", "(981) 732-6356 x3106", "VonRueden" },
                    { new Guid("81112740-0d3b-0fa6-b48c-7c69f2715c9a"), "Cocos (Keeling) Islands", new DateTime(1980, 6, 14, 21, 58, 13, 13, DateTimeKind.Utc).AddTicks(5270), 999.784720663738000m, "Matt_Schiller63@hotmail.com", "Brennan", 700m, 858, "Fugiat consequatur.", "1-883-851-1956 x8238", "Ryan" },
                    { new Guid("8154b6fb-c2de-104e-a841-a0cd2f323ca7"), "Mongolia", new DateTime(1931, 2, 5, 13, 35, 7, 872, DateTimeKind.Utc).AddTicks(5832), 79.7284068456132000m, "Bethel20@gmail.com", "Eudora", 900m, 733, "Non enim.", "917-312-1732 x34232", "Braun" },
                    { new Guid("816fede8-49b2-29d3-f3c4-75e07d28e3bd"), "Saint Helena", new DateTime(2006, 11, 3, 12, 38, 52, 258, DateTimeKind.Utc).AddTicks(1583), 894.295469157542000m, "Adeline.Stamm@hotmail.com", "Westley", 700m, 406, "Quae sit.", "747.949.3250", "Collins" },
                    { new Guid("81b20841-30b5-8c97-db58-669a196fab20"), "Vietnam", new DateTime(1951, 1, 30, 17, 12, 48, 691, DateTimeKind.Utc).AddTicks(4034), 918.943181391966000m, "Vernon_Carroll9@yahoo.com", "Bulah", 800m, 632, "Quis minus.", "1-453-792-5953 x1666", "O'Connell" },
                    { new Guid("82134279-cc02-e698-b80b-8764963d2af3"), "Lao People's Democratic Republic", new DateTime(1941, 6, 30, 12, 53, 41, 533, DateTimeKind.Utc).AddTicks(5953), 742.746233816968000m, "Angelina_Gerhold60@gmail.com", "Sven", 1000m, 146, "Quod non.", "494.559.2733 x37780", "Bruen" },
                    { new Guid("8215da26-1fd3-34ac-04f1-8afed3b9a297"), "Afghanistan", new DateTime(1954, 3, 6, 3, 52, 55, 194, DateTimeKind.Utc).AddTicks(1053), 649.260783763518000m, "Tara_Bogisich8@hotmail.com", "Emmy", 500m, 732, "Enim quia.", "1-320-909-2093 x1062", "Schaefer" },
                    { new Guid("82b1324e-d296-3608-28d8-8e2c22e03d49"), "Serbia", new DateTime(1934, 12, 26, 0, 6, 8, 193, DateTimeKind.Utc).AddTicks(9803), 703.428396656098000m, "Wilford23@yahoo.com", "Jaqueline", 1000m, 780, "Modi labore.", "1-649-475-8961", "Altenwerth" },
                    { new Guid("82b8c03a-c98e-2e68-dc97-efe9968fc721"), "Timor-Leste", new DateTime(1970, 7, 19, 22, 41, 6, 772, DateTimeKind.Utc).AddTicks(5542), 604.138969571092000m, "Greyson_Huel13@gmail.com", "Kameron", 500m, 863, "Fugit fugiat.", "359.461.4907", "O'Connell" },
                    { new Guid("82cc35ae-11c6-1457-e813-1cc28184248b"), "Kyrgyz Republic", new DateTime(1993, 1, 11, 13, 52, 36, 729, DateTimeKind.Utc).AddTicks(1557), 653.639433883168000m, "Mara_Heathcote@yahoo.com", "Darlene", 800m, 819, "Dolore impedit.", "1-471-472-4482 x7386", "Runolfsson" },
                    { new Guid("82e7a79a-e740-3f9f-5564-1df5f69a0943"), "Philippines", new DateTime(1948, 5, 23, 16, 26, 54, 61, DateTimeKind.Utc).AddTicks(6496), 81.7920589029375000m, "Helen18@hotmail.com", "Viola", 900m, 260, "Doloremque eveniet.", "376.343.7338 x685", "Boyle" },
                    { new Guid("82e811be-b0c2-4c1d-7525-3501849e6720"), "Tunisia", new DateTime(1960, 11, 18, 15, 5, 56, 773, DateTimeKind.Utc).AddTicks(7568), 345.237114159401000m, "Rhea.Tremblay@yahoo.com", "Jazlyn", 800m, 82, "Sit alias.", "488-563-5158 x41369", "Heller" },
                    { new Guid("8352a451-c2c0-17d3-1ac8-12140a9eb21c"), "Fiji", new DateTime(1966, 9, 29, 18, 5, 31, 576, DateTimeKind.Utc).AddTicks(9527), 244.396244540448000m, "Khalid_Stark@gmail.com", "Nova", 800m, 272, "Asperiores rerum.", "901.217.1157", "Frami" },
                    { new Guid("835c4db8-9da0-1dad-954f-eb497a8d9563"), "Micronesia", new DateTime(1990, 3, 28, 7, 50, 45, 512, DateTimeKind.Utc).AddTicks(9782), 3.90836533020367000m, "Adrain74@yahoo.com", "Trinity", 600m, 847, "Modi laboriosam.", "413.201.2263 x410", "Pfeffer" },
                    { new Guid("83a44ef9-6be8-c0f8-bb3b-0f09c95a3f60"), "Wallis and Futuna", new DateTime(1941, 2, 11, 0, 8, 12, 191, DateTimeKind.Utc).AddTicks(1661), 255.104068257257000m, "Cooper.Goldner10@gmail.com", "Joseph", 600m, 748, "Cupiditate omnis.", "(316) 795-7955", "Watsica" },
                    { new Guid("83d3b504-23b3-4e7e-0c0a-d17bfa5e99c6"), "Georgia", new DateTime(1941, 2, 22, 4, 47, 8, 557, DateTimeKind.Utc).AddTicks(4413), 983.235097941556000m, "Dedric.Shanahan54@hotmail.com", "Angie", 900m, 135, "Distinctio quas.", "1-879-475-2802", "Mann" },
                    { new Guid("845f8ed2-2e54-7082-553c-64d12acd529a"), "Norfolk Island", new DateTime(1957, 12, 22, 2, 21, 52, 330, DateTimeKind.Utc).AddTicks(725), 328.94669828752000m, "Ryder.Prosacco@hotmail.com", "Levi", 900m, 314, "Qui et.", "639-500-0429 x19401", "Haley" },
                    { new Guid("846fc437-9ef1-59d4-1083-1d9422fec194"), "Croatia", new DateTime(1965, 11, 23, 1, 48, 46, 316, DateTimeKind.Utc).AddTicks(3521), 207.600789067739000m, "Gavin14@hotmail.com", "Agnes", 600m, 677, "Dolor molestias.", "1-945-202-9810", "Schinner" },
                    { new Guid("84bc14d9-cf8c-59e6-d30c-748aeec20a79"), "Lesotho", new DateTime(2001, 5, 26, 3, 9, 33, 962, DateTimeKind.Utc).AddTicks(2033), 729.614624116022000m, "Wilber.Klein68@yahoo.com", "Alena", 500m, 590, "Reprehenderit in.", "1-268-889-9593 x435", "Stiedemann" },
                    { new Guid("8541d29e-b123-3bb8-72b4-da9db91ff248"), "Grenada", new DateTime(1992, 2, 4, 15, 31, 19, 117, DateTimeKind.Utc).AddTicks(5122), 260.368088674541000m, "Jaunita.Stehr@yahoo.com", "Kristy", 500m, 43, "Vitae et.", "(442) 895-8726", "Hermiston" },
                    { new Guid("85787e47-5375-a481-214b-64ef18b66884"), "Kazakhstan", new DateTime(1950, 10, 17, 18, 22, 53, 239, DateTimeKind.Utc).AddTicks(4900), 950.885361739918000m, "Norma.Towne83@yahoo.com", "Freida", 800m, 869, "Quidem nemo.", "376.291.2984 x685", "Heaney" },
                    { new Guid("859791ec-18c9-3b51-455a-f6e7e0de7366"), "Greenland", new DateTime(2009, 11, 20, 4, 51, 14, 397, DateTimeKind.Utc).AddTicks(9084), 643.904111101792000m, "Foster64@yahoo.com", "Javier", 1000m, 170, "Voluptas voluptas.", "494-898-5817", "Kub" },
                    { new Guid("85b2c482-3697-a8fb-366e-6c66bfaa3645"), "Lao People's Democratic Republic", new DateTime(1927, 12, 27, 10, 46, 42, 162, DateTimeKind.Utc).AddTicks(4325), 255.531748107449000m, "Jannie_Schaefer@hotmail.com", "German", 500m, 550, "Odio nihil.", "308-296-4366", "Batz" },
                    { new Guid("8622133f-230d-07a3-9677-3052b8ca2692"), "Liechtenstein", new DateTime(1998, 10, 3, 20, 21, 44, 774, DateTimeKind.Utc).AddTicks(9119), 771.909868713398000m, "Glen.Wintheiser@yahoo.com", "Cameron", 700m, 201, "Aut porro.", "1-377-324-0667", "Pacocha" },
                    { new Guid("868f1bde-4776-0618-f6f7-9bad06a41015"), "Tanzania", new DateTime(1971, 11, 11, 21, 56, 14, 6, DateTimeKind.Utc).AddTicks(6544), 975.328307634065000m, "Benjamin_Stokes44@gmail.com", "Ward", 800m, 435, "Repudiandae molestiae.", "311-234-0584", "Kuhlman" },
                    { new Guid("86c82461-fd0a-99ec-e2eb-6ac822c9726e"), "Cyprus", new DateTime(1962, 5, 20, 14, 38, 39, 170, DateTimeKind.Utc).AddTicks(5522), 619.450449315317000m, "Nyah19@yahoo.com", "Milo", 500m, 661, "Neque est.", "248.483.5806 x943", "White" },
                    { new Guid("8735a91f-77c5-8bc8-a80c-40c62bf74b10"), "Belize", new DateTime(1979, 11, 22, 6, 27, 57, 740, DateTimeKind.Utc).AddTicks(5090), 35.6277838707462000m, "Will_Effertz31@hotmail.com", "Houston", 700m, 336, "Dolor est.", "991.880.0916 x327", "Abernathy" },
                    { new Guid("875ca2a1-9233-e6f9-6b51-c96c840d9ccc"), "Palau", new DateTime(2020, 10, 26, 23, 11, 27, 420, DateTimeKind.Utc).AddTicks(2570), 324.39274498923000m, "Boris_Carroll19@hotmail.com", "Judge", 600m, 964, "Harum eveniet.", "1-507-267-3263", "Daugherty" },
                    { new Guid("8767610c-5c68-9372-ec62-4583edd1e1f8"), "Hungary", new DateTime(1942, 12, 11, 0, 6, 37, 887, DateTimeKind.Utc).AddTicks(6508), 982.691677682769000m, "Sadie4@gmail.com", "Rosella", 800m, 785, "Dolor aut.", "645-225-5599 x4097", "Tromp" },
                    { new Guid("87743ae9-78b6-a274-df11-a924684f9acb"), "Austria", new DateTime(1984, 2, 20, 22, 11, 44, 115, DateTimeKind.Utc).AddTicks(8929), 435.33587303003000m, "Carroll.Roob27@hotmail.com", "Lula", 1000m, 987, "Non qui.", "432.454.6575 x1784", "Huel" },
                    { new Guid("87951618-5ccc-bf6a-a977-a5488a805bff"), "Malaysia", new DateTime(1971, 2, 17, 11, 30, 16, 466, DateTimeKind.Utc).AddTicks(1531), 48.8943033342187000m, "Barton.Schuppe60@gmail.com", "Celia", 900m, 2, "Quod sint.", "1-752-313-2862", "Gibson" },
                    { new Guid("87d6fe7a-c79c-4bf0-dc37-9fad9e66bca6"), "France", new DateTime(1963, 6, 26, 15, 4, 54, 348, DateTimeKind.Utc).AddTicks(7553), 94.4323785503941000m, "Kenya_Jenkins@gmail.com", "Betsy", 600m, 991, "Et sit.", "392.864.1633 x29155", "Konopelski" },
                    { new Guid("87e5b503-e303-471e-a614-9d8b587a36b2"), "Mali", new DateTime(1998, 12, 12, 0, 38, 8, 555, DateTimeKind.Utc).AddTicks(8776), 212.72565137037000m, "Deondre.Heaney57@hotmail.com", "Anna", 500m, 577, "Id incidunt.", "323-708-9005", "Cummerata" },
                    { new Guid("88c8a218-7ac9-5063-859e-0d884212ea61"), "Guinea", new DateTime(1965, 6, 28, 5, 18, 47, 176, DateTimeKind.Utc).AddTicks(9234), 803.416077351146000m, "Kenyatta.King50@gmail.com", "Leonie", 600m, 404, "Quia cum.", "(758) 223-5268", "Davis" },
                    { new Guid("8945b4ef-b7bf-7161-d66a-470bff09e80d"), "Central African Republic", new DateTime(2004, 7, 5, 6, 22, 12, 612, DateTimeKind.Utc).AddTicks(4988), 50.3588106230616000m, "Andreane77@hotmail.com", "Rey", 800m, 68, "Quos expedita.", "(346) 483-9321", "Luettgen" },
                    { new Guid("8964d2e4-795d-7a5b-fb4c-4c693c9d5697"), "New Zealand", new DateTime(1969, 11, 17, 2, 34, 31, 313, DateTimeKind.Utc).AddTicks(8332), 28.4920314761841000m, "Travis.Kunde65@gmail.com", "Lynn", 700m, 855, "Quae libero.", "536.592.2001", "Marquardt" },
                    { new Guid("89daba21-3297-056f-af9e-4485b712ea4f"), "Suriname", new DateTime(1964, 5, 17, 16, 22, 37, 907, DateTimeKind.Utc).AddTicks(4427), 401.357334346463000m, "Jaylan_Thiel@yahoo.com", "Edyth", 500m, 291, "Minima tempore.", "(291) 713-2250 x6610", "Cremin" },
                    { new Guid("8a238b46-a90a-6568-7e6e-71172e373c08"), "Brazil", new DateTime(1934, 10, 22, 21, 56, 42, 568, DateTimeKind.Utc).AddTicks(2070), 915.493487886898000m, "Anais10@hotmail.com", "Lou", 900m, 316, "Architecto eos.", "288-978-6601", "Orn" },
                    { new Guid("8a34972e-2985-b5a5-da29-5acc4cdc97c8"), "Tonga", new DateTime(1981, 9, 15, 3, 12, 3, 536, DateTimeKind.Utc).AddTicks(7410), 240.601315528366000m, "Bulah98@yahoo.com", "Jewell", 600m, 830, "Rem ut.", "(733) 735-4771", "Fisher" },
                    { new Guid("8a97af3b-4b03-b8e1-4940-24979518a5a5"), "Uganda", new DateTime(1989, 2, 22, 15, 57, 18, 590, DateTimeKind.Utc).AddTicks(8723), 554.552510343897000m, "Coleman.Conroy@gmail.com", "Jessyca", 700m, 364, "Culpa veniam.", "914-782-5287 x35913", "Stokes" },
                    { new Guid("8ad7ed19-bc83-245c-9ab8-de9549588c9d"), "Morocco", new DateTime(2021, 1, 26, 16, 44, 14, 469, DateTimeKind.Utc).AddTicks(4224), 2.01800866313229000m, "Karson51@yahoo.com", "Kariane", 1000m, 537, "Sunt ullam.", "831-483-2798 x922", "Runolfsdottir" },
                    { new Guid("8ae17024-49a5-1a24-0dd6-e4ba70c3f5ee"), "Guam", new DateTime(1990, 8, 8, 18, 15, 58, 928, DateTimeKind.Utc).AddTicks(1678), 406.084991685379000m, "Clair_Schamberger80@yahoo.com", "Miles", 600m, 190, "Et cumque.", "519.626.6145 x592", "Marks" },
                    { new Guid("8ba252e1-a0c9-af10-a4e8-699b2200da24"), "Germany", new DateTime(1990, 4, 16, 12, 33, 8, 996, DateTimeKind.Utc).AddTicks(5428), 519.9579095758000m, "Hollie.Pfannerstill@hotmail.com", "Coty", 600m, 623, "Aut maiores.", "1-537-846-3136", "Zemlak" },
                    { new Guid("8bb13476-6fb2-c8f3-cd84-ad79473c68f7"), "Iceland", new DateTime(1929, 6, 21, 8, 16, 55, 784, DateTimeKind.Utc).AddTicks(21), 191.019892117765000m, "Quentin_Kshlerin@yahoo.com", "Kirsten", 1000m, 641, "Laboriosam placeat.", "938.897.2954 x565", "Kuphal" },
                    { new Guid("8bd9ea1b-e393-e5b5-ab78-3cfe72bc5dfa"), "Montenegro", new DateTime(1981, 7, 31, 22, 29, 42, 537, DateTimeKind.Utc).AddTicks(1784), 803.273699825549000m, "Eva83@yahoo.com", "Angel", 500m, 379, "Et dolore.", "969.723.9289", "Corwin" },
                    { new Guid("8bdf6e83-fc2a-9520-6753-c53978ed1a86"), "Somalia", new DateTime(1929, 6, 16, 10, 0, 6, 783, DateTimeKind.Utc).AddTicks(4997), 238.19128447033000m, "Boris23@hotmail.com", "Elmo", 700m, 168, "Consequatur itaque.", "(547) 793-9293", "Witting" },
                    { new Guid("8c263c63-da2c-7457-f30e-6cfad636cac3"), "Solomon Islands", new DateTime(1988, 2, 27, 23, 0, 40, 934, DateTimeKind.Utc).AddTicks(2278), 994.772104133268000m, "Cordie1@gmail.com", "Lorna", 800m, 803, "Repellendus eius.", "494.203.9678", "Wyman" },
                    { new Guid("8ca8b3b2-6c8c-c405-2ca4-5dab0f09d69b"), "Portugal", new DateTime(1997, 7, 22, 18, 11, 8, 942, DateTimeKind.Utc).AddTicks(8116), 754.313348351051000m, "Lonnie39@gmail.com", "Providenci", 500m, 27, "Iste qui.", "(921) 593-3360", "Weimann" },
                    { new Guid("8d105d34-e730-d2d4-0c49-7b0ce214aa4c"), "Seychelles", new DateTime(1942, 7, 13, 4, 42, 5, 975, DateTimeKind.Utc).AddTicks(8783), 303.051549896652000m, "Lance8@hotmail.com", "Reba", 800m, 157, "Accusamus et.", "929-254-2196", "Hegmann" },
                    { new Guid("8d2e3d0e-2f4a-4e2a-295e-3c6257794f78"), "United States Minor Outlying Islands", new DateTime(1949, 6, 26, 14, 50, 46, 59, DateTimeKind.Utc).AddTicks(2159), 131.977250780839000m, "Monty_Little65@hotmail.com", "Gabrielle", 800m, 465, "Necessitatibus eius.", "860.351.4122 x285", "Doyle" },
                    { new Guid("8d355578-c443-c27a-4888-27da91ee6d2b"), "Indonesia", new DateTime(2003, 4, 29, 13, 59, 51, 605, DateTimeKind.Utc).AddTicks(6986), 781.588355237141000m, "Felicia.Koch@yahoo.com", "Freeman", 600m, 16, "Soluta quia.", "227-602-8776 x680", "Ward" },
                    { new Guid("8d4f33bc-d146-ae4e-6a63-f14a4fa4a491"), "Macao", new DateTime(1975, 12, 17, 1, 53, 24, 487, DateTimeKind.Utc).AddTicks(3166), 158.85388980157000m, "Tommie.Schoen42@yahoo.com", "Leanne", 800m, 317, "Laborum delectus.", "389.416.7578 x001", "Borer" },
                    { new Guid("8d79cbb0-71d1-7bf6-e0f2-3bbef02c4f63"), "Falkland Islands (Malvinas)", new DateTime(1949, 8, 1, 0, 22, 25, 423, DateTimeKind.Utc).AddTicks(6734), 555.734086152973000m, "Monserrat.Goodwin@hotmail.com", "Malcolm", 800m, 195, "Natus beatae.", "(315) 268-6448 x957", "Conroy" },
                    { new Guid("8db30915-81ca-3301-3511-588882f3f60f"), "Marshall Islands", new DateTime(1990, 8, 6, 3, 13, 24, 805, DateTimeKind.Utc).AddTicks(4404), 130.717446409781000m, "Carmella_Schowalter@hotmail.com", "Stan", 800m, 910, "Numquam et.", "(269) 459-3526 x7391", "Conn" },
                    { new Guid("8dc4ffcf-051e-64a8-8fd4-cccdcf0c30d4"), "Virgin Islands, U.S.", new DateTime(1968, 11, 4, 8, 18, 18, 322, DateTimeKind.Utc).AddTicks(999), 358.146588547717000m, "Darrell_Dickinson@yahoo.com", "Gene", 800m, 815, "Similique deleniti.", "(713) 744-9720 x244", "Mertz" },
                    { new Guid("8de33e75-be6a-c416-1099-b5f788209951"), "Netherlands", new DateTime(1957, 2, 24, 0, 41, 3, 557, DateTimeKind.Utc).AddTicks(4646), 421.505107932568000m, "Lula.Funk5@hotmail.com", "Cole", 1000m, 395, "Omnis rerum.", "(979) 303-8371", "Hilll" },
                    { new Guid("8e3abc13-be73-e186-dbf0-2d39e8fa5514"), "Mozambique", new DateTime(1982, 7, 22, 10, 51, 18, 608, DateTimeKind.Utc).AddTicks(1428), 329.849918987586000m, "Shana35@hotmail.com", "Sonny", 700m, 460, "Officia repellat.", "428.268.0669 x5262", "Koss" },
                    { new Guid("8e535efc-dcf3-1bba-407e-ec0322e5fb3f"), "New Caledonia", new DateTime(2008, 9, 14, 12, 3, 43, 371, DateTimeKind.Utc).AddTicks(8319), 929.237995147894000m, "Marlon56@gmail.com", "Joelle", 500m, 172, "In voluptatem.", "1-470-704-5391 x294", "Feeney" },
                    { new Guid("8e9956c3-e006-59d7-d9fc-e1d9c18744a8"), "Montserrat", new DateTime(2018, 11, 19, 23, 27, 1, 725, DateTimeKind.Utc).AddTicks(5493), 715.732374219536000m, "Lexi_Bartell31@gmail.com", "Jaeden", 1000m, 77, "Est aliquid.", "213-310-7544 x14514", "Schoen" },
                    { new Guid("8ee29a27-87a3-bc15-d7ae-6ffee6f18dd8"), "South Africa", new DateTime(2014, 11, 6, 10, 52, 5, 500, DateTimeKind.Utc).AddTicks(1938), 993.875091994335000m, "Cordie.Harvey@gmail.com", "Jacquelyn", 700m, 241, "Eveniet veritatis.", "1-566-358-4990 x1119", "Bruen" },
                    { new Guid("8f42cf41-9577-d457-1e55-76c039d10867"), "Swaziland", new DateTime(1988, 10, 30, 3, 44, 29, 85, DateTimeKind.Utc).AddTicks(7294), 513.96712722357000m, "Janie.Schulist@gmail.com", "Norval", 800m, 885, "Ad tenetur.", "684.597.9391", "Casper" },
                    { new Guid("8f9e9e1c-9607-0f6b-107c-213b9010a130"), "Cuba", new DateTime(1996, 12, 22, 22, 32, 23, 881, DateTimeKind.Utc).AddTicks(1056), 809.576593406237000m, "Jasen18@gmail.com", "Bethel", 900m, 102, "Eum voluptas.", "864.473.3759", "Boyer" },
                    { new Guid("8fe89587-e6d8-71ed-14bb-ab3bf0cfbff5"), "Cambodia", new DateTime(1978, 1, 22, 18, 52, 41, 876, DateTimeKind.Utc).AddTicks(9103), 893.071440431722000m, "Adolph15@hotmail.com", "Alyson", 800m, 286, "Maxime deserunt.", "549.371.4114", "Hyatt" },
                    { new Guid("90065049-d406-db5e-47e9-898e13d8678d"), "Swaziland", new DateTime(1969, 8, 1, 10, 6, 32, 687, DateTimeKind.Utc).AddTicks(3092), 98.7121029733588000m, "Lindsey.Dickinson64@yahoo.com", "Braden", 600m, 534, "Veritatis dicta.", "1-452-466-5043 x0411", "Farrell" },
                    { new Guid("90d0611f-97c7-347a-0bde-20d8b529560e"), "Ireland", new DateTime(1945, 11, 1, 7, 59, 33, 465, DateTimeKind.Utc).AddTicks(4042), 198.783616129525000m, "Cornelius_Senger19@hotmail.com", "Florida", 500m, 416, "Non nam.", "573-964-6775 x02323", "Doyle" },
                    { new Guid("90ec991a-c48a-7d8a-cdca-315a096cb77e"), "Kazakhstan", new DateTime(1967, 6, 20, 9, 23, 37, 183, DateTimeKind.Utc).AddTicks(5736), 471.975146819611000m, "Royal_OKon67@yahoo.com", "Alberta", 1000m, 432, "Temporibus fugiat.", "(503) 833-3591 x640", "Langworth" },
                    { new Guid("917ce8c4-2bd9-a4e1-dd8b-6288e69e90ea"), "Chad", new DateTime(1967, 10, 24, 2, 45, 9, 75, DateTimeKind.Utc).AddTicks(4019), 755.10593320368000m, "Dorthy_Treutel83@gmail.com", "Horace", 1000m, 403, "Perspiciatis nihil.", "(718) 695-9716 x6708", "Bahringer" },
                    { new Guid("9185acf1-0e10-9731-b31f-8c62b90f68cd"), "Dominica", new DateTime(2006, 5, 20, 11, 12, 33, 613, DateTimeKind.Utc).AddTicks(549), 335.226353270399000m, "Lucie.Zulauf@hotmail.com", "Daryl", 700m, 499, "Vel doloribus.", "(422) 211-2819 x5359", "Raynor" },
                    { new Guid("91a375d6-6236-34ab-ca17-e7447b077588"), "Thailand", new DateTime(2016, 5, 7, 1, 31, 56, 779, DateTimeKind.Utc).AddTicks(5776), 417.777392187438000m, "Alayna.Collins@yahoo.com", "Tatum", 1000m, 556, "Mollitia nobis.", "789.235.6371 x476", "Stiedemann" },
                    { new Guid("91b2cb8b-310a-24f8-bdb1-4f4bb5aea418"), "Algeria", new DateTime(1992, 8, 18, 14, 17, 20, 78, DateTimeKind.Utc).AddTicks(9712), 974.485932539416000m, "Emmalee_Dickinson44@gmail.com", "Meagan", 600m, 956, "Assumenda ducimus.", "(509) 769-6568 x914", "Schaefer" },
                    { new Guid("91f38fa6-b2d4-e273-ea51-aa8b58549b1a"), "Egypt", new DateTime(1963, 8, 31, 23, 13, 50, 269, DateTimeKind.Utc).AddTicks(2544), 913.355944006494000m, "Alexzander45@yahoo.com", "Alia", 900m, 71, "Illum esse.", "1-510-537-3325 x076", "Walker" },
                    { new Guid("920e88a9-8000-6a87-a8cf-976f3b3131ec"), "Mali", new DateTime(1929, 4, 20, 7, 26, 29, 10, DateTimeKind.Utc).AddTicks(222), 220.980549688401000m, "Stacy.Anderson72@hotmail.com", "Margret", 1000m, 831, "Cupiditate laborum.", "345-624-1985 x890", "Roob" },
                    { new Guid("9225dd17-d947-74a7-dced-23c86728aa6b"), "Guinea-Bissau", new DateTime(1946, 7, 15, 6, 16, 54, 96, DateTimeKind.Utc).AddTicks(8598), 520.697041324466000m, "Haven_Vandervort52@gmail.com", "Nicola", 600m, 67, "Aut nobis.", "898-635-5040 x9844", "Breitenberg" },
                    { new Guid("92ac0723-eb26-74d1-a3cc-2324a2d30843"), "Somalia", new DateTime(1956, 8, 16, 23, 16, 17, 775, DateTimeKind.Utc).AddTicks(1667), 813.024715332912000m, "Clarabelle.Johnston56@yahoo.com", "Lacey", 900m, 986, "Beatae et.", "1-326-488-1210 x0290", "Wilderman" },
                    { new Guid("92b4440d-abb2-3ffe-626e-0338e5880ea3"), "Togo", new DateTime(1981, 9, 8, 19, 46, 54, 245, DateTimeKind.Utc).AddTicks(3819), 853.264986964787000m, "Zita58@hotmail.com", "Jefferey", 500m, 981, "Facere et.", "412.660.9664", "Goldner" },
                    { new Guid("93f4e90d-55d1-99bd-ed19-bb92095e9d2b"), "Algeria", new DateTime(1966, 6, 4, 11, 55, 56, 874, DateTimeKind.Utc).AddTicks(7782), 971.150756086421000m, "Brielle.Hahn52@hotmail.com", "Wilber", 900m, 594, "Cumque provident.", "1-774-894-1838", "Koss" },
                    { new Guid("944b1537-eff1-b7e8-5d93-10d70b477194"), "Ghana", new DateTime(2019, 4, 1, 8, 38, 16, 193, DateTimeKind.Utc).AddTicks(9644), 388.643039856511000m, "Elisabeth94@gmail.com", "Jasper", 500m, 783, "Quibusdam facere.", "1-764-497-7930 x1826", "Dare" },
                    { new Guid("945c381a-e5fe-d33c-13c7-bf4fbdc2562a"), "Somalia", new DateTime(1945, 11, 6, 10, 2, 4, 706, DateTimeKind.Utc).AddTicks(8983), 725.53694547666000m, "Elsa73@yahoo.com", "Jerrod", 500m, 231, "Autem corrupti.", "(962) 583-2305 x0000", "Moen" },
                    { new Guid("946337e9-c879-b1b9-d397-0eec46d8d238"), "Cambodia", new DateTime(1939, 9, 29, 17, 16, 18, 369, DateTimeKind.Utc).AddTicks(1094), 897.826846488242000m, "Vicenta.Hodkiewicz@gmail.com", "Chauncey", 900m, 418, "Et et.", "902-995-9745 x372", "Mohr" },
                    { new Guid("94cf5ae0-0190-b102-45ec-2bdbc7c2d2c8"), "Myanmar", new DateTime(1983, 9, 16, 1, 50, 53, 397, DateTimeKind.Utc).AddTicks(5672), 326.480486739942000m, "Mallie.Russel@gmail.com", "Hillard", 800m, 544, "Sunt sed.", "503-996-5040 x618", "Cormier" },
                    { new Guid("95e71f00-c449-67af-427c-e70b45ab9ec1"), "Holy See (Vatican City State)", new DateTime(1972, 2, 24, 18, 26, 2, 215, DateTimeKind.Utc).AddTicks(9947), 472.357757833228000m, "Yvette_Cassin@gmail.com", "Carmel", 800m, 450, "In quo.", "518-325-0805", "Parisian" },
                    { new Guid("9631f3fb-8203-701f-f084-c38175ec4306"), "Ireland", new DateTime(1936, 5, 28, 4, 50, 23, 290, DateTimeKind.Utc).AddTicks(3615), 946.78598819869000m, "Viviane7@yahoo.com", "Cesar", 1000m, 313, "Autem cum.", "287-905-1857", "Littel" },
                    { new Guid("965785e4-6da1-f2aa-5047-301cb086f912"), "Afghanistan", new DateTime(1988, 9, 19, 15, 56, 50, 565, DateTimeKind.Utc).AddTicks(8226), 352.252136653138000m, "Alivia82@gmail.com", "Scot", 600m, 937, "Accusamus in.", "(474) 389-8762 x558", "Parker" },
                    { new Guid("96a43c82-f459-fcad-bdd7-baea0f09b3ec"), "Albania", new DateTime(1953, 1, 18, 13, 22, 27, 84, DateTimeKind.Utc).AddTicks(7544), 371.383971498481000m, "Mary8@gmail.com", "Itzel", 1000m, 310, "Consequatur quos.", "(855) 250-6936", "Barrows" },
                    { new Guid("970f2862-4ead-779b-2c7a-85ef40674670"), "Lebanon", new DateTime(1966, 3, 26, 20, 21, 45, 778, DateTimeKind.Utc).AddTicks(16), 104.849799660953000m, "Lola.Robel@yahoo.com", "Demarco", 800m, 652, "Ducimus optio.", "519.507.4809", "Crooks" },
                    { new Guid("97751adb-12f4-b3a6-0f45-0ac1e0589782"), "Trinidad and Tobago", new DateTime(1956, 11, 13, 11, 39, 14, 430, DateTimeKind.Utc).AddTicks(3884), 133.543218385713000m, "Roderick.Fisher39@hotmail.com", "Halle", 700m, 191, "Debitis eum.", "(959) 783-4725", "Koss" },
                    { new Guid("97de49e7-fe9e-cae7-d4aa-71ced959f7f2"), "Oman", new DateTime(2014, 3, 14, 10, 21, 7, 381, DateTimeKind.Utc).AddTicks(352), 187.304173089858000m, "Caleigh35@yahoo.com", "Kyla", 800m, 278, "Veritatis in.", "917-438-1892 x412", "McKenzie" },
                    { new Guid("97f28248-45ba-25ff-6a0b-1a9855aa0a8c"), "Slovakia (Slovak Republic)", new DateTime(1979, 7, 25, 19, 12, 31, 600, DateTimeKind.Utc).AddTicks(7469), 446.050006394542000m, "Gage_Crona@yahoo.com", "Elbert", 900m, 967, "Velit voluptas.", "676.297.9421 x67731", "Schinner" },
                    { new Guid("97f4d58b-e375-f8ea-fb9e-52d86ead602d"), "Brunei Darussalam", new DateTime(1933, 10, 24, 1, 22, 50, 168, DateTimeKind.Utc).AddTicks(9970), 707.684593654381000m, "Nicolette96@yahoo.com", "Sydney", 800m, 851, "Sit in.", "1-469-824-3495", "Turcotte" },
                    { new Guid("97f82900-874e-fd7b-b38f-881404a6c7e3"), "Estonia", new DateTime(1969, 7, 29, 20, 34, 28, 433, DateTimeKind.Utc).AddTicks(4461), 769.326687737274000m, "Annetta.Moore63@gmail.com", "Destin", 900m, 866, "Ab animi.", "1-374-271-7603", "Blick" },
                    { new Guid("98734065-0a6e-5b7d-a569-3f22695f4e7f"), "Virgin Islands, British", new DateTime(1972, 5, 6, 11, 17, 16, 325, DateTimeKind.Utc).AddTicks(3117), 795.749637803624000m, "Marion_Hammes@hotmail.com", "Earnestine", 600m, 340, "Similique enim.", "1-324-460-7561 x4773", "Lowe" },
                    { new Guid("9878dbf8-2f9b-4743-7bfb-efd29da02292"), "Timor-Leste", new DateTime(2023, 5, 18, 15, 49, 26, 451, DateTimeKind.Utc).AddTicks(6580), 437.089155718966000m, "Kailey_Kuhlman@yahoo.com", "Calista", 500m, 287, "Similique pariatur.", "1-556-451-8742", "Dietrich" },
                    { new Guid("98803569-aad6-1386-0e36-c827c95d21cd"), "Mali", new DateTime(1971, 12, 16, 19, 32, 9, 589, DateTimeKind.Utc).AddTicks(8501), 972.88807333363000m, "Jakayla37@gmail.com", "Eric", 600m, 745, "Suscipit sint.", "925-750-4025", "Langworth" },
                    { new Guid("988c3e91-e54a-1cb4-bf91-8fc05e309206"), "Netherlands Antilles", new DateTime(1947, 1, 2, 16, 51, 11, 58, DateTimeKind.Utc).AddTicks(3198), 657.0747530294000m, "Remington.Leannon@hotmail.com", "Casper", 900m, 740, "Illum et.", "454.413.1229 x17198", "Armstrong" },
                    { new Guid("98bb1f94-6fe4-b3cd-8e63-f55ff4ac60e3"), "Pakistan", new DateTime(1968, 2, 1, 0, 16, 20, 450, DateTimeKind.Utc).AddTicks(8023), 827.494841920283000m, "Earlene.Greenholt12@yahoo.com", "Clement", 900m, 588, "Occaecati dolor.", "1-663-452-1448 x6771", "Schaefer" },
                    { new Guid("98f3c2d4-0c5a-2029-41a7-f98f419eaae7"), "United States Minor Outlying Islands", new DateTime(1955, 6, 9, 10, 39, 42, 119, DateTimeKind.Utc).AddTicks(8716), 701.791514394075000m, "Carolina71@hotmail.com", "Rowan", 1000m, 518, "Magnam nobis.", "315.248.9650 x734", "Murray" },
                    { new Guid("9943d578-81c1-29d3-5221-d5d0d0cc8710"), "Ecuador", new DateTime(2001, 5, 23, 7, 59, 38, 244, DateTimeKind.Utc).AddTicks(2259), 714.432153967113000m, "Richard55@yahoo.com", "Nels", 600m, 457, "Fuga eum.", "582-853-7365 x637", "McClure" },
                    { new Guid("994f6b23-968b-59bf-fef2-8c222ca83597"), "Taiwan", new DateTime(1966, 11, 20, 1, 53, 59, 150, DateTimeKind.Utc).AddTicks(9286), 871.502541956659000m, "Tito_Pacocha18@yahoo.com", "Willow", 1000m, 256, "Enim ut.", "1-800-848-1355 x5414", "Langworth" },
                    { new Guid("9994174e-c11f-1bc1-de9f-72460d94ccaa"), "Bahamas", new DateTime(1987, 4, 28, 10, 28, 29, 985, DateTimeKind.Utc).AddTicks(263), 864.061957527611000m, "Evie29@hotmail.com", "Imogene", 500m, 385, "Dolores aut.", "1-535-491-2646 x684", "Nitzsche" },
                    { new Guid("99aeea9e-6b2e-f9bc-ec82-835311c3cd13"), "Congo", new DateTime(1994, 12, 24, 17, 43, 11, 58, DateTimeKind.Utc).AddTicks(1418), 863.395594082822000m, "Florence40@hotmail.com", "Mckenzie", 1000m, 591, "Excepturi magnam.", "1-381-423-8177 x307", "Weimann" },
                    { new Guid("99df2e51-d0ff-85f2-07dd-f4d69cca1ce1"), "Cambodia", new DateTime(1996, 11, 18, 7, 7, 25, 381, DateTimeKind.Utc).AddTicks(9403), 147.373600672098000m, "Liza_Ward58@gmail.com", "Ursula", 800m, 42, "Nulla similique.", "1-979-731-2612", "Hauck" },
                    { new Guid("99e2ecb5-1b40-f8f4-053c-b4ce04947481"), "Swaziland", new DateTime(1930, 6, 4, 0, 9, 3, 260, DateTimeKind.Utc).AddTicks(4597), 631.999222860083000m, "Sam.Zieme@hotmail.com", "Joseph", 800m, 73, "Repellendus autem.", "480-977-9097 x7328", "Leffler" },
                    { new Guid("9a3ffb29-2eb5-a754-e552-53c699b3744b"), "Fiji", new DateTime(2018, 7, 23, 2, 9, 4, 335, DateTimeKind.Utc).AddTicks(6245), 920.323472507202000m, "Madeline_Wyman@yahoo.com", "Joshuah", 500m, 628, "Ut officiis.", "217.967.0400", "Schmeler" },
                    { new Guid("9ace82d0-9df2-7ea8-53c4-ed9286bf169e"), "India", new DateTime(1980, 8, 26, 15, 18, 45, 302, DateTimeKind.Utc).AddTicks(9762), 715.795106723576000m, "Cullen36@gmail.com", "Aracely", 600m, 266, "Voluptate modi.", "736.465.0374", "Mann" },
                    { new Guid("9b07a9b9-acae-1740-7977-3ba2a6fb2df0"), "Moldova", new DateTime(1972, 10, 4, 4, 9, 41, 969, DateTimeKind.Utc).AddTicks(8799), 115.140628634315000m, "Mable_Leannon0@yahoo.com", "Norwood", 700m, 47, "Consequatur reiciendis.", "887-700-6581 x016", "Hyatt" },
                    { new Guid("9b10f398-0747-a522-30be-6e1cdd6287b3"), "Singapore", new DateTime(1956, 1, 19, 23, 47, 45, 342, DateTimeKind.Utc).AddTicks(4161), 300.829039369646000m, "Anastacio82@yahoo.com", "Tommie", 600m, 345, "Ea commodi.", "215-860-5291", "Conn" },
                    { new Guid("9b1d0431-8f62-25c7-230a-856ddb0814cd"), "Bahrain", new DateTime(1999, 8, 18, 19, 17, 36, 686, DateTimeKind.Utc).AddTicks(7729), 268.132944913157000m, "Keshaun_Bogisich@gmail.com", "Dustin", 800m, 458, "Autem reiciendis.", "1-455-944-2213 x959", "Leffler" },
                    { new Guid("9bbdb29c-d757-5823-36b7-352cbbdc8412"), "Kenya", new DateTime(1972, 12, 14, 6, 42, 10, 763, DateTimeKind.Utc).AddTicks(4334), 962.272279198406000m, "Brooke.Feest37@hotmail.com", "Deonte", 500m, 429, "Labore eveniet.", "488-987-7667 x01269", "Balistreri" },
                    { new Guid("9bce9681-8454-acc2-35ed-fd4a98542570"), "Luxembourg", new DateTime(1971, 3, 12, 0, 18, 22, 880, DateTimeKind.Utc).AddTicks(5484), 768.737010102636000m, "Tessie26@hotmail.com", "Gabe", 1000m, 805, "Aut sint.", "1-206-694-7139 x210", "Nicolas" },
                    { new Guid("9c27ed1c-222b-1e6c-318d-088088bfc4ad"), "Benin", new DateTime(2009, 9, 26, 22, 19, 57, 649, DateTimeKind.Utc).AddTicks(716), 367.162850930717000m, "Chelsea.Keebler@gmail.com", "Bridie", 1000m, 370, "Ut et.", "1-255-239-5046", "Deckow" },
                    { new Guid("9c9c38de-4a7a-e079-1fd1-f4cf55815c0a"), "Spain", new DateTime(1950, 8, 22, 9, 5, 36, 287, DateTimeKind.Utc).AddTicks(9178), 926.952770841988000m, "Aglae_Dickens@yahoo.com", "Colten", 1000m, 827, "Velit reiciendis.", "(762) 498-1577", "Mayer" },
                    { new Guid("9ca86d2e-e687-53cb-33d5-3530aeebf41f"), "Bangladesh", new DateTime(2014, 9, 3, 9, 44, 38, 903, DateTimeKind.Utc).AddTicks(8035), 83.4485493714196000m, "Sedrick.Kozey9@yahoo.com", "Joshua", 1000m, 629, "Aliquam voluptas.", "(734) 666-1339 x677", "Funk" },
                    { new Guid("9ca87510-1ff8-fef7-435f-37f118200663"), "India", new DateTime(1976, 7, 3, 18, 7, 56, 713, DateTimeKind.Utc).AddTicks(1280), 578.02965342017000m, "Charlene57@gmail.com", "Alize", 1000m, 811, "Qui nihil.", "(327) 564-1272", "Ferry" },
                    { new Guid("9cab906d-43eb-5bb2-f7af-209969f4d91a"), "Holy See (Vatican City State)", new DateTime(1962, 6, 8, 16, 10, 25, 425, DateTimeKind.Utc).AddTicks(834), 355.238333227091000m, "Kian_Feest14@hotmail.com", "Abel", 700m, 50, "Rerum consectetur.", "(445) 590-9744 x860", "Davis" },
                    { new Guid("9cbe9730-5fc3-b5cc-9a24-b2c5a07723d3"), "Mauritius", new DateTime(1932, 7, 29, 19, 5, 22, 49, DateTimeKind.Utc).AddTicks(320), 147.681019808538000m, "Mylene17@yahoo.com", "Peyton", 800m, 62, "Voluptatem nostrum.", "1-244-303-9806 x675", "Gorczany" },
                    { new Guid("9d7ba346-61f5-f502-746c-935901a8930b"), "Poland", new DateTime(1941, 7, 21, 8, 38, 25, 530, DateTimeKind.Utc).AddTicks(6955), 634.086849846091000m, "Beulah5@yahoo.com", "Allene", 600m, 579, "Quibusdam nam.", "(351) 775-7720", "Walker" },
                    { new Guid("9e478f28-476f-b3e1-7f6d-11414c6d2141"), "Madagascar", new DateTime(1996, 5, 15, 16, 14, 6, 722, DateTimeKind.Utc).AddTicks(6358), 253.638271507692000m, "Anya.Hegmann@gmail.com", "Leanna", 1000m, 565, "Voluptatum quidem.", "630-444-5289", "Gutmann" },
                    { new Guid("9e671a8b-7837-9e7f-c5b3-26c26b8ffb25"), "Uzbekistan", new DateTime(2017, 7, 12, 22, 10, 8, 238, DateTimeKind.Utc).AddTicks(8797), 718.065106450246000m, "Jakayla.Kertzmann@hotmail.com", "Audie", 900m, 561, "Sapiente aspernatur.", "752-858-4521 x0497", "Cruickshank" },
                    { new Guid("9e7aa956-50c8-f44c-2fe9-3c1d6dbe8b16"), "Malawi", new DateTime(1974, 11, 12, 2, 0, 55, 995, DateTimeKind.Utc).AddTicks(109), 710.542510943223000m, "Julian_Carter@yahoo.com", "Jordane", 800m, 245, "Deleniti eveniet.", "1-569-674-8820", "Murphy" },
                    { new Guid("9ee17f0a-b77d-ca8e-3b3f-7fb323f308c6"), "New Caledonia", new DateTime(2002, 8, 25, 23, 49, 2, 679, DateTimeKind.Utc).AddTicks(198), 167.016871264177000m, "Melisa_Satterfield@gmail.com", "Eriberto", 500m, 716, "Voluptatem nemo.", "1-541-841-5543 x0966", "Becker" },
                    { new Guid("9f9847ce-892c-762b-9704-48e91fc829d0"), "Gambia", new DateTime(1934, 11, 1, 13, 7, 56, 580, DateTimeKind.Utc).AddTicks(8648), 129.40212129239000m, "Gerardo_Kessler69@gmail.com", "Vinnie", 700m, 663, "Minus non.", "948-653-1295", "VonRueden" },
                    { new Guid("a0ad1d98-dc51-620a-cc58-5d96de57f75a"), "Sweden", new DateTime(1974, 4, 22, 17, 48, 9, 915, DateTimeKind.Utc).AddTicks(1822), 582.740327025619000m, "Marjorie53@hotmail.com", "Jaime", 900m, 31, "Consequuntur quia.", "897.561.4299 x9008", "Doyle" },
                    { new Guid("a0c80924-a337-0ec2-0dd3-1be133be8d89"), "Tonga", new DateTime(1930, 6, 13, 18, 24, 27, 346, DateTimeKind.Utc).AddTicks(3328), 10.8622751346007000m, "Orpha_Orn5@yahoo.com", "Kasandra", 700m, 601, "Quibusdam id.", "528-277-7002 x741", "Lehner" },
                    { new Guid("a0ed32c8-6f70-eafb-7484-79568e6c2e5d"), "Saint Kitts and Nevis", new DateTime(1984, 1, 9, 0, 46, 0, 601, DateTimeKind.Utc).AddTicks(9494), 177.506665953875000m, "Cesar.Stoltenberg@hotmail.com", "Bria", 800m, 693, "Nisi nihil.", "682-430-3214", "Littel" },
                    { new Guid("a10b00a9-e0f0-31bf-2886-c4226ac1c1b5"), "Afghanistan", new DateTime(1993, 7, 17, 23, 42, 41, 218, DateTimeKind.Utc).AddTicks(6970), 700.027454044704000m, "Kenton.Kerluke@hotmail.com", "Eleanore", 900m, 209, "Eligendi quae.", "793-474-7447", "Daugherty" },
                    { new Guid("a13a18b0-a5fb-b8c2-1511-3e5a688d0199"), "Timor-Leste", new DateTime(1983, 7, 12, 4, 6, 18, 981, DateTimeKind.Utc).AddTicks(5536), 67.0113660993386000m, "Esperanza76@gmail.com", "Nelson", 800m, 818, "Rerum sunt.", "1-470-912-2616 x657", "Ullrich" },
                    { new Guid("a1418834-2f4e-b10a-ea89-d142912f4f62"), "Iran", new DateTime(1945, 1, 24, 23, 56, 12, 806, DateTimeKind.Utc).AddTicks(5437), 196.133510013851000m, "Davonte_Emmerich@gmail.com", "Kelly", 800m, 5, "Et enim.", "872.831.8084", "Grimes" },
                    { new Guid("a191afbc-72ff-bde8-4761-2466a2176719"), "India", new DateTime(1950, 8, 22, 0, 26, 33, 209, DateTimeKind.Utc).AddTicks(3234), 983.866811605443000m, "Amya48@yahoo.com", "Beulah", 900m, 229, "Rerum libero.", "(787) 245-3677 x3667", "Swaniawski" },
                    { new Guid("a19480f3-bdba-6247-2b0b-ef6b5c1bb178"), "Jordan", new DateTime(1979, 9, 4, 9, 34, 44, 709, DateTimeKind.Utc).AddTicks(2356), 794.240601453472000m, "Nicole.Kuhn32@yahoo.com", "Jamarcus", 600m, 64, "Velit velit.", "(455) 994-2050 x618", "Marks" },
                    { new Guid("a1d216e5-1704-c704-72d6-ad46f882690c"), "Cyprus", new DateTime(2003, 12, 16, 14, 51, 50, 521, DateTimeKind.Utc).AddTicks(2512), 184.401906724491000m, "Rex.Champlin@hotmail.com", "Jamal", 500m, 200, "Ea consequatur.", "780.672.9083 x936", "Pfannerstill" },
                    { new Guid("a1d45f1b-84be-7839-f874-10117f33ff95"), "Saint Martin", new DateTime(1962, 3, 7, 6, 24, 32, 710, DateTimeKind.Utc).AddTicks(5052), 138.275477735258000m, "Clare.Denesik54@hotmail.com", "Audrey", 1000m, 194, "Veritatis ratione.", "1-641-489-8828 x4752", "Beahan" },
                    { new Guid("a1de40e2-792f-bc64-feaf-b7ba8f5319e6"), "Egypt", new DateTime(1950, 3, 9, 18, 27, 37, 847, DateTimeKind.Utc).AddTicks(8870), 231.902663816292000m, "Krista.Schoen@hotmail.com", "Jules", 900m, 173, "Laudantium et.", "(851) 432-9836", "Hoppe" },
                    { new Guid("a27798ca-97c1-3df2-71d2-a10654649969"), "Guadeloupe", new DateTime(1959, 7, 12, 3, 14, 54, 815, DateTimeKind.Utc).AddTicks(6757), 520.984436321083000m, "Ulises_Cummerata@hotmail.com", "Jerry", 700m, 757, "Non voluptatem.", "451.681.2910 x932", "Jerde" },
                    { new Guid("a299b992-feff-499b-9377-49e6b4897e26"), "Tuvalu", new DateTime(1985, 2, 28, 21, 4, 29, 479, DateTimeKind.Utc).AddTicks(314), 407.859971134286000m, "Chauncey16@gmail.com", "Jerome", 600m, 230, "Dolorem excepturi.", "(399) 588-9385 x4515", "Green" },
                    { new Guid("a29c2eac-c65c-b369-5636-546f9d5795ff"), "Aruba", new DateTime(1961, 8, 15, 10, 12, 13, 677, DateTimeKind.Utc).AddTicks(1678), 812.872176314178000m, "Micaela_Ankunding@hotmail.com", "Vanessa", 700m, 17, "Aspernatur ex.", "831.471.5964 x295", "Bayer" },
                    { new Guid("a2b667c4-73e2-5b39-94c5-b562b3e31b31"), "Samoa", new DateTime(1934, 8, 7, 16, 53, 18, 400, DateTimeKind.Utc).AddTicks(8123), 363.357172327936000m, "Annamae15@yahoo.com", "Arnaldo", 600m, 80, "Consectetur est.", "(673) 792-2673", "Kirlin" },
                    { new Guid("a2ff4933-6723-e913-c6eb-f820edd58e38"), "Anguilla", new DateTime(1998, 8, 15, 12, 0, 40, 601, DateTimeKind.Utc).AddTicks(2142), 970.523908080447000m, "Nicklaus.Medhurst@yahoo.com", "Jaiden", 500m, 599, "Sit pariatur.", "742-677-5245", "Zieme" },
                    { new Guid("a30c9e46-1078-8a21-855c-0d9582db9783"), "Tokelau", new DateTime(1929, 12, 4, 15, 36, 12, 503, DateTimeKind.Utc).AddTicks(6724), 339.257882695283000m, "Julia58@gmail.com", "Bo", 700m, 471, "Perspiciatis pariatur.", "1-241-346-0128 x250", "Fadel" },
                    { new Guid("a3ab7e5f-f674-0421-a391-227f54e619ee"), "Azerbaijan", new DateTime(1995, 11, 12, 3, 23, 7, 804, DateTimeKind.Utc).AddTicks(3577), 497.438089574644000m, "Juana.Kessler@yahoo.com", "Virgie", 700m, 959, "Nam voluptate.", "550.824.9616", "Prosacco" },
                    { new Guid("a3b6581c-1fca-ad37-6d81-af8e13d0a7c8"), "Lesotho", new DateTime(1945, 10, 17, 5, 58, 2, 690, DateTimeKind.Utc).AddTicks(163), 163.025773872058000m, "Caitlyn69@yahoo.com", "Carmen", 700m, 360, "Maxime ratione.", "939.744.2550 x0841", "Swift" },
                    { new Guid("a3c605d8-285a-2839-f5d6-8e8adc8403ac"), "Cape Verde", new DateTime(1930, 12, 11, 2, 9, 42, 230, DateTimeKind.Utc).AddTicks(5148), 948.573192734128000m, "Betsy_Wisozk@yahoo.com", "Barton", 900m, 985, "Pariatur aut.", "799.641.9323", "Morissette" },
                    { new Guid("a3c9cb02-52b7-9063-52c3-260bbaad557e"), "Syrian Arab Republic", new DateTime(1996, 2, 15, 13, 53, 40, 382, DateTimeKind.Utc).AddTicks(6278), 700.680453277442000m, "Ebony51@gmail.com", "Nichole", 600m, 372, "Ut aut.", "(221) 432-6780", "Dickens" },
                    { new Guid("a426ed49-95c3-f939-8a74-5ae69eb59c54"), "Bouvet Island (Bouvetoya)", new DateTime(2011, 8, 25, 4, 9, 33, 437, DateTimeKind.Utc).AddTicks(7627), 478.341852900566000m, "Juana.Mertz@gmail.com", "Maymie", 500m, 417, "Eaque accusamus.", "821.492.6344", "Grady" },
                    { new Guid("a51c6fe4-c0a4-14f9-a136-fee2f6ef3ca8"), "Mali", new DateTime(2004, 11, 30, 4, 42, 7, 575, DateTimeKind.Utc).AddTicks(3554), 461.509103858596000m, "Stewart_Rutherford98@gmail.com", "Herminia", 800m, 657, "Voluptatem qui.", "(758) 265-7679", "Toy" },
                    { new Guid("a5a925d4-011c-2793-0a32-d2c8e568af03"), "Oman", new DateTime(1928, 9, 9, 6, 53, 45, 956, DateTimeKind.Utc).AddTicks(2871), 562.648019589765000m, "Theresa84@hotmail.com", "Dino", 900m, 758, "Perspiciatis ullam.", "(769) 288-4550 x8256", "Hessel" },
                    { new Guid("a5b7aadf-6b08-00f7-4ed5-e736d4116c55"), "Luxembourg", new DateTime(2018, 10, 15, 10, 0, 4, 61, DateTimeKind.Utc).AddTicks(1242), 494.471376127305000m, "Ardella.Moen71@hotmail.com", "Watson", 700m, 514, "Quia nulla.", "739.558.2383", "Wuckert" },
                    { new Guid("a5bf6eae-7283-a2e7-cfef-41471f9d9721"), "Cambodia", new DateTime(2020, 10, 2, 17, 58, 48, 212, DateTimeKind.Utc).AddTicks(5133), 74.9536697098084000m, "Edythe58@hotmail.com", "Arlo", 500m, 642, "Quia quae.", "1-700-746-8576 x4523", "Braun" },
                    { new Guid("a5dfbedb-ebfc-806f-2756-1556fd3d8750"), "Brazil", new DateTime(1948, 5, 7, 3, 54, 27, 641, DateTimeKind.Utc).AddTicks(4929), 284.10318327653000m, "Issac45@yahoo.com", "Janice", 500m, 595, "Impedit nihil.", "1-351-252-0368 x9810", "Reinger" },
                    { new Guid("a5f3829a-3d87-e29f-0b80-027e64541803"), "Bolivia", new DateTime(1968, 7, 13, 1, 57, 40, 322, DateTimeKind.Utc).AddTicks(3859), 926.827401497067000m, "Lester_Mante@gmail.com", "Audie", 700m, 898, "Labore doloremque.", "1-238-326-4317", "Hermann" },
                    { new Guid("a619eec6-31be-d9d6-377c-c01b1a861467"), "Virgin Islands, U.S.", new DateTime(1943, 10, 29, 15, 47, 53, 773, DateTimeKind.Utc).AddTicks(1368), 495.599233757678000m, "Pearl.Kris@gmail.com", "Maddison", 800m, 535, "Perspiciatis natus.", "1-525-332-4863 x6121", "Wisozk" },
                    { new Guid("a62c64ca-5519-7364-192a-83994268840d"), "Iraq", new DateTime(2007, 12, 15, 15, 45, 40, 557, DateTimeKind.Utc).AddTicks(9812), 302.75148847712000m, "Dario_Brown@gmail.com", "Enoch", 1000m, 686, "Labore tenetur.", "520.708.3862 x6260", "Jast" },
                    { new Guid("a6ae9353-f7aa-823d-7fcd-b853f94d23bf"), "Kiribati", new DateTime(1964, 5, 18, 18, 46, 36, 884, DateTimeKind.Utc).AddTicks(2034), 692.85843257937000m, "Lavonne97@hotmail.com", "Casimir", 900m, 597, "Saepe qui.", "1-508-990-2631", "Watsica" },
                    { new Guid("a72c074d-b9d5-15fb-53a8-5fc3573cfc97"), "Namibia", new DateTime(2021, 2, 2, 14, 51, 17, 262, DateTimeKind.Utc).AddTicks(8055), 849.670528258858000m, "Adell_Cremin63@gmail.com", "Timothy", 900m, 466, "Nobis quidem.", "647.825.9388", "Gutkowski" },
                    { new Guid("a739e9b1-9a5b-a8a3-32ad-699038ff62b8"), "Germany", new DateTime(2011, 2, 27, 0, 10, 46, 583, DateTimeKind.Utc).AddTicks(4380), 380.355704741615000m, "Barton_DuBuque@gmail.com", "Emily", 800m, 269, "Beatae eius.", "555-699-8073 x57246", "O'Reilly" },
                    { new Guid("a75e50f6-5b55-c7f8-5f4a-6a5ad1b9c09b"), "Colombia", new DateTime(2017, 2, 11, 4, 23, 4, 625, DateTimeKind.Utc).AddTicks(1082), 162.49572148337000m, "Ahmed84@hotmail.com", "Golden", 900m, 382, "Nobis culpa.", "1-574-904-9207 x6683", "Koelpin" },
                    { new Guid("a7a684ac-f08b-1135-8060-1b2f7934ec95"), "Sierra Leone", new DateTime(1946, 2, 1, 2, 30, 8, 421, DateTimeKind.Utc).AddTicks(5606), 175.589557033832000m, "Charity.Runolfsson@yahoo.com", "Khalid", 500m, 680, "Dignissimos voluptate.", "1-866-258-7452 x1800", "Herzog" },
                    { new Guid("a7ae254b-75da-edd3-88df-6195e4acbcf9"), "Haiti", new DateTime(1961, 4, 4, 21, 31, 34, 646, DateTimeKind.Utc).AddTicks(4771), 719.154788392393000m, "Roslyn_Daniel@yahoo.com", "Nicolas", 600m, 809, "Sunt commodi.", "(504) 225-6955 x1299", "Graham" },
                    { new Guid("a7d78dc5-bb1c-1623-7b3f-0d7aff596253"), "Ecuador", new DateTime(1979, 7, 23, 15, 34, 11, 582, DateTimeKind.Utc).AddTicks(5830), 617.020366665243000m, "Aaron.Parker@yahoo.com", "Justus", 700m, 627, "Accusantium nulla.", "885.830.3902", "Muller" },
                    { new Guid("a8309fe0-6024-c4ce-776f-1f844570fb29"), "Nigeria", new DateTime(1986, 3, 21, 3, 48, 42, 131, DateTimeKind.Utc).AddTicks(8904), 72.4265379768578000m, "Wilfredo40@hotmail.com", "Carey", 900m, 771, "Possimus qui.", "955.326.6516 x10416", "Hackett" },
                    { new Guid("a8311f94-c620-1470-d8bd-4e1c4c050f1a"), "Mauritania", new DateTime(2006, 5, 6, 0, 37, 8, 888, DateTimeKind.Utc).AddTicks(4062), 43.2384524908744000m, "Valerie_Hahn1@hotmail.com", "Larry", 1000m, 607, "Et est.", "712.649.4446", "Volkman" },
                    { new Guid("a862cd30-f1d2-47de-3f81-cbc16d8e97fb"), "Chad", new DateTime(1963, 7, 7, 7, 36, 36, 199, DateTimeKind.Utc).AddTicks(2178), 285.144419734564000m, "Furman93@hotmail.com", "Wade", 500m, 646, "Sit odit.", "753.866.7525 x8329", "Abernathy" },
                    { new Guid("a8c28b09-7466-57a3-5ca4-c92ce99e08d5"), "Equatorial Guinea", new DateTime(1934, 4, 27, 19, 50, 28, 592, DateTimeKind.Utc).AddTicks(8479), 825.486533910658000m, "Dariana_OKeefe93@yahoo.com", "Enid", 1000m, 338, "Amet veritatis.", "575-609-5303", "Schimmel" },
                    { new Guid("a979582b-3c05-8177-644e-dcb28638f736"), "Bolivia", new DateTime(1986, 10, 4, 0, 55, 15, 259, DateTimeKind.Utc).AddTicks(6287), 883.605947656518000m, "Elena.Beier44@hotmail.com", "Magdalen", 700m, 440, "Enim sit.", "1-245-839-0714 x6193", "Walker" },
                    { new Guid("a9bbe6a8-a493-1b47-4767-c99085c4e1af"), "Liberia", new DateTime(1953, 8, 9, 21, 14, 37, 165, DateTimeKind.Utc).AddTicks(9233), 250.7078361108000m, "Keshaun_Parker43@hotmail.com", "Stella", 600m, 376, "Amet maiores.", "827.516.8949 x42037", "Conroy" },
                    { new Guid("a9ca86c7-5578-ee6b-9ad9-af685dbe0b02"), "Montserrat", new DateTime(1932, 10, 4, 23, 2, 4, 611, DateTimeKind.Utc).AddTicks(8324), 390.510905490882000m, "Hollie_Daugherty41@hotmail.com", "Bonita", 800m, 820, "Quo et.", "1-957-583-9250 x2145", "Borer" },
                    { new Guid("aacad52a-ddbe-9fd6-205f-3b05890ad968"), "Mongolia", new DateTime(1962, 7, 9, 5, 35, 57, 610, DateTimeKind.Utc).AddTicks(5157), 206.405143257593000m, "Dana76@hotmail.com", "Hal", 1000m, 714, "Nemo fugiat.", "222.950.8699 x921", "King" },
                    { new Guid("ab7ba48e-25a2-215e-3b50-89a292515c87"), "Iran", new DateTime(1932, 5, 19, 21, 46, 29, 535, DateTimeKind.Utc).AddTicks(2176), 628.901816182494000m, "Barry.Treutel@hotmail.com", "Sandra", 500m, 779, "Dolores sunt.", "840.709.8412", "Carter" },
                    { new Guid("abeef740-76fe-f0ed-1d45-050353f6a02d"), "China", new DateTime(2014, 5, 15, 13, 54, 7, 370, DateTimeKind.Utc).AddTicks(8325), 802.380479337747000m, "Ambrose_Heaney@hotmail.com", "Rusty", 1000m, 152, "Doloribus impedit.", "288-699-0302 x193", "Dibbert" },
                    { new Guid("abfc612a-9c5a-f6de-b5a1-5cab14b438eb"), "Tunisia", new DateTime(2001, 5, 12, 21, 26, 57, 253, DateTimeKind.Utc).AddTicks(9503), 385.573361832898000m, "Abby37@hotmail.com", "Tyrel", 600m, 169, "Non ut.", "1-541-520-9426", "Lubowitz" },
                    { new Guid("ac2de8b4-af40-89b7-426e-90473b859c09"), "Libyan Arab Jamahiriya", new DateTime(2017, 9, 11, 1, 24, 4, 472, DateTimeKind.Utc).AddTicks(849), 457.975243780838000m, "Abdul.Pouros@hotmail.com", "Juliana", 500m, 763, "Dolores excepturi.", "781.828.0694 x257", "Schneider" },
                    { new Guid("ac5b76ef-3c12-7163-3c93-a2787842e5a8"), "San Marino", new DateTime(2005, 8, 30, 15, 52, 3, 73, DateTimeKind.Utc).AddTicks(5761), 428.239708929455000m, "Elisa_Cummings71@yahoo.com", "Hayley", 900m, 233, "Voluptatem repellendus.", "(341) 434-7945", "Kohler" },
                    { new Guid("ac658946-ee43-88fc-0304-a7165512fe1f"), "Zambia", new DateTime(1928, 3, 29, 11, 31, 11, 298, DateTimeKind.Utc).AddTicks(8043), 814.912083097492000m, "Justus95@hotmail.com", "Elliot", 600m, 182, "Enim sint.", "1-929-534-0893 x7902", "Collins" },
                    { new Guid("ac8ae869-920a-079e-7e25-6baba6b51589"), "Equatorial Guinea", new DateTime(1948, 9, 29, 7, 43, 24, 456, DateTimeKind.Utc).AddTicks(4227), 913.699729721531000m, "Kathryne_Mante20@gmail.com", "Jazmin", 500m, 921, "Numquam ut.", "1-989-391-4804 x5739", "Hilpert" },
                    { new Guid("acec305e-686f-4f25-4b1b-9f5c4ea322a0"), "Mauritania", new DateTime(1937, 1, 7, 14, 11, 41, 636, DateTimeKind.Utc).AddTicks(7202), 175.501698796306000m, "Ambrose.Upton77@hotmail.com", "Juanita", 900m, 678, "Sit quo.", "1-784-610-9915", "Corwin" },
                    { new Guid("ad63b217-fea5-63dd-37e4-3f995f281798"), "Ecuador", new DateTime(1964, 7, 25, 2, 26, 53, 909, DateTimeKind.Utc).AddTicks(4704), 628.768141531025000m, "Rahul19@hotmail.com", "Kaden", 600m, 717, "Et aut.", "(514) 361-7793 x4447", "McDermott" },
                    { new Guid("ad7377e6-47c0-9973-7daa-f616aee797e2"), "Mayotte", new DateTime(1969, 9, 6, 18, 54, 17, 841, DateTimeKind.Utc).AddTicks(5785), 825.848939165317000m, "Berneice6@yahoo.com", "Clarabelle", 800m, 321, "Aperiam perferendis.", "552-634-3363", "Lockman" },
                    { new Guid("ade81c7c-c195-565d-2b2f-a4b368e712f0"), "Albania", new DateTime(1967, 8, 9, 23, 18, 17, 936, DateTimeKind.Utc).AddTicks(7780), 277.679624596427000m, "Magnus40@yahoo.com", "Annie", 600m, 484, "Pariatur rerum.", "(886) 612-3602", "Buckridge" },
                    { new Guid("adf36958-a481-a298-fcbc-c9f0cfc1e44d"), "Australia", new DateTime(1982, 6, 13, 5, 49, 42, 151, DateTimeKind.Utc).AddTicks(1749), 501.410482662939000m, "Philip_Yundt41@gmail.com", "Karolann", 500m, 848, "Est et.", "999-821-1441", "Deckow" },
                    { new Guid("ae2cf3c0-6fe3-d8a1-8fef-a9d1351e6e69"), "Kyrgyz Republic", new DateTime(2004, 11, 6, 22, 5, 57, 94, DateTimeKind.Utc).AddTicks(492), 740.024687537531000m, "Alfreda51@hotmail.com", "Lewis", 600m, 670, "Accusamus dignissimos.", "479.584.2426", "Hackett" },
                    { new Guid("ae98b165-0ccb-9c86-38a7-4628d60c54cd"), "Falkland Islands (Malvinas)", new DateTime(1950, 11, 23, 20, 10, 58, 331, DateTimeKind.Utc).AddTicks(9271), 271.204087354101000m, "Granville_Bayer@gmail.com", "Percy", 900m, 835, "Mollitia voluptatem.", "(355) 452-3842 x933", "Flatley" },
                    { new Guid("aeaa874a-9714-3318-3cf8-e7a34a0ae5a6"), "Argentina", new DateTime(1938, 7, 9, 18, 50, 13, 855, DateTimeKind.Utc).AddTicks(1826), 252.466954340202000m, "Wilford_Rodriguez47@hotmail.com", "Katlyn", 700m, 930, "Quam est.", "965.474.2565", "Dare" },
                    { new Guid("aeea8c89-6195-2144-6152-1f08f40b8b46"), "Saint Kitts and Nevis", new DateTime(1979, 4, 9, 13, 32, 18, 963, DateTimeKind.Utc).AddTicks(17), 713.967952370094000m, "Hollie.Adams31@hotmail.com", "Cierra", 1000m, 734, "Cumque harum.", "1-541-872-2293 x7481", "Dietrich" },
                    { new Guid("aef2e121-657f-e32a-281b-3cf3291f9f8b"), "Saint Helena", new DateTime(2015, 6, 8, 10, 6, 49, 384, DateTimeKind.Utc).AddTicks(1057), 676.316300761672000m, "Jessy_Cassin40@hotmail.com", "Jordan", 600m, 880, "Totam voluptatum.", "767.693.0111", "Glover" },
                    { new Guid("af339f89-5105-89af-1162-5798d3f76131"), "Burundi", new DateTime(2013, 4, 11, 21, 10, 38, 90, DateTimeKind.Utc).AddTicks(6724), 920.983306976342000m, "Carlos.Welch@hotmail.com", "Jerod", 700m, 498, "Deleniti ut.", "(574) 685-0499 x050", "Rippin" },
                    { new Guid("b009476b-2591-22bf-467d-09f3276d34cf"), "Turkmenistan", new DateTime(1949, 2, 19, 17, 24, 42, 247, DateTimeKind.Utc).AddTicks(9778), 515.345472997866000m, "Liliana_Wisoky79@yahoo.com", "Angelita", 800m, 953, "Earum natus.", "(251) 585-6358", "Stoltenberg" },
                    { new Guid("b03a546e-137b-be99-481f-dbcbcb44ebf6"), "Lesotho", new DateTime(1964, 6, 15, 0, 41, 11, 195, DateTimeKind.Utc).AddTicks(7498), 967.247037478777000m, "Katlyn71@yahoo.com", "Camden", 1000m, 3, "Illum fugiat.", "249.618.3955 x4145", "Hickle" },
                    { new Guid("b07028aa-a08b-0540-280f-b94172addd23"), "Moldova", new DateTime(1997, 11, 24, 16, 31, 10, 397, DateTimeKind.Utc).AddTicks(2041), 697.5589403015000m, "Ezra_Walker@hotmail.com", "Agustin", 500m, 301, "Ratione expedita.", "771.514.5577 x523", "Connelly" },
                    { new Guid("b0ba1630-7529-943a-4984-a9cd644567b3"), "Czech Republic", new DateTime(1930, 4, 14, 11, 41, 57, 854, DateTimeKind.Utc).AddTicks(1495), 712.343276929099000m, "Annabell_Pollich18@yahoo.com", "Linnea", 900m, 324, "Dolorem quibusdam.", "(476) 777-6991 x6701", "Kohler" },
                    { new Guid("b1344ea1-7bdb-1ef0-3a1a-e149e7374b55"), "Denmark", new DateTime(1960, 8, 2, 13, 9, 39, 854, DateTimeKind.Utc).AddTicks(491), 80.3216052400018000m, "Kira_Torp14@hotmail.com", "Tobin", 500m, 707, "Dolorem nam.", "708.612.4732 x169", "Hyatt" },
                    { new Guid("b151047b-b1e6-10a0-9ae1-f96a922f996c"), "Papua New Guinea", new DateTime(1942, 1, 7, 10, 29, 49, 118, DateTimeKind.Utc).AddTicks(3479), 140.743468300786000m, "Monique_Adams33@yahoo.com", "Unique", 800m, 529, "Laboriosam qui.", "648-468-6470", "Greenfelder" },
                    { new Guid("b19389e4-3c2c-e378-e6a9-6fcb9e84b601"), "Honduras", new DateTime(1964, 9, 28, 4, 27, 17, 374, DateTimeKind.Utc).AddTicks(6873), 618.545406270393000m, "Misty_Stanton11@hotmail.com", "Ruthe", 1000m, 950, "Asperiores natus.", "767-743-1147 x78175", "Douglas" },
                    { new Guid("b1aa2cb7-e3df-f76e-7018-9fcd68def546"), "Guam", new DateTime(1954, 6, 6, 20, 18, 55, 288, DateTimeKind.Utc).AddTicks(7526), 769.804277717516000m, "Edward88@gmail.com", "Rudy", 1000m, 156, "Quo distinctio.", "234.309.2632", "Wiza" },
                    { new Guid("b1d31a27-d040-28fd-a004-3ab8b822d3e0"), "Hong Kong", new DateTime(1960, 5, 29, 15, 46, 59, 858, DateTimeKind.Utc).AddTicks(4596), 918.324554217427000m, "Amiya_Bednar44@yahoo.com", "Beryl", 600m, 52, "Accusantium enim.", "1-335-723-3550 x777", "Krajcik" },
                    { new Guid("b27858d4-23e5-91eb-6a62-19da4682c420"), "Chile", new DateTime(1978, 6, 17, 12, 14, 31, 367, DateTimeKind.Utc).AddTicks(2325), 438.376810880147000m, "Palma.Runolfsson@gmail.com", "Michaela", 500m, 224, "Harum et.", "1-649-401-8770", "Bayer" },
                    { new Guid("b27bfe3f-5adc-ac21-65ab-a96cc99f07a8"), "Iceland", new DateTime(2010, 11, 23, 3, 22, 54, 322, DateTimeKind.Utc).AddTicks(4777), 400.514147354491000m, "Linda.Pfeffer79@hotmail.com", "Mike", 500m, 684, "Laudantium qui.", "960.702.6036 x5012", "Walker" },
                    { new Guid("b28f63a9-da82-8f10-c66b-a0d43bc17077"), "Cook Islands", new DateTime(2002, 5, 13, 23, 43, 23, 542, DateTimeKind.Utc).AddTicks(6672), 85.7949929496744000m, "Josianne51@yahoo.com", "Jammie", 900m, 834, "Optio sint.", "1-738-649-6327 x5993", "Kertzmann" },
                    { new Guid("b3f23e12-9cfc-8423-eb65-1e839d2b71b4"), "Nauru", new DateTime(2005, 1, 19, 5, 37, 56, 520, DateTimeKind.Utc).AddTicks(9181), 547.240253046326000m, "Modesta.Reynolds15@yahoo.com", "Deion", 600m, 823, "Commodi non.", "1-970-897-1686", "Champlin" },
                    { new Guid("b4377d80-22f8-621a-2c61-856c62c429c4"), "Norway", new DateTime(1938, 2, 20, 1, 4, 16, 189, DateTimeKind.Utc).AddTicks(9648), 869.969604813017000m, "Jayson.Ankunding76@gmail.com", "Kaylah", 700m, 552, "Odio dicta.", "(270) 352-9267 x289", "Mayert" },
                    { new Guid("b462b556-2fc9-bc12-883e-f5bce5f82e62"), "Norfolk Island", new DateTime(1929, 3, 4, 2, 57, 40, 379, DateTimeKind.Utc).AddTicks(8548), 622.595859876055000m, "Christine_Fritsch52@hotmail.com", "Annabell", 700m, 58, "Rerum et.", "(976) 769-9256", "Schmitt" },
                    { new Guid("b4ce13d9-9e1e-3321-05e2-228b191f43cf"), "Libyan Arab Jamahiriya", new DateTime(1942, 5, 15, 15, 36, 59, 804, DateTimeKind.Utc).AddTicks(6974), 918.970338663857000m, "Eleanore_Langworth@gmail.com", "Conner", 700m, 520, "Error enim.", "637.714.1102", "Zieme" },
                    { new Guid("b4db8d42-2358-2eb7-32c5-1a930ce7e070"), "Madagascar", new DateTime(1947, 12, 13, 20, 13, 1, 645, DateTimeKind.Utc).AddTicks(5270), 292.52616226313000m, "Susanna_Lakin47@yahoo.com", "Isaac", 500m, 778, "Odio non.", "593-203-2298 x366", "Willms" },
                    { new Guid("b4e08800-ab49-8f3a-bcb0-64f2eee934b9"), "Niger", new DateTime(1962, 3, 24, 19, 19, 20, 339, DateTimeKind.Utc).AddTicks(2371), 387.341718241152000m, "Issac_Kozey27@yahoo.com", "Laron", 600m, 380, "Ut culpa.", "480.361.3281", "Harris" },
                    { new Guid("b501d1a1-5b02-5a44-e1be-e17402258115"), "Trinidad and Tobago", new DateTime(2001, 8, 17, 9, 54, 51, 131, DateTimeKind.Utc).AddTicks(5453), 913.767068178291000m, "Maverick23@gmail.com", "Paolo", 700m, 621, "Officia quod.", "779.332.2393", "Mitchell" },
                    { new Guid("b504c0a2-a0fb-5d5d-e0e5-8683d9b6ed6e"), "Tonga", new DateTime(2001, 6, 30, 23, 34, 25, 309, DateTimeKind.Utc).AddTicks(9233), 972.534700310191000m, "Jesse6@yahoo.com", "Marquis", 700m, 982, "Voluptatem aut.", "552-618-9739 x91255", "Langosh" },
                    { new Guid("b534ad12-45a2-8276-079c-bef54d93c6e6"), "Slovenia", new DateTime(1943, 7, 9, 15, 30, 52, 54, DateTimeKind.Utc).AddTicks(4632), 958.351801217599000m, "Leo78@gmail.com", "Bernhard", 900m, 702, "Doloremque qui.", "1-295-576-9223", "Schulist" },
                    { new Guid("b5849829-e791-41f1-04a9-85dbfd79777c"), "Jordan", new DateTime(1964, 4, 4, 15, 56, 29, 189, DateTimeKind.Utc).AddTicks(106), 175.522003247237000m, "Cooper.Wilkinson19@yahoo.com", "Jerad", 700m, 619, "Consequatur ut.", "732-428-2788 x673", "Will" },
                    { new Guid("b5d0877a-d40a-86b3-f669-af3bc3dd290d"), "Papua New Guinea", new DateTime(2023, 5, 9, 7, 26, 18, 747, DateTimeKind.Utc).AddTicks(2120), 203.001927443037000m, "Lea26@gmail.com", "Abraham", 1000m, 76, "Cum impedit.", "937-347-9816", "Ziemann" },
                    { new Guid("b5ebe789-9e16-aabe-59fe-63346c7f7a76"), "Mali", new DateTime(1952, 12, 20, 4, 37, 39, 249, DateTimeKind.Utc).AddTicks(2340), 18.5648630998242000m, "Lila_Cummings@yahoo.com", "Irwin", 800m, 923, "Placeat molestiae.", "223.271.6903 x831", "Blick" },
                    { new Guid("b5fb7950-e2e3-df8b-4421-bfdce6f0a4d9"), "Christmas Island", new DateTime(1988, 11, 8, 11, 20, 6, 996, DateTimeKind.Utc).AddTicks(1313), 141.164030460705000m, "Andre_Tromp@hotmail.com", "Craig", 700m, 640, "Eos praesentium.", "914-533-4972", "Cassin" },
                    { new Guid("b601d6aa-8bc8-897a-9f9b-055d99d8f04e"), "Cape Verde", new DateTime(2007, 10, 28, 3, 59, 18, 874, DateTimeKind.Utc).AddTicks(3077), 763.459261541304000m, "Kamron.Welch@hotmail.com", "Hollis", 700m, 653, "Consequatur vitae.", "(501) 278-8618 x305", "Barrows" },
                    { new Guid("b60bc345-5908-1ffb-4dcd-84743e0dfbed"), "New Zealand", new DateTime(1954, 6, 5, 15, 26, 10, 246, DateTimeKind.Utc).AddTicks(9030), 348.152339954949000m, "Merl44@gmail.com", "Georgianna", 900m, 624, "Fuga eius.", "603.457.0522 x9638", "Cormier" },
                    { new Guid("b6a1a4f3-1c93-36a8-1d22-1d11afc29408"), "British Indian Ocean Territory (Chagos Archipelago)", new DateTime(2024, 2, 23, 6, 2, 23, 570, DateTimeKind.Utc).AddTicks(8378), 869.096251970274000m, "Wilhelmine.Jast33@yahoo.com", "Myrtle", 900m, 206, "Eligendi sapiente.", "490-776-5008", "McClure" },
                    { new Guid("b78b5a68-456f-ad26-c4a3-b18467188525"), "Cambodia", new DateTime(1979, 4, 5, 0, 27, 9, 720, DateTimeKind.Utc).AddTicks(2561), 382.940557542447000m, "Augustine_Ratke@gmail.com", "Anissa", 600m, 903, "Officiis ex.", "1-818-805-4488 x963", "Roberts" },
                    { new Guid("b7da6d10-a390-41f2-5f59-4b002c020060"), "Heard Island and McDonald Islands", new DateTime(1987, 5, 22, 23, 2, 30, 715, DateTimeKind.Utc).AddTicks(3631), 192.031894136911000m, "Brandon.Kreiger9@gmail.com", "Obie", 600m, 444, "Aspernatur porro.", "(783) 243-8036", "West" },
                    { new Guid("b7f1faa8-a1d5-b6ed-7fc1-f5de1db2fc17"), "Finland", new DateTime(1999, 10, 27, 18, 24, 49, 277, DateTimeKind.Utc).AddTicks(4454), 929.205241671527000m, "Jamaal_Zulauf26@gmail.com", "Cornell", 700m, 7, "Architecto occaecati.", "(814) 254-2846", "O'Keefe" },
                    { new Guid("b84f7da9-f70b-46e0-7a61-ece995bec5bb"), "Sudan", new DateTime(2006, 12, 18, 15, 27, 39, 43, DateTimeKind.Utc).AddTicks(8683), 256.892810917148000m, "Nickolas42@hotmail.com", "Juliana", 1000m, 558, "Doloribus autem.", "1-958-692-8082 x6963", "Shanahan" },
                    { new Guid("b8a6b5cb-97b6-5571-d6f3-f3f252be1513"), "Aruba", new DateTime(1962, 8, 26, 15, 0, 57, 703, DateTimeKind.Utc).AddTicks(4520), 809.515916978921000m, "Richmond.Kuphal23@yahoo.com", "Alia", 700m, 765, "Cumque velit.", "678.978.4389 x995", "Kerluke" },
                    { new Guid("b8ca8d97-e8c3-9828-536f-77ae488dd451"), "Christmas Island", new DateTime(2004, 10, 3, 8, 21, 10, 12, DateTimeKind.Utc).AddTicks(3637), 37.1275630934372000m, "Kyler_Schulist@yahoo.com", "Daisha", 500m, 362, "Quis occaecati.", "1-373-633-9470 x790", "Corkery" },
                    { new Guid("b90200dc-41b7-7c3d-c492-57bd0e1efefe"), "Norfolk Island", new DateTime(1971, 8, 4, 22, 11, 30, 248, DateTimeKind.Utc).AddTicks(6921), 859.257041130808000m, "Jasmin92@hotmail.com", "Lura", 900m, 746, "Velit qui.", "321.661.9342", "Ebert" },
                    { new Guid("b941913f-7fe1-f8a6-f31d-e7c065475ef8"), "Republic of Korea", new DateTime(1983, 12, 8, 21, 39, 15, 121, DateTimeKind.Utc).AddTicks(1928), 360.083837285683000m, "Jairo65@yahoo.com", "Kristina", 900m, 78, "Rem ipsam.", "1-934-592-3678", "Walter" },
                    { new Guid("b95cd647-d2b2-ad65-cf40-efc148e41269"), "Vietnam", new DateTime(1939, 3, 12, 18, 25, 15, 509, DateTimeKind.Utc).AddTicks(2111), 801.583493323898000m, "Peter_Dicki@hotmail.com", "Armand", 700m, 832, "Sed tempora.", "685-712-8400 x149", "Swift" },
                    { new Guid("b9cdbf1e-8ae6-3f7d-c7a8-d33521a13e4c"), "Portugal", new DateTime(2000, 10, 10, 12, 44, 41, 31, DateTimeKind.Utc).AddTicks(3731), 778.72994230095000m, "Maia_Abshire@gmail.com", "Hilda", 900m, 410, "Et magni.", "(474) 246-8026 x449", "McKenzie" },
                    { new Guid("ba0b1bd3-4efa-6017-0189-55d7e06b703e"), "Martinique", new DateTime(2024, 1, 3, 2, 30, 22, 141, DateTimeKind.Utc).AddTicks(2450), 810.880641500509000m, "Octavia_Braun@yahoo.com", "Francisco", 600m, 54, "Odio recusandae.", "(363) 637-8775", "Prohaska" },
                    { new Guid("ba236be1-e7d5-98b2-daaf-7d59552ca2e0"), "Papua New Guinea", new DateTime(1930, 3, 20, 21, 1, 4, 873, DateTimeKind.Utc).AddTicks(4169), 503.627964427229000m, "Pablo.Powlowski76@hotmail.com", "Brooklyn", 700m, 836, "Excepturi praesentium.", "691-341-9529 x933", "Schiller" },
                    { new Guid("ba2836a8-f414-313d-411f-3d12b5e58ee9"), "Israel", new DateTime(1952, 3, 1, 12, 6, 59, 68, DateTimeKind.Utc).AddTicks(3173), 876.537247767292000m, "Kade_Casper85@yahoo.com", "Kenneth", 900m, 505, "Consectetur eius.", "697-305-2643", "Ziemann" },
                    { new Guid("ba9eec63-23f3-7663-f9f9-12464cbf24a3"), "Vanuatu", new DateTime(2020, 3, 31, 22, 23, 46, 590, DateTimeKind.Utc).AddTicks(6508), 978.348860784543000m, "Cali50@yahoo.com", "Jeanne", 900m, 901, "Aut culpa.", "1-622-844-0318 x406", "Stiedemann" },
                    { new Guid("bac80c9b-4962-5554-966e-d3e9fc7a11e2"), "El Salvador", new DateTime(1949, 11, 28, 6, 14, 21, 313, DateTimeKind.Utc).AddTicks(2317), 279.902171121101000m, "Jeffrey_Hamill80@gmail.com", "Tito", 1000m, 249, "Ad beatae.", "737.212.9694 x030", "Ferry" },
                    { new Guid("bb66e27d-82cd-4837-d599-2b6939002d93"), "Svalbard & Jan Mayen Islands", new DateTime(1998, 5, 8, 20, 3, 18, 854, DateTimeKind.Utc).AddTicks(3592), 793.079129672168000m, "Presley_Nitzsche94@gmail.com", "Ambrose", 700m, 400, "Reprehenderit inventore.", "(266) 887-1500 x0299", "Gaylord" },
                    { new Guid("bc4e36dd-1163-3b11-4227-07669f802e5f"), "Brazil", new DateTime(1989, 8, 29, 11, 43, 49, 212, DateTimeKind.Utc).AddTicks(7020), 615.809779584061000m, "Ted.Jerde60@yahoo.com", "Randi", 800m, 488, "Ut dolores.", "403-682-2239 x096", "Adams" },
                    { new Guid("bcb2f805-12e8-320d-ca36-7a4122fbc15a"), "Holy See (Vatican City State)", new DateTime(1981, 2, 4, 4, 51, 56, 777, DateTimeKind.Utc).AddTicks(411), 928.674033633252000m, "Kathryne37@yahoo.com", "Rafael", 900m, 160, "Quae mollitia.", "496-878-6338 x16405", "Legros" },
                    { new Guid("bcd5fbd8-0cdd-2da3-8b67-ac8538004a4c"), "Cook Islands", new DateTime(1982, 7, 15, 2, 16, 29, 721, DateTimeKind.Utc).AddTicks(63), 699.403803801753000m, "Geoffrey_Flatley@hotmail.com", "Eusebio", 600m, 816, "Neque quisquam.", "212.697.2935", "Rolfson" },
                    { new Guid("bd0370a4-dcba-0778-1149-4cc340bb9758"), "Nepal", new DateTime(1975, 8, 30, 12, 46, 30, 638, DateTimeKind.Utc).AddTicks(406), 437.983034736148000m, "Jakayla89@gmail.com", "Kenneth", 700m, 114, "Nostrum delectus.", "344.311.4256", "Schiller" },
                    { new Guid("bd26bdb2-29ee-3a38-a510-16fbfebf5948"), "Oman", new DateTime(1995, 4, 18, 0, 0, 31, 439, DateTimeKind.Utc).AddTicks(746), 993.600844117756000m, "Josue_Prohaska@yahoo.com", "Floy", 600m, 883, "Voluptatem quidem.", "(697) 515-9608", "Robel" },
                    { new Guid("bd3e6c7b-6738-05c7-931a-e546aaf71f13"), "Albania", new DateTime(2005, 12, 27, 21, 16, 29, 448, DateTimeKind.Utc).AddTicks(5968), 712.783636106478000m, "Mathias_Gutmann@yahoo.com", "Addison", 600m, 722, "Aspernatur iste.", "1-796-704-4440 x9741", "McCullough" },
                    { new Guid("bdc1e6b3-7355-14b1-1976-5f4b2e765f8f"), "Tajikistan", new DateTime(1972, 9, 26, 8, 12, 23, 304, DateTimeKind.Utc).AddTicks(5454), 197.954518656779000m, "Edison71@gmail.com", "Arvid", 800m, 424, "Deserunt labore.", "(419) 513-7933", "Gerhold" },
                    { new Guid("bdcacb3a-04a2-4ae8-8f58-88fcd7fa4886"), "Mexico", new DateTime(2008, 9, 2, 13, 7, 33, 877, DateTimeKind.Utc).AddTicks(3851), 975.276923252712000m, "Jodie90@yahoo.com", "Celestine", 1000m, 689, "Laboriosam aspernatur.", "1-301-474-9481 x2399", "Steuber" },
                    { new Guid("bdd1af5b-fc3d-7a0d-de41-d69d9f5a2f0d"), "Martinique", new DateTime(1987, 2, 20, 11, 22, 52, 671, DateTimeKind.Utc).AddTicks(4277), 593.00311318511000m, "Dejuan_Collins72@gmail.com", "Yesenia", 800m, 891, "Fugit ut.", "1-505-830-8137", "Cassin" },
                    { new Guid("be2b765b-7301-0290-a2a2-f7e40fc7c0a9"), "Tokelau", new DateTime(2024, 10, 14, 0, 33, 29, 65, DateTimeKind.Utc).AddTicks(5376), 584.219077305135000m, "Lily.Howell@gmail.com", "Alva", 600m, 323, "Dolores adipisci.", "223.788.8771 x2135", "Windler" },
                    { new Guid("be74f5aa-fe8a-17f9-b347-d17a016723fb"), "Malta", new DateTime(1961, 2, 4, 4, 43, 43, 771, DateTimeKind.Utc).AddTicks(4290), 574.573291981109000m, "Concepcion_OKeefe@gmail.com", "Solon", 500m, 74, "Enim ea.", "572-563-5148 x208", "Flatley" },
                    { new Guid("be8c4c83-f350-7184-da88-782cbd83b5b7"), "Czech Republic", new DateTime(1927, 5, 22, 22, 30, 28, 830, DateTimeKind.Utc).AddTicks(4040), 79.3808849667758000m, "Pietro6@hotmail.com", "Elouise", 700m, 322, "Id amet.", "233.839.0888 x8545", "Haag" },
                    { new Guid("bed10572-0291-3d15-1504-623c9fed2d62"), "India", new DateTime(1929, 6, 7, 11, 2, 59, 638, DateTimeKind.Utc).AddTicks(3670), 462.281051909524000m, "Felicia35@hotmail.com", "Petra", 700m, 81, "Ipsum natus.", "576-893-5346", "Howell" },
                    { new Guid("bed35d93-495c-08a0-c401-64cb7b03a693"), "Nepal", new DateTime(1991, 8, 5, 0, 13, 9, 563, DateTimeKind.Utc).AddTicks(2027), 601.499693006821000m, "Maritza_Stokes@hotmail.com", "Grant", 700m, 808, "Voluptas itaque.", "(869) 715-1490", "Shields" },
                    { new Guid("bf056dad-0e49-fa1d-be2e-47c26caa0cd8"), "Jersey", new DateTime(1961, 2, 24, 20, 19, 7, 895, DateTimeKind.Utc).AddTicks(4321), 602.027862586436000m, "Cornell_Langosh@gmail.com", "Myron", 700m, 868, "Iusto aut.", "308-374-6478", "Ritchie" },
                    { new Guid("bf249b59-cdea-ac34-32ce-9ff01eba47ca"), "Solomon Islands", new DateTime(2007, 8, 25, 10, 25, 37, 725, DateTimeKind.Utc).AddTicks(2296), 794.995452984627000m, "Adriana28@yahoo.com", "Reba", 500m, 609, "Amet aut.", "1-557-237-3099 x6177", "Abshire" },
                    { new Guid("bf8b8cfc-a2e7-ff7e-97a5-972f7c250dc2"), "New Caledonia", new DateTime(1949, 4, 28, 0, 25, 56, 982, DateTimeKind.Utc).AddTicks(7883), 321.590356114201000m, "Whitney.Bernier@hotmail.com", "Carolyn", 800m, 288, "Eveniet aut.", "(601) 273-0811 x0217", "Nader" },
                    { new Guid("bfbe0b46-9f64-1e40-3e3c-1bf0c841f948"), "Latvia", new DateTime(2002, 4, 21, 3, 57, 16, 20, DateTimeKind.Utc).AddTicks(9081), 678.69947585845000m, "Joshua_Berge42@yahoo.com", "Keshaun", 700m, 94, "Occaecati accusamus.", "1-877-386-7840", "Roberts" },
                    { new Guid("bfd79268-f647-1387-6ca7-37c5c7fe28d2"), "Cape Verde", new DateTime(1977, 9, 2, 5, 35, 44, 393, DateTimeKind.Utc).AddTicks(6017), 561.702564306664000m, "Caleb_OConnell59@gmail.com", "Floy", 700m, 564, "Et laborum.", "(369) 351-6781", "Weber" },
                    { new Guid("bff2e876-a6c5-2354-1b2e-f4ec74105200"), "Kyrgyz Republic", new DateTime(1972, 4, 23, 0, 18, 45, 190, DateTimeKind.Utc).AddTicks(7303), 537.968295974622000m, "Triston47@hotmail.com", "Whitney", 900m, 576, "Itaque sapiente.", "873-471-2937", "Shanahan" },
                    { new Guid("c004b9d2-bce6-1b3c-b7de-1fbe20f98642"), "Guadeloupe", new DateTime(1948, 9, 25, 7, 27, 27, 636, DateTimeKind.Utc).AddTicks(6612), 899.94910636987000m, "Darrel15@yahoo.com", "Ernie", 1000m, 236, "Sit fuga.", "(959) 826-1757", "Walsh" },
                    { new Guid("c00d5dc6-8e9a-1f25-74d4-e090980fe7ec"), "Uruguay", new DateTime(2020, 1, 7, 11, 41, 26, 681, DateTimeKind.Utc).AddTicks(1771), 412.085284964329000m, "Jovanny0@gmail.com", "Alda", 500m, 685, "Ratione amet.", "959-510-5733", "Collins" },
                    { new Guid("c0641507-7edd-9eb6-90db-6b3dceb254d6"), "Madagascar", new DateTime(1988, 1, 20, 2, 2, 40, 5, DateTimeKind.Utc).AddTicks(5926), 467.885103149144000m, "Charity.Flatley94@hotmail.com", "Abner", 800m, 655, "Totam tempora.", "(785) 933-7070", "Goyette" },
                    { new Guid("c099f5a3-104c-c8fd-51da-1d2add17762d"), "Georgia", new DateTime(1976, 7, 17, 13, 54, 10, 769, DateTimeKind.Utc).AddTicks(9626), 227.647027175233000m, "Antonio89@yahoo.com", "Conner", 1000m, 455, "Alias qui.", "1-212-507-0975", "Fay" },
                    { new Guid("c0d4aff5-4641-e05f-5c8e-47dce0ae8eba"), "Saint Barthelemy", new DateTime(1955, 3, 23, 14, 20, 3, 439, DateTimeKind.Utc).AddTicks(62), 225.854763883736000m, "Emmet.Collier96@gmail.com", "Mathias", 700m, 122, "Sed cumque.", "(821) 223-0210", "Kessler" },
                    { new Guid("c0e4740c-f33e-061c-8fbf-fad5e20ce062"), "Guinea", new DateTime(1967, 9, 9, 18, 0, 20, 811, DateTimeKind.Utc).AddTicks(9212), 153.999251712256000m, "Viviane_Donnelly@yahoo.com", "Florida", 900m, 754, "Praesentium occaecati.", "978.556.4931 x410", "Dooley" },
                    { new Guid("c1c7182c-1ddc-e449-3e54-f01103742276"), "Costa Rica", new DateTime(1959, 6, 2, 2, 42, 13, 547, DateTimeKind.Utc).AddTicks(2228), 763.547266665243000m, "Paula_Ratke@yahoo.com", "Lindsey", 900m, 19, "Alias qui.", "1-253-306-4200 x1351", "Cronin" },
                    { new Guid("c2001e99-09b6-406f-a5a6-22b2dd3e4025"), "Bhutan", new DateTime(2020, 8, 22, 7, 54, 10, 271, DateTimeKind.Utc).AddTicks(7334), 918.841339607612000m, "Abigayle78@hotmail.com", "Laron", 500m, 874, "Fuga voluptas.", "(256) 592-4954 x199", "Volkman" },
                    { new Guid("c235bd6f-b60c-f7e4-5cd0-e0091f8c22b2"), "Turkmenistan", new DateTime(1972, 2, 1, 16, 47, 7, 934, DateTimeKind.Utc).AddTicks(4098), 441.702238640391000m, "Cordelia_Paucek93@gmail.com", "Felix", 600m, 326, "Et ducimus.", "205-864-5729", "Metz" },
                    { new Guid("c26237d5-3b92-d373-6129-07aafcc18c52"), "Cape Verde", new DateTime(1965, 1, 6, 4, 12, 19, 512, DateTimeKind.Utc).AddTicks(9426), 80.4145209392045000m, "Marquise46@gmail.com", "Ron", 900m, 354, "Ut quo.", "750.526.6868", "Cummerata" },
                    { new Guid("c265a267-a32b-f40b-825a-195451275bcd"), "Pakistan", new DateTime(1964, 12, 31, 6, 24, 0, 346, DateTimeKind.Utc).AddTicks(2451), 735.588348990124000m, "Robin5@yahoo.com", "Nicolette", 600m, 175, "Veritatis tempore.", "259.831.6293 x15752", "Ratke" },
                    { new Guid("c2bbdc15-0749-16d4-a6f4-f5128a28686d"), "Mali", new DateTime(1998, 7, 22, 13, 40, 4, 466, DateTimeKind.Utc).AddTicks(3928), 177.763966193585000m, "Wilber_Kerluke@yahoo.com", "Christop", 900m, 900, "Dolorem placeat.", "267.626.6071 x1365", "Ortiz" },
                    { new Guid("c2e0719f-3182-2118-1f51-4ade6462e182"), "Georgia", new DateTime(1984, 3, 22, 15, 52, 48, 437, DateTimeKind.Utc).AddTicks(9202), 599.413555189632000m, "Tracy_Stanton37@hotmail.com", "Joelle", 1000m, 426, "Sit ut.", "(971) 372-1154 x2114", "Kautzer" },
                    { new Guid("c3053d0d-cc46-3fee-87be-7e934f0fa5b7"), "Greenland", new DateTime(1945, 10, 30, 18, 29, 46, 632, DateTimeKind.Utc).AddTicks(9484), 69.2041460618823000m, "Audie_Stanton20@yahoo.com", "Carlotta", 800m, 32, "Dolore ut.", "(351) 522-6915", "Pollich" },
                    { new Guid("c305cbd0-b68c-eb7e-953a-9ab81e6485aa"), "Wallis and Futuna", new DateTime(1992, 5, 18, 7, 14, 48, 335, DateTimeKind.Utc).AddTicks(8619), 500.802609682446000m, "Garnet45@gmail.com", "Dereck", 500m, 26, "Dolorum ut.", "642.318.4103 x703", "Herman" },
                    { new Guid("c330e07e-72b2-ecc3-49c3-f6f90c5cb7bb"), "Kazakhstan", new DateTime(1944, 3, 28, 5, 3, 7, 258, DateTimeKind.Utc).AddTicks(5005), 785.051954616917000m, "Alyson_Hartmann34@gmail.com", "Delilah", 1000m, 786, "Temporibus facere.", "663-421-8589", "Hegmann" },
                    { new Guid("c38e1c3e-c8e6-4db3-760b-f5af0a209425"), "Paraguay", new DateTime(1974, 12, 15, 7, 53, 16, 55, DateTimeKind.Utc).AddTicks(5066), 947.02174053176000m, "Maye_Rolfson@hotmail.com", "Corine", 1000m, 150, "Inventore sunt.", "1-482-843-3315 x1220", "Rath" },
                    { new Guid("c3936005-1d50-644b-7989-acb459cfabb4"), "Turks and Caicos Islands", new DateTime(1948, 3, 20, 16, 2, 37, 411, DateTimeKind.Utc).AddTicks(5418), 988.932322746744000m, "Tamia.Graham@gmail.com", "Astrid", 700m, 795, "Accusamus ex.", "560.555.7628 x3761", "Pfannerstill" },
                    { new Guid("c3a3bfbb-2002-a374-729f-cf51791c1fd0"), "Angola", new DateTime(1949, 4, 30, 2, 5, 52, 235, DateTimeKind.Utc).AddTicks(7433), 40.8743605301124000m, "Eldridge35@yahoo.com", "Leanna", 800m, 589, "Earum odio.", "461.835.3315 x427", "Hermiston" },
                    { new Guid("c425715f-d7db-9b29-cd6a-4300464c6d6f"), "Cape Verde", new DateTime(1959, 8, 11, 22, 36, 58, 362, DateTimeKind.Utc).AddTicks(8413), 741.65021157535000m, "Mellie75@yahoo.com", "Theodora", 600m, 893, "Aut perspiciatis.", "455.797.4748 x48361", "Batz" },
                    { new Guid("c447a3f4-6290-dd41-1d44-ea6de4c8673c"), "Tajikistan", new DateTime(2003, 6, 21, 6, 54, 33, 340, DateTimeKind.Utc).AddTicks(4512), 541.217118648751000m, "Gudrun.Senger@yahoo.com", "Shayne", 1000m, 870, "Earum earum.", "386.260.7439 x7220", "Lesch" },
                    { new Guid("c471498c-bcb0-d3e8-4454-862cea6604ff"), "Yemen", new DateTime(2002, 9, 4, 2, 8, 32, 178, DateTimeKind.Utc).AddTicks(6042), 42.3123960103261000m, "Fermin_Thiel74@gmail.com", "Heidi", 600m, 298, "Et eaque.", "1-737-295-1669 x099", "Gerlach" },
                    { new Guid("c4d76343-92c8-f39e-aa4c-ef1c34a9b6a9"), "Mozambique", new DateTime(1992, 9, 25, 23, 19, 21, 762, DateTimeKind.Utc).AddTicks(2614), 170.390573664912000m, "Don30@hotmail.com", "Natalie", 700m, 841, "Et consequuntur.", "467-546-4730", "Rohan" },
                    { new Guid("c4ed17f6-275c-28f5-6fe5-5ed79bc9e7e9"), "Virgin Islands, U.S.", new DateTime(1988, 5, 4, 1, 51, 7, 111, DateTimeKind.Utc).AddTicks(790), 243.971885649657000m, "Stephany54@yahoo.com", "Imelda", 1000m, 889, "Cumque facere.", "1-717-473-7547", "Dach" },
                    { new Guid("c5912c59-9585-6b7b-14b0-073129205cb6"), "Yemen", new DateTime(1958, 1, 29, 21, 30, 58, 179, DateTimeKind.Utc).AddTicks(772), 102.651841696221000m, "Lura9@hotmail.com", "Lorenzo", 1000m, 237, "Facere velit.", "215.842.5596", "Bednar" },
                    { new Guid("c5d40d34-a31b-97ca-88ac-3baa5e194f58"), "Pakistan", new DateTime(1972, 11, 17, 8, 59, 48, 21, DateTimeKind.Utc).AddTicks(7053), 404.4635968262000m, "Landen.Reinger@hotmail.com", "Edward", 1000m, 913, "Ex veniam.", "651.727.1251 x977", "Medhurst" },
                    { new Guid("c5e134e7-1240-49da-4dcd-aadf1648d03d"), "Belgium", new DateTime(1931, 4, 30, 23, 25, 48, 204, DateTimeKind.Utc).AddTicks(1862), 967.648140727409000m, "Lou90@yahoo.com", "Maurine", 800m, 660, "Omnis voluptatum.", "(967) 809-9242 x7801", "Murazik" },
                    { new Guid("c618243d-a7b1-d27c-490e-ded21d97774e"), "Cameroon", new DateTime(2017, 6, 10, 11, 50, 41, 827, DateTimeKind.Utc).AddTicks(516), 130.234586261048000m, "Raheem65@gmail.com", "Raphael", 800m, 174, "Ullam rerum.", "287.969.3041 x283", "Romaguera" },
                    { new Guid("c6398cc9-66c2-6687-7cdc-e6f2158c0d2d"), "Netherlands", new DateTime(1934, 11, 14, 8, 54, 10, 364, DateTimeKind.Utc).AddTicks(2847), 315.510006036798000m, "Gus.Wiza@gmail.com", "River", 500m, 892, "Vel alias.", "(785) 358-1487 x308", "Balistreri" },
                    { new Guid("c6a302a4-f174-89d2-c915-7c6a61e6edc6"), "Turks and Caicos Islands", new DateTime(1933, 1, 23, 9, 10, 30, 464, DateTimeKind.Utc).AddTicks(8492), 864.54609703734000m, "Cleta53@gmail.com", "Queenie", 600m, 118, "Doloribus quasi.", "(512) 707-7211", "Schamberger" },
                    { new Guid("c6da7adc-1b40-f86c-03c2-74afa0d94d56"), "Niue", new DateTime(1990, 11, 3, 2, 1, 33, 100, DateTimeKind.Utc).AddTicks(1721), 836.44320998197000m, "Filiberto_Hills63@yahoo.com", "Raoul", 900m, 243, "Aut qui.", "434-702-3957", "Ward" },
                    { new Guid("c72b13b1-5b4c-1b1d-4a02-4c11cb47bb58"), "Cameroon", new DateTime(1954, 4, 28, 6, 16, 49, 226, DateTimeKind.Utc).AddTicks(39), 304.277817214358000m, "Esteban.Moore@hotmail.com", "Liana", 600m, 563, "Et rerum.", "1-314-344-6470 x4736", "Block" },
                    { new Guid("c851ac51-e143-8e71-9974-e2e8e3b0a4e1"), "Eritrea", new DateTime(1977, 3, 6, 14, 7, 11, 272, DateTimeKind.Utc).AddTicks(627), 356.312635722718000m, "Creola_Williamson@hotmail.com", "Lucio", 500m, 144, "Eius sed.", "901.568.1043 x916", "Rohan" },
                    { new Guid("c8674f48-40df-7a54-3666-24ff253b9348"), "French Guiana", new DateTime(1967, 3, 20, 13, 11, 1, 520, DateTimeKind.Utc).AddTicks(434), 381.364105287869000m, "Rosella.Medhurst87@hotmail.com", "Nicole", 700m, 939, "Aut officia.", "277-610-0663", "Johnson" },
                    { new Guid("c86f0c05-0a16-ad41-2391-c4c2842ef3f3"), "Portugal", new DateTime(1973, 12, 25, 9, 0, 4, 404, DateTimeKind.Utc).AddTicks(4274), 383.197814311863000m, "Onie_Witting63@yahoo.com", "Aniyah", 600m, 337, "Et voluptatum.", "585.613.9072", "Brekke" },
                    { new Guid("c8b3d192-adb5-8059-48da-e477b2f519c1"), "Turkmenistan", new DateTime(1935, 6, 3, 1, 22, 58, 488, DateTimeKind.Utc).AddTicks(7757), 993.181985805196000m, "Kailyn46@yahoo.com", "Jaunita", 1000m, 438, "Nobis laudantium.", "709-963-6604", "Stroman" },
                    { new Guid("c95d7f28-91d1-90b1-f157-e8f1aa772c15"), "Andorra", new DateTime(1927, 8, 3, 8, 25, 49, 178, DateTimeKind.Utc).AddTicks(1807), 11.422482735045000m, "Camryn_Labadie@gmail.com", "Justine", 900m, 886, "Quia non.", "1-622-780-4482", "Funk" },
                    { new Guid("c96ad0db-3b66-0bdf-4d02-e7a017784965"), "Lesotho", new DateTime(1951, 2, 20, 19, 32, 2, 206, DateTimeKind.Utc).AddTicks(1707), 940.530072673542000m, "Ben_Schmeler73@yahoo.com", "Shanny", 1000m, 617, "Architecto repellendus.", "463-599-7014", "Hickle" },
                    { new Guid("c978bb2c-a84d-3ad6-cf32-1596a58b6a58"), "Romania", new DateTime(1942, 4, 30, 0, 30, 26, 330, DateTimeKind.Utc).AddTicks(3516), 207.02402741542000m, "Cleora.Daugherty@hotmail.com", "Erna", 1000m, 215, "In harum.", "1-935-963-9649 x2189", "Walker" },
                    { new Guid("c9a3c2a4-e684-5289-8808-0da9b54f662c"), "Saint Kitts and Nevis", new DateTime(2007, 11, 16, 8, 52, 9, 842, DateTimeKind.Utc).AddTicks(7953), 936.720697688323000m, "Mathias.Steuber@yahoo.com", "Stuart", 600m, 21, "Rerum consectetur.", "229-967-4887 x41387", "Harris" },
                    { new Guid("c9bce1d7-7e0b-582f-251c-e522a45134ba"), "Saint Kitts and Nevis", new DateTime(1992, 6, 12, 8, 42, 22, 353, DateTimeKind.Utc).AddTicks(3894), 334.428268998104000m, "Vena_Oberbrunner@yahoo.com", "Wendell", 600m, 965, "Et fugit.", "(472) 531-7573 x2818", "Schaefer" },
                    { new Guid("c9e5966e-ca9a-8abc-055d-53b758bff69e"), "Netherlands", new DateTime(1956, 1, 16, 13, 20, 57, 799, DateTimeKind.Utc).AddTicks(5495), 69.7339495473869000m, "Frank.Lemke@hotmail.com", "Lenna", 700m, 566, "Sint quia.", "1-768-496-8749 x0648", "Fisher" },
                    { new Guid("ca315d75-4b8d-c26f-cc4e-ee0c10f0c582"), "Tonga", new DateTime(1952, 1, 18, 11, 21, 1, 864, DateTimeKind.Utc).AddTicks(1151), 181.759735562801000m, "Waldo.Tillman@hotmail.com", "Simeon", 1000m, 366, "Voluptas sequi.", "349-398-3474 x634", "Goyette" },
                    { new Guid("ca5a0868-a5ac-6a4d-70db-458d6ab57e29"), "Maldives", new DateTime(1991, 5, 6, 17, 49, 43, 442, DateTimeKind.Utc).AddTicks(5854), 452.072987061991000m, "Desmond93@yahoo.com", "Isac", 700m, 974, "Perspiciatis sint.", "951-886-1426 x72774", "Hickle" },
                    { new Guid("ca801a7c-6764-7179-68a4-495a083acbfd"), "Republic of Korea", new DateTime(1964, 10, 10, 21, 48, 14, 242, DateTimeKind.Utc).AddTicks(4072), 172.872482639838000m, "Max48@yahoo.com", "Jodie", 600m, 149, "Nihil eligendi.", "252.477.9847", "Monahan" },
                    { new Guid("cab21111-fae8-4e5a-46de-bb1ff7fa3de7"), "Czech Republic", new DateTime(1937, 11, 25, 10, 27, 40, 587, DateTimeKind.Utc).AddTicks(1897), 30.3275838709406000m, "Katherine.Beahan@hotmail.com", "Paige", 900m, 626, "Eius vel.", "723-400-2641 x69358", "Gerlach" },
                    { new Guid("cac23cda-aefc-0281-5645-ff0a0c179dfb"), "Nicaragua", new DateTime(1938, 8, 1, 21, 58, 4, 827, DateTimeKind.Utc).AddTicks(5133), 721.025591450454000m, "Cooper_Emmerich96@yahoo.com", "Desiree", 800m, 141, "Et consequatur.", "322-965-9292", "Greenfelder" },
                    { new Guid("cad1d3f8-5268-d10e-9124-59505c8e35e1"), "Austria", new DateTime(2000, 4, 10, 15, 9, 39, 311, DateTimeKind.Utc).AddTicks(609), 599.019709000463000m, "Carlo0@yahoo.com", "Dock", 600m, 606, "Et laboriosam.", "666.652.1571", "Greenfelder" },
                    { new Guid("cb17e2f1-46d6-093d-c750-247e79e840f2"), "Sao Tome and Principe", new DateTime(2019, 7, 28, 16, 13, 14, 840, DateTimeKind.Utc).AddTicks(8353), 281.579871871267000m, "Landen.Ernser@hotmail.com", "Vito", 600m, 592, "Et dicta.", "414-670-6540 x8878", "Shanahan" },
                    { new Guid("cb1f16a3-db3a-2cc3-9e82-72941d1f685c"), "Luxembourg", new DateTime(1985, 11, 17, 12, 46, 28, 635, DateTimeKind.Utc).AddTicks(1609), 368.922068909147000m, "Titus.Block56@hotmail.com", "Eulah", 800m, 108, "Rem temporibus.", "1-980-749-3710 x4612", "Pouros" },
                    { new Guid("cb507f40-0d30-5573-cadc-eba9923614aa"), "Qatar", new DateTime(2013, 12, 18, 19, 58, 30, 537, DateTimeKind.Utc).AddTicks(9572), 773.38904099335000m, "Daniela_Nicolas70@hotmail.com", "Ashly", 500m, 124, "Ducimus recusandae.", "1-406-394-3116 x979", "Vandervort" },
                    { new Guid("cb660c88-d30d-0628-eb25-6ac2e56cf30b"), "Kyrgyz Republic", new DateTime(2003, 1, 14, 0, 45, 43, 731, DateTimeKind.Utc).AddTicks(5049), 721.536286254606000m, "Sigrid.Muller@yahoo.com", "Daphne", 700m, 1000, "Fuga iste.", "877.594.9397", "Becker" },
                    { new Guid("cb9af17e-16a8-6d48-e687-3536405d63e7"), "Turkey", new DateTime(1956, 3, 24, 13, 45, 53, 202, DateTimeKind.Utc).AddTicks(3911), 63.2530402599994000m, "Evie.Upton95@hotmail.com", "Mabelle", 600m, 205, "Inventore perferendis.", "(781) 954-3295 x888", "Halvorson" },
                    { new Guid("cb9b7741-e4a1-1c8f-dcc1-b7e6ec99a6af"), "British Indian Ocean Territory (Chagos Archipelago)", new DateTime(2021, 9, 29, 10, 29, 26, 530, DateTimeKind.Utc).AddTicks(3093), 780.712164262625000m, "Enid.Lubowitz77@hotmail.com", "Haleigh", 800m, 101, "Dolores reiciendis.", "1-616-739-3465", "Beer" },
                    { new Guid("cbb0d5c6-5ea8-5599-8ff9-4afe2b04d276"), "Bhutan", new DateTime(1972, 7, 24, 9, 7, 7, 927, DateTimeKind.Utc).AddTicks(8653), 603.015141040617000m, "Nash.Turcotte42@yahoo.com", "Malika", 800m, 451, "Sit aut.", "371.569.6252", "Brakus" },
                    { new Guid("cbde7514-9017-bf0c-d778-9ca6af404f7d"), "El Salvador", new DateTime(1967, 11, 6, 23, 13, 5, 663, DateTimeKind.Utc).AddTicks(4888), 97.5625078961182000m, "Napoleon26@yahoo.com", "Elaina", 1000m, 706, "Quaerat velit.", "613.962.9018", "Abshire" },
                    { new Guid("cc2f5cd0-2755-4448-8738-2e901924772c"), "Taiwan", new DateTime(2005, 3, 20, 12, 46, 46, 680, DateTimeKind.Utc).AddTicks(5555), 735.286717372589000m, "Cydney_Kilback@yahoo.com", "Alexys", 800m, 528, "Laborum quas.", "686-820-0071 x1592", "Bartell" },
                    { new Guid("cc9805b9-0316-7cb7-aae7-b9cee0c3c94a"), "Tunisia", new DateTime(2024, 9, 29, 10, 49, 59, 798, DateTimeKind.Utc).AddTicks(297), 698.894447404864000m, "Cristopher_Weber95@yahoo.com", "Rickie", 900m, 639, "Dignissimos unde.", "1-579-349-8948", "Huel" },
                    { new Guid("cca61cc6-b110-ef10-bd12-610c34403818"), "Poland", new DateTime(1941, 10, 28, 21, 48, 55, 619, DateTimeKind.Utc).AddTicks(8467), 178.239870676712000m, "Baby_Emmerich24@gmail.com", "Era", 900m, 70, "Autem vitae.", "1-941-767-2973 x131", "Adams" },
                    { new Guid("cd057aa1-4bf9-1f58-4173-1471a57914d5"), "Cameroon", new DateTime(1949, 3, 31, 5, 5, 10, 231, DateTimeKind.Utc).AddTicks(7893), 235.630909221816000m, "Eloisa37@yahoo.com", "Jakob", 500m, 433, "Ullam eum.", "954.628.4056 x914", "Ankunding" },
                    { new Guid("cd36ab9c-0845-25c9-f335-2294e9d627c0"), "Venezuela", new DateTime(1999, 10, 27, 15, 39, 29, 292, DateTimeKind.Utc).AddTicks(979), 576.887145481786000m, "Ubaldo90@yahoo.com", "Christ", 500m, 180, "Et natus.", "983.809.8732 x05251", "Crooks" },
                    { new Guid("cd632fa2-1929-418a-162b-27957b68c65c"), "Equatorial Guinea", new DateTime(1932, 1, 7, 14, 31, 14, 811, DateTimeKind.Utc).AddTicks(8201), 530.045386879604000m, "Rolando_Stanton@hotmail.com", "Joey", 600m, 658, "Dolore voluptatem.", "1-421-924-6931 x7499", "Rippin" },
                    { new Guid("cd694a32-3182-44d5-a47b-9962afd2cc0f"), "Sudan", new DateTime(1981, 8, 15, 22, 16, 1, 601, DateTimeKind.Utc).AddTicks(1806), 306.742887631717000m, "Buck_Shanahan97@hotmail.com", "Kaya", 500m, 119, "Dolorum sint.", "957.942.7396", "Simonis" },
                    { new Guid("cde26bd1-d0b8-a32c-9118-c0af3f430c19"), "Australia", new DateTime(1950, 9, 23, 18, 34, 45, 65, DateTimeKind.Utc).AddTicks(4807), 933.041867424376000m, "Esther55@yahoo.com", "Sylvester", 600m, 554, "Magni dolores.", "775-920-5620", "O'Keefe" },
                    { new Guid("ce238385-ad03-c04c-669b-74839be5ad73"), "Dominican Republic", new DateTime(1984, 12, 25, 23, 31, 13, 434, DateTimeKind.Utc).AddTicks(2582), 160.374718315133000m, "Estella.Maggio76@yahoo.com", "Aliya", 700m, 825, "Culpa aut.", "287.798.9098 x203", "Monahan" },
                    { new Guid("ce2a3a4f-493b-f4e6-1bc8-53d54d304104"), "Turks and Caicos Islands", new DateTime(1980, 12, 1, 18, 50, 48, 133, DateTimeKind.Utc).AddTicks(11), 324.435432007632000m, "Marilie_Orn81@hotmail.com", "Louie", 600m, 252, "Hic natus.", "696-806-4605 x399", "Runolfsdottir" },
                    { new Guid("ce305890-e143-474c-9b29-feb99fd4620c"), "Gibraltar", new DateTime(1942, 1, 22, 14, 16, 21, 433, DateTimeKind.Utc).AddTicks(5678), 256.658711251431000m, "Veronica11@yahoo.com", "Meghan", 500m, 392, "Voluptatibus numquam.", "257-763-2285", "Krajcik" },
                    { new Guid("cede73a7-7f9a-611a-b60e-5715bc8f4c5f"), "Cuba", new DateTime(1934, 12, 18, 17, 0, 25, 417, DateTimeKind.Utc).AddTicks(4851), 697.701538534862000m, "Malachi.Erdman@gmail.com", "Paxton", 1000m, 331, "Ab hic.", "917.793.0969 x80376", "Stamm" },
                    { new Guid("cef339bf-ccfd-edef-bfee-ab170117eca2"), "Puerto Rico", new DateTime(1949, 5, 16, 15, 45, 23, 850, DateTimeKind.Utc).AddTicks(7097), 328.809531938814000m, "Cedrick.Zieme@yahoo.com", "Chauncey", 500m, 363, "Veritatis exercitationem.", "1-351-485-3688 x6664", "Heidenreich" },
                    { new Guid("cf213fc0-3ebc-d704-1754-35484a7079ab"), "Serbia", new DateTime(1954, 9, 8, 16, 21, 36, 156, DateTimeKind.Utc).AddTicks(6834), 237.64113706717000m, "Maudie.Nicolas@gmail.com", "Shania", 500m, 522, "Aut inventore.", "340-791-6381 x964", "Block" },
                    { new Guid("cf6cffad-3604-070a-df3f-32a9de001a9b"), "British Indian Ocean Territory (Chagos Archipelago)", new DateTime(1986, 5, 29, 20, 55, 22, 815, DateTimeKind.Utc).AddTicks(5182), 256.960173149732000m, "Alaina_Parker30@yahoo.com", "Hortense", 600m, 645, "Nihil cupiditate.", "380.334.2654 x62747", "Crona" },
                    { new Guid("cfefed0a-d235-5d53-1e3c-404d403e54d6"), "Russian Federation", new DateTime(1969, 9, 10, 6, 39, 59, 780, DateTimeKind.Utc).AddTicks(4431), 631.049906635239000m, "Eliza_Feest31@gmail.com", "Amanda", 1000m, 788, "Minima saepe.", "1-734-200-8968 x1364", "Koss" },
                    { new Guid("d06ad412-eea8-bd03-d880-247b1308a01c"), "Fiji", new DateTime(2006, 5, 17, 19, 39, 52, 489, DateTimeKind.Utc).AddTicks(6110), 214.676084188561000m, "Genesis96@gmail.com", "Edna", 600m, 667, "Et eos.", "1-909-747-5325", "Gaylord" },
                    { new Guid("d0dee0d3-8dc7-ec9b-442e-486ca49b9557"), "Falkland Islands (Malvinas)", new DateTime(1983, 4, 5, 4, 6, 48, 563, DateTimeKind.Utc).AddTicks(8596), 212.508616683173000m, "Jena59@gmail.com", "Lavonne", 900m, 45, "Itaque repellendus.", "551.675.0632", "Crooks" },
                    { new Guid("d16d3e0c-ac97-5b11-4b2f-12cc5414b8d4"), "Niger", new DateTime(1943, 9, 22, 9, 24, 48, 596, DateTimeKind.Utc).AddTicks(9322), 857.009336514331000m, "Xzavier_Gaylord@gmail.com", "General", 900m, 560, "Itaque amet.", "(367) 261-0095 x5094", "Fisher" },
                    { new Guid("d18b69a9-8477-4f97-7360-1ce21022e4e9"), "Togo", new DateTime(1976, 2, 29, 20, 47, 38, 976, DateTimeKind.Utc).AddTicks(6965), 761.58664524043000m, "Maureen_Feeney81@gmail.com", "Lora", 500m, 932, "Et libero.", "1-895-295-1220 x583", "Sporer" },
                    { new Guid("d1c60a42-511d-083d-a3dc-3c27018ae98a"), "Qatar", new DateTime(1994, 4, 20, 9, 6, 42, 623, DateTimeKind.Utc).AddTicks(1980), 283.903048901112000m, "Halie.Swaniawski@yahoo.com", "Sonia", 600m, 296, "Voluptatum omnis.", "806-417-5625", "Welch" },
                    { new Guid("d1e73f81-5136-213d-f67e-b7e1960b9dcf"), "Nauru", new DateTime(1928, 5, 22, 5, 22, 58, 999, DateTimeKind.Utc).AddTicks(1062), 36.1463377562912000m, "Halie.Lowe52@hotmail.com", "Jarrett", 1000m, 221, "Ea ab.", "(271) 808-0820 x0471", "Glover" },
                    { new Guid("d1fc4ea6-4bec-034c-8b18-9ae1226115de"), "Congo", new DateTime(1992, 11, 21, 5, 43, 41, 79, DateTimeKind.Utc).AddTicks(1934), 73.3259616790874000m, "Ellsworth54@yahoo.com", "Kamren", 1000m, 688, "Sint cumque.", "649-589-0346 x1139", "Hyatt" },
                    { new Guid("d207b8d0-2297-b501-b7eb-c93e143d1c3c"), "Iraq", new DateTime(1981, 4, 6, 23, 42, 47, 505, DateTimeKind.Utc).AddTicks(5200), 406.44798406922000m, "Herbert_Tillman21@hotmail.com", "Mylene", 600m, 567, "Molestias quia.", "(580) 550-0915", "Stoltenberg" },
                    { new Guid("d2153473-238f-b8f1-554e-9623307ee4df"), "Venezuela", new DateTime(1992, 8, 11, 4, 0, 17, 921, DateTimeKind.Utc).AddTicks(571), 436.02854523262000m, "Helga_Muller98@yahoo.com", "Carmella", 900m, 674, "Consequatur esse.", "1-495-930-7742", "Fritsch" },
                    { new Guid("d23a7c48-16d9-c1a6-3954-93ed5e18fbcf"), "Wallis and Futuna", new DateTime(1985, 7, 25, 17, 47, 2, 558, DateTimeKind.Utc).AddTicks(7847), 473.46022113008000m, "Trent_McCullough21@yahoo.com", "Arnold", 700m, 948, "Eveniet est.", "638.961.3454", "Streich" },
                    { new Guid("d242c73a-de1e-226a-9872-c3ae087b1327"), "Qatar", new DateTime(1943, 4, 22, 8, 53, 26, 52, DateTimeKind.Utc).AddTicks(2400), 74.5731876748678000m, "Harley61@hotmail.com", "Sebastian", 500m, 449, "Laboriosam cumque.", "525.624.2754 x67403", "Paucek" },
                    { new Guid("d263959d-61f4-ebfb-73d5-1a65e78e6e93"), "Lesotho", new DateTime(1964, 4, 30, 6, 59, 35, 837, DateTimeKind.Utc).AddTicks(7737), 280.97885218615000m, "Dolly96@gmail.com", "Dameon", 800m, 952, "Impedit dolor.", "(870) 710-5248", "Nolan" },
                    { new Guid("d2d80b5a-7989-0fc7-a442-4533a45cdbc1"), "Falkland Islands (Malvinas)", new DateTime(1928, 7, 2, 19, 7, 32, 731, DateTimeKind.Utc).AddTicks(600), 692.603145825641000m, "Bridget.Wiegand@hotmail.com", "Hank", 600m, 656, "Eos fuga.", "341-792-1396 x412", "Effertz" },
                    { new Guid("d2da744b-b266-24a4-913f-ed047640031a"), "Austria", new DateTime(2013, 3, 31, 14, 20, 1, 20, DateTimeKind.Utc).AddTicks(1413), 912.079921773335000m, "Monserrat.Nienow@hotmail.com", "Oran", 900m, 142, "Aut qui.", "(984) 764-5667 x4705", "Lebsack" },
                    { new Guid("d2fe2fa1-666b-fc61-8772-d005438377d8"), "Botswana", new DateTime(1943, 3, 14, 5, 27, 19, 330, DateTimeKind.Utc).AddTicks(8480), 753.144009614741000m, "Jorge16@gmail.com", "Jermain", 800m, 130, "Aut impedit.", "1-839-320-1211 x879", "Reilly" },
                    { new Guid("d30e6da5-5972-c677-3c26-905ae7157d96"), "Indonesia", new DateTime(2023, 1, 3, 13, 55, 22, 79, DateTimeKind.Utc).AddTicks(4648), 455.205912901005000m, "Paxton.Heaney42@gmail.com", "Andy", 900m, 246, "Qui quos.", "528-268-1937", "Watsica" },
                    { new Guid("d322f008-3ff8-5b65-76c2-3f81fe5476d1"), "Tonga", new DateTime(1936, 4, 20, 16, 27, 12, 59, DateTimeKind.Utc).AddTicks(6805), 518.581806994152000m, "Jerod_Abshire@gmail.com", "Lacy", 900m, 445, "Voluptatibus cumque.", "660-482-2658 x981", "Gaylord" },
                    { new Guid("d345d640-c29c-8dd3-8f11-9df515e08827"), "Sri Lanka", new DateTime(1983, 1, 17, 23, 6, 41, 377, DateTimeKind.Utc).AddTicks(2521), 402.412797148443000m, "Frank86@yahoo.com", "Ryan", 700m, 100, "Neque soluta.", "1-607-530-5926 x0738", "Kling" },
                    { new Guid("d354832e-5fbd-7947-e303-6a1f2a4980b9"), "Sierra Leone", new DateTime(1926, 5, 9, 21, 29, 0, 455, DateTimeKind.Utc).AddTicks(1868), 952.018472452617000m, "Kian.Glover@gmail.com", "Germaine", 1000m, 110, "Officia aut.", "(908) 934-8624", "Feeney" },
                    { new Guid("d3cfb233-47e3-1188-0071-3be17029370c"), "Bhutan", new DateTime(1978, 1, 31, 1, 23, 59, 895, DateTimeKind.Utc).AddTicks(180), 535.682978931777000m, "Mohammed.Sporer19@gmail.com", "Noemy", 700m, 145, "Perspiciatis dolor.", "1-850-214-0047", "Bernier" },
                    { new Guid("d43cd1bb-fcbd-0e68-db55-4c84937063ed"), "Honduras", new DateTime(2000, 10, 14, 0, 35, 44, 43, DateTimeKind.Utc).AddTicks(2586), 900.502564426721000m, "Oswald_Rice@yahoo.com", "Cristobal", 700m, 860, "Inventore laborum.", "1-914-418-3158 x1933", "Mann" },
                    { new Guid("d46e432c-5602-e0c8-4dff-1fdbd9091bd2"), "Fiji", new DateTime(2006, 3, 22, 9, 11, 57, 273, DateTimeKind.Utc).AddTicks(8067), 754.955587450689000m, "Lia.Pouros@yahoo.com", "Clotilde", 500m, 107, "Sunt est.", "(753) 762-1366 x5991", "Greenholt" },
                    { new Guid("d492dc80-adb1-5227-0196-93306c9f5baf"), "Vanuatu", new DateTime(1981, 2, 24, 10, 36, 24, 873, DateTimeKind.Utc).AddTicks(3531), 926.709696444067000m, "General_Kohler@yahoo.com", "Hudson", 700m, 711, "Voluptates unde.", "1-927-697-9888 x405", "Lemke" },
                    { new Guid("d51622d9-712e-4f70-aff7-5a3ece1d9ff8"), "Ukraine", new DateTime(1997, 5, 18, 6, 40, 3, 372, DateTimeKind.Utc).AddTicks(5640), 599.934719278609000m, "Alexandra83@hotmail.com", "Sheridan", 1000m, 185, "Rerum accusamus.", "(309) 840-8442", "Spencer" },
                    { new Guid("d59fe568-c590-175a-d732-12a50b343b85"), "Hungary", new DateTime(1965, 3, 5, 9, 22, 11, 991, DateTimeKind.Utc).AddTicks(775), 114.176624635993000m, "Molly73@yahoo.com", "Anderson", 800m, 134, "Eum aut.", "798.558.7297 x38595", "Kirlin" },
                    { new Guid("d5a6bbb0-b5a6-883d-51d6-e72936199698"), "Morocco", new DateTime(1997, 9, 3, 2, 2, 18, 775, DateTimeKind.Utc).AddTicks(2089), 832.630256711812000m, "Napoleon.Beatty@gmail.com", "Torey", 800m, 358, "Et qui.", "722-755-5324 x8140", "Hodkiewicz" },
                    { new Guid("d6d3a348-5d9e-78c9-49b5-a27ec993cda9"), "San Marino", new DateTime(1933, 11, 12, 2, 40, 3, 788, DateTimeKind.Utc).AddTicks(8250), 592.29791609463000m, "Dagmar.Bahringer@hotmail.com", "Casper", 500m, 453, "Et et.", "460.435.8077 x0023", "Nicolas" },
                    { new Guid("d79e8c8c-3c26-9f97-78e6-33a1846bd0b3"), "Botswana", new DateTime(1993, 2, 25, 14, 14, 19, 908, DateTimeKind.Utc).AddTicks(329), 877.167867922786000m, "Joe.Buckridge40@hotmail.com", "Ralph", 800m, 268, "Facere aut.", "765-900-1147", "Yost" },
                    { new Guid("d7ff157b-5ceb-a344-4817-3f86452dc95d"), "Finland", new DateTime(1930, 1, 28, 15, 57, 32, 652, DateTimeKind.Utc).AddTicks(7587), 16.4134551288275000m, "Eden61@gmail.com", "Erica", 600m, 501, "Recusandae magni.", "(470) 238-9038 x3633", "Schneider" },
                    { new Guid("d8749f70-8b7a-4a77-31f1-254976341551"), "Barbados", new DateTime(1960, 12, 27, 16, 37, 25, 201, DateTimeKind.Utc).AddTicks(1272), 217.00377085945000m, "Mabel_Steuber71@hotmail.com", "Dedric", 700m, 300, "Voluptatem illum.", "(406) 687-3875 x1711", "Russel" },
                    { new Guid("d8850e4d-d0da-e540-6123-8dd0e9d5f798"), "Chad", new DateTime(1987, 9, 14, 3, 56, 35, 215, DateTimeKind.Utc).AddTicks(5957), 966.340960787263000m, "Eda_Lind21@hotmail.com", "Genesis", 700m, 699, "Aut rerum.", "(493) 918-6288", "Douglas" },
                    { new Guid("d88adca0-4380-545a-742d-8c4edaacf6e9"), "Monaco", new DateTime(1978, 10, 3, 9, 20, 44, 937, DateTimeKind.Utc).AddTicks(8449), 474.970053193322000m, "Amos.Sanford22@yahoo.com", "Bridgette", 1000m, 922, "Facilis quo.", "(273) 203-3604", "Rau" },
                    { new Guid("d9720dbc-8f98-a299-26e8-1dd0a19de3ee"), "Ethiopia", new DateTime(1944, 5, 2, 13, 51, 14, 492, DateTimeKind.Utc).AddTicks(5758), 760.478550533531000m, "Jolie.Heathcote57@gmail.com", "Ryan", 900m, 212, "Velit rerum.", "458-799-8674 x281", "Kovacek" },
                    { new Guid("da19196a-a8ed-e6fe-962a-da26286497d8"), "Kazakhstan", new DateTime(1980, 4, 24, 18, 57, 54, 738, DateTimeKind.Utc).AddTicks(8607), 204.499977434862000m, "Ruby60@hotmail.com", "Heather", 900m, 164, "Delectus atque.", "(519) 481-5008", "Welch" },
                    { new Guid("da41930a-c6fa-cd86-1de1-0f6da1c5ad2a"), "Namibia", new DateTime(1934, 8, 12, 5, 47, 44, 911, DateTimeKind.Utc).AddTicks(7488), 994.333417899776000m, "Blair_Deckow@gmail.com", "Pasquale", 900m, 794, "Qui fugit.", "(802) 278-2372 x334", "Treutel" },
                    { new Guid("da4bb2f8-665d-81b9-e992-8c4eaab43853"), "American Samoa", new DateTime(2024, 9, 30, 18, 39, 56, 742, DateTimeKind.Utc).AddTicks(2393), 189.161152597768000m, "Marcelo_Cummerata@yahoo.com", "Bertram", 900m, 399, "Mollitia cumque.", "1-207-934-3379 x458", "Schulist" },
                    { new Guid("dac050af-8d7a-aac5-481d-6fda1c7b95d5"), "Jordan", new DateTime(2012, 9, 29, 0, 4, 42, 601, DateTimeKind.Utc).AddTicks(5262), 60.5638832972085000m, "Jerrell91@yahoo.com", "Tavares", 900m, 774, "Facere et.", "(873) 890-9060 x4574", "Feeney" },
                    { new Guid("db0c9da8-826a-e234-b776-e792eafbe38f"), "Saint Lucia", new DateTime(2008, 5, 26, 3, 22, 25, 24, DateTimeKind.Utc).AddTicks(76), 154.371985273865000m, "Thaddeus_Bergstrom23@gmail.com", "Lizzie", 900m, 339, "Iure est.", "(681) 461-1102 x506", "Nolan" },
                    { new Guid("db0f4930-43e3-3f7f-8ba2-28c7bc6fa3ae"), "Venezuela", new DateTime(1936, 8, 11, 5, 53, 13, 647, DateTimeKind.Utc).AddTicks(9104), 936.064057471923000m, "Nikita_Hayes@gmail.com", "Victoria", 900m, 179, "Porro distinctio.", "(778) 277-4176 x088", "McCullough" },
                    { new Guid("db18189b-6120-36c1-97f4-3e92990d7bfb"), "Togo", new DateTime(1928, 9, 1, 13, 34, 33, 499, DateTimeKind.Utc).AddTicks(6235), 853.628606173563000m, "Abbey19@hotmail.com", "Lina", 500m, 284, "Ex officia.", "(469) 616-2128 x1350", "Rodriguez" },
                    { new Guid("db1e4c35-1666-2be8-f98f-4e13cbcbbb78"), "Netherlands Antilles", new DateTime(1936, 5, 1, 17, 33, 17, 770, DateTimeKind.Utc).AddTicks(5764), 876.102858482478000m, "Noemi_Crooks97@hotmail.com", "Ara", 500m, 622, "Iste minima.", "1-599-245-3338", "Schaefer" },
                    { new Guid("db3778ef-f152-b04d-d531-0df0d9842249"), "Republic of Korea", new DateTime(1942, 4, 22, 12, 40, 0, 901, DateTimeKind.Utc).AddTicks(967), 428.5166926027000m, "Rogelio_Blanda46@hotmail.com", "Shany", 1000m, 97, "Tempora sapiente.", "502-645-7039 x543", "Gerhold" },
                    { new Guid("dbe58f2e-2d58-ee20-6743-8360bd4350be"), "Cuba", new DateTime(1971, 7, 28, 17, 53, 28, 907, DateTimeKind.Utc).AddTicks(3373), 48.2757856248324000m, "Delbert65@yahoo.com", "Grant", 500m, 718, "Incidunt fugiat.", "898-280-7592 x0649", "Bashirian" },
                    { new Guid("dc068319-a0a3-7e5d-fba6-aa239b4d3e01"), "Moldova", new DateTime(1992, 3, 20, 10, 17, 55, 11, DateTimeKind.Utc).AddTicks(6369), 413.067188395135000m, "Emily12@gmail.com", "Davonte", 600m, 25, "Vitae qui.", "(471) 464-6231 x802", "MacGyver" },
                    { new Guid("dc30baed-bec1-02d3-db5c-7e02228e40af"), "Afghanistan", new DateTime(1961, 2, 20, 22, 24, 47, 6, DateTimeKind.Utc).AddTicks(9327), 842.183860492424000m, "Winona.Spinka@gmail.com", "Evie", 700m, 957, "Aspernatur nihil.", "(569) 296-0000", "Toy" },
                    { new Guid("dc3cd85a-3366-1809-2184-bb33bd529bed"), "Hong Kong", new DateTime(1940, 11, 8, 11, 8, 10, 193, DateTimeKind.Utc).AddTicks(6494), 202.020442086833000m, "Shanelle.Daugherty@gmail.com", "Grayce", 1000m, 799, "Ipsam exercitationem.", "(278) 338-2279", "Vandervort" },
                    { new Guid("dc4d700f-bb75-bdfb-dfca-882440d30039"), "Bouvet Island (Bouvetoya)", new DateTime(1941, 2, 2, 17, 20, 43, 700, DateTimeKind.Utc).AddTicks(1600), 814.13342305209000m, "Luisa.Krajcik@yahoo.com", "Vince", 900m, 581, "Atque modi.", "1-233-291-7058 x8639", "Effertz" },
                    { new Guid("dcb7dd91-7d90-d63c-ddac-909bef5896cc"), "Sri Lanka", new DateTime(1933, 1, 1, 10, 54, 46, 392, DateTimeKind.Utc).AddTicks(4502), 334.568501190053000m, "Cicero16@hotmail.com", "Josie", 700m, 807, "Sequi molestiae.", "1-530-480-9670", "Koepp" },
                    { new Guid("dcc25a05-2c09-6f03-740b-1f61c2c435ef"), "Macao", new DateTime(1932, 3, 20, 3, 55, 42, 249, DateTimeKind.Utc).AddTicks(3277), 878.45016012045000m, "Wilson23@yahoo.com", "Ronaldo", 1000m, 983, "Voluptatem iste.", "1-293-699-4616", "Lynch" },
                    { new Guid("dd50345c-3ef6-7865-3836-b0a8c8865c88"), "Hong Kong", new DateTime(2001, 9, 29, 18, 53, 2, 497, DateTimeKind.Utc).AddTicks(2825), 845.843675203224000m, "Raven.Nikolaus@gmail.com", "Henriette", 900m, 692, "Eum vel.", "202-759-4631 x1816", "Gutmann" },
                    { new Guid("dd5df1a7-90bb-73e4-7932-adcae5dd9b15"), "Belarus", new DateTime(1959, 1, 30, 21, 6, 34, 212, DateTimeKind.Utc).AddTicks(3070), 405.131589226474000m, "Lilly37@hotmail.com", "Garry", 700m, 329, "Vel vitae.", "830-330-5485", "Carroll" },
                    { new Guid("dd5eef92-3d15-d7a9-ca73-611d8dad873b"), "Chile", new DateTime(2008, 10, 19, 19, 58, 29, 646, DateTimeKind.Utc).AddTicks(3524), 844.248617016409000m, "Austyn.Jacobson44@yahoo.com", "Roslyn", 600m, 265, "Sed omnis.", "304-218-8734 x658", "Wehner" },
                    { new Guid("ddb024c0-dcba-18d3-bf8e-1f938f1dc014"), "Albania", new DateTime(1939, 11, 24, 1, 22, 14, 3, DateTimeKind.Utc).AddTicks(3801), 63.1307192966968000m, "Rudy_Legros@hotmail.com", "Lina", 700m, 279, "Dolor consequuntur.", "(959) 625-9998 x082", "Zieme" },
                    { new Guid("ddd31981-3e79-b1b5-3311-64c3e15d818f"), "Guam", new DateTime(2006, 3, 14, 19, 46, 21, 177, DateTimeKind.Utc).AddTicks(8637), 78.5177273919451000m, "Abdullah_Rempel@yahoo.com", "Bessie", 600m, 810, "Est voluptatem.", "1-345-305-4905 x170", "Corwin" },
                    { new Guid("de4abf0c-827d-2938-fe85-37e87dbcff0b"), "Cook Islands", new DateTime(2017, 6, 7, 7, 23, 52, 620, DateTimeKind.Utc).AddTicks(125), 904.400387923522000m, "Alison23@hotmail.com", "Gianni", 500m, 218, "Voluptatem quis.", "288.851.9516 x715", "Thiel" },
                    { new Guid("de6c3ddf-d45b-7031-5b98-a11329ce7203"), "Mexico", new DateTime(2015, 8, 10, 15, 10, 45, 232, DateTimeKind.Utc).AddTicks(6779), 331.362419972427000m, "Megane_Brown11@gmail.com", "Anibal", 700m, 69, "Iure eligendi.", "1-241-457-5109 x9490", "Beahan" },
                    { new Guid("defdb9a5-7b20-4f09-81ba-76d773be4253"), "Paraguay", new DateTime(1938, 11, 8, 18, 38, 2, 171, DateTimeKind.Utc).AddTicks(3087), 85.758446521663000m, "Yessenia_Runolfsdottir70@yahoo.com", "Allie", 1000m, 276, "Ut accusamus.", "336-791-0694 x80692", "Quitzon" },
                    { new Guid("df892a69-2421-d8d3-f716-d1e750d593bb"), "Kenya", new DateTime(1995, 5, 6, 3, 11, 26, 523, DateTimeKind.Utc).AddTicks(288), 617.116339025234000m, "Ronaldo40@gmail.com", "Webster", 800m, 897, "Earum omnis.", "704.608.0527 x6314", "Runolfsdottir" },
                    { new Guid("dfb31950-49dd-46bb-d78c-0e07f8b495de"), "Guinea-Bissau", new DateTime(1933, 7, 17, 4, 45, 47, 453, DateTimeKind.Utc).AddTicks(4311), 223.057707417374000m, "Lukas.Hamill@yahoo.com", "Sydni", 700m, 335, "Hic molestias.", "(579) 498-6325 x4476", "Crooks" },
                    { new Guid("dfc85ce6-f3f2-e378-738e-fd8ab7484526"), "Brunei Darussalam", new DateTime(2003, 5, 24, 21, 24, 8, 485, DateTimeKind.Utc).AddTicks(6282), 494.530996320907000m, "Devonte63@gmail.com", "Abby", 600m, 636, "Rerum autem.", "(798) 993-4983", "Glover" },
                    { new Guid("dfcfb420-419e-b31d-5402-92cd5ee31fbc"), "Kyrgyz Republic", new DateTime(1962, 7, 15, 22, 53, 7, 545, DateTimeKind.Utc).AddTicks(6413), 880.571342181242000m, "Jakob96@gmail.com", "Jerod", 900m, 797, "Omnis nam.", "1-491-283-6696 x1187", "Stoltenberg" },
                    { new Guid("e02e2a02-fa6a-ad9f-597e-da2eaca7ef0f"), "Israel", new DateTime(1978, 5, 10, 14, 16, 31, 208, DateTimeKind.Utc).AddTicks(135), 333.848551124214000m, "Violet_Pagac@hotmail.com", "Jaiden", 600m, 83, "Alias qui.", "1-259-916-7708", "Fisher" },
                    { new Guid("e0b50464-929c-b03b-fb96-91dec36316f7"), "Brazil", new DateTime(2001, 11, 14, 2, 25, 0, 578, DateTimeKind.Utc).AddTicks(7565), 972.823885691634000m, "Dean_Raynor26@yahoo.com", "Trey", 900m, 998, "Perferendis dolorum.", "587-848-8387 x97309", "Bins" },
                    { new Guid("e0d4517f-2f03-2e5b-b9df-f63b0fcea9a6"), "Comoros", new DateTime(1964, 3, 7, 2, 14, 1, 950, DateTimeKind.Utc).AddTicks(2270), 807.075063193432000m, "Armand_Volkman@gmail.com", "Florine", 700m, 742, "Veniam molestiae.", "889.594.7538 x20554", "Miller" },
                    { new Guid("e109c02e-f4b1-bd20-a0b1-efac458261bf"), "Falkland Islands (Malvinas)", new DateTime(2023, 10, 31, 17, 9, 39, 439, DateTimeKind.Utc).AddTicks(4171), 152.238561721582000m, "Cedrick_Kunde@gmail.com", "Alexie", 600m, 478, "Voluptas minus.", "1-432-230-4755 x1760", "Kris" },
                    { new Guid("e12e0c1a-086b-4a04-32e3-6728678e2275"), "Kiribati", new DateTime(1964, 4, 27, 14, 40, 32, 997, DateTimeKind.Utc).AddTicks(7498), 212.79541067561000m, "Clarissa8@hotmail.com", "Reilly", 1000m, 871, "Officiis nemo.", "568.793.9098", "Koss" },
                    { new Guid("e1f8bd49-8784-9122-3b93-53d127e8785c"), "Macao", new DateTime(1948, 8, 23, 0, 35, 9, 634, DateTimeKind.Utc).AddTicks(2005), 76.803161729442000m, "Laury_Schinner@gmail.com", "Leon", 600m, 846, "Nesciunt sed.", "(909) 626-6371", "Lynch" },
                    { new Guid("e26adc19-c6d4-3336-325d-6708a211f765"), "Uzbekistan", new DateTime(1966, 11, 12, 17, 47, 12, 540, DateTimeKind.Utc).AddTicks(5215), 172.538996409034000m, "Edwina99@hotmail.com", "Amira", 800m, 999, "Et nihil.", "885.240.9123 x90520", "Breitenberg" },
                    { new Guid("e2bf59ed-bbfe-e740-6928-48eaeef3da4c"), "Dominican Republic", new DateTime(2019, 7, 21, 4, 16, 33, 377, DateTimeKind.Utc).AddTicks(3688), 645.235978208804000m, "Robbie80@hotmail.com", "Norma", 900m, 931, "Et repellendus.", "1-885-455-6228", "Reichel" },
                    { new Guid("e2fc6ba2-2b7b-421b-05cd-42b24eeb204c"), "Gambia", new DateTime(1997, 9, 12, 3, 30, 27, 899, DateTimeKind.Utc).AddTicks(4100), 713.245923138744000m, "Raina54@hotmail.com", "Reagan", 700m, 138, "Eaque nihil.", "764-235-0099 x3148", "Deckow" },
                    { new Guid("e3252268-f2eb-da32-a558-25d6c47df31a"), "Mauritius", new DateTime(2021, 12, 18, 5, 12, 20, 651, DateTimeKind.Utc).AddTicks(2787), 388.986340048681000m, "Aimee.Sawayn57@hotmail.com", "Ericka", 800m, 926, "Sunt sunt.", "(692) 877-2967 x3086", "Dicki" },
                    { new Guid("e3c1b08d-23d5-f54c-db70-12ada72b49fc"), "Greece", new DateTime(1942, 2, 27, 22, 34, 52, 239, DateTimeKind.Utc).AddTicks(7868), 302.013981483757000m, "Taryn_Fay@yahoo.com", "Carissa", 1000m, 434, "Dolore omnis.", "1-836-295-6121 x5545", "Blanda" },
                    { new Guid("e3f239f6-4dff-8a2c-023f-1a1ee895a341"), "Lebanon", new DateTime(1954, 7, 13, 14, 16, 47, 848, DateTimeKind.Utc).AddTicks(7594), 347.179621662584000m, "Brett.Hudson@yahoo.com", "Erica", 600m, 369, "Quia expedita.", "(280) 342-9702", "Johnston" },
                    { new Guid("e43766b2-e1dc-3a3e-3e30-fd1713ca6ffb"), "Moldova", new DateTime(1934, 4, 13, 7, 46, 10, 843, DateTimeKind.Utc).AddTicks(1783), 318.863008886971000m, "Lydia86@hotmail.com", "Enola", 800m, 22, "Et dolorem.", "345-832-7595 x139", "Kertzmann" },
                    { new Guid("e46095f7-f6ef-4292-f088-080b53b52901"), "Burkina Faso", new DateTime(1952, 3, 14, 22, 8, 42, 47, DateTimeKind.Utc).AddTicks(1736), 23.7775617186071000m, "Helga_Rath68@hotmail.com", "Einar", 700m, 381, "Qui in.", "1-807-330-8626", "Purdy" },
                    { new Guid("e51d6251-b0e5-6f14-08ec-880be615e8c2"), "Bosnia and Herzegovina", new DateTime(1981, 1, 15, 1, 48, 50, 811, DateTimeKind.Utc).AddTicks(5956), 282.029088234658000m, "Dock24@gmail.com", "Koby", 500m, 613, "Tenetur dolorem.", "(495) 387-1580 x5267", "Monahan" },
                    { new Guid("e52f21cf-c420-b01c-1715-cb4ff2af1b3a"), "Slovakia (Slovak Republic)", new DateTime(1957, 4, 26, 0, 7, 50, 587, DateTimeKind.Utc).AddTicks(3228), 95.663950415066000m, "Jules84@gmail.com", "Gaston", 500m, 353, "Tenetur voluptatum.", "1-552-770-6560 x9132", "Kris" },
                    { new Guid("e5402402-ed75-3b4a-3e18-368f41907eb1"), "Philippines", new DateTime(1975, 3, 6, 2, 5, 7, 220, DateTimeKind.Utc).AddTicks(9879), 323.612083985994000m, "Brianne64@hotmail.com", "Maudie", 900m, 84, "Nihil facere.", "437-795-1605", "Pagac" },
                    { new Guid("e5702034-9d2f-5693-1b72-f9fa479f7da9"), "Oman", new DateTime(1981, 12, 24, 1, 22, 46, 983, DateTimeKind.Utc).AddTicks(2156), 446.864391559076000m, "Isac_Olson90@hotmail.com", "German", 900m, 493, "Facere illum.", "1-608-792-4190", "Ruecker" },
                    { new Guid("e5c9e5ed-0d5d-6ddc-9645-688c637350c2"), "Mexico", new DateTime(2011, 10, 23, 13, 4, 18, 602, DateTimeKind.Utc).AddTicks(6332), 349.33023769487000m, "Howard_Boyle@hotmail.com", "Gabe", 600m, 226, "Et quis.", "459-216-6283", "Wuckert" },
                    { new Guid("e5d4d9d0-54b5-a393-6010-7c4d2314865c"), "Somalia", new DateTime(1958, 3, 22, 5, 33, 20, 230, DateTimeKind.Utc).AddTicks(3480), 310.559105044667000m, "Roel.Rohan80@hotmail.com", "Bernita", 900m, 944, "Harum nostrum.", "262-302-9814 x870", "Tremblay" },
                    { new Guid("e6bb1bc5-0a66-a2e4-dfaa-947d013f5441"), "Madagascar", new DateTime(1928, 2, 6, 13, 29, 16, 643, DateTimeKind.Utc).AddTicks(7951), 678.088950971775000m, "Enos9@hotmail.com", "Roy", 800m, 425, "Neque voluptatum.", "1-500-300-7463 x017", "Gleason" },
                    { new Guid("e72fb755-4538-710a-557a-5a0cdb6184a3"), "Croatia", new DateTime(2015, 1, 25, 20, 11, 10, 669, DateTimeKind.Utc).AddTicks(1186), 675.07739612271000m, "Armando_Grimes46@yahoo.com", "Mohammad", 900m, 730, "Esse est.", "264.945.9501 x027", "Kiehn" },
                    { new Guid("e770799f-0058-bb09-28fb-0df3878b67ae"), "Liberia", new DateTime(1945, 1, 5, 22, 16, 8, 602, DateTimeKind.Utc).AddTicks(7409), 499.63829468783000m, "Gino.Cartwright24@gmail.com", "Waldo", 900m, 988, "Numquam sequi.", "211-321-2608", "Feeney" },
                    { new Guid("e7ac7d68-fb3b-70fb-2b26-864a3012594c"), "Iceland", new DateTime(1949, 7, 19, 19, 5, 31, 353, DateTimeKind.Utc).AddTicks(7125), 956.704853733046000m, "Bethel.Klein@yahoo.com", "Matt", 500m, 49, "Sunt natus.", "720.379.4225", "Moen" },
                    { new Guid("e7dbc2e4-1274-f0c6-509c-653d1d986039"), "Bolivia", new DateTime(1930, 12, 21, 21, 33, 16, 421, DateTimeKind.Utc).AddTicks(8930), 612.038579822901000m, "Elijah64@yahoo.com", "Ada", 900m, 375, "Nihil quae.", "1-749-512-0620", "Larson" },
                    { new Guid("e8d4f4ae-73b6-3751-2262-f19e1a1a8593"), "Tokelau", new DateTime(2019, 8, 29, 16, 53, 26, 846, DateTimeKind.Utc).AddTicks(6684), 786.948775948151000m, "Joannie.Goodwin@yahoo.com", "Vance", 900m, 975, "Id labore.", "989-362-5892 x62936", "Runolfsdottir" },
                    { new Guid("e8f84772-842f-fd0a-2d9b-7ed036b0ad5b"), "Greece", new DateTime(1947, 2, 1, 14, 19, 20, 308, DateTimeKind.Utc).AddTicks(4149), 110.366017511972000m, "Kiarra.Hills42@gmail.com", "Reed", 700m, 703, "Velit quae.", "1-756-995-4263 x463", "Schuppe" },
                    { new Guid("e904e41a-ef4a-317d-586d-c2598898f82e"), "Timor-Leste", new DateTime(1963, 1, 15, 22, 17, 36, 184, DateTimeKind.Utc).AddTicks(2666), 612.358655959165000m, "Berta31@yahoo.com", "Luis", 500m, 766, "Voluptatem ratione.", "(374) 449-6364 x3754", "Rath" },
                    { new Guid("e9449898-f20e-0b6e-ee19-bdec89eba7a4"), "Heard Island and McDonald Islands", new DateTime(1992, 11, 20, 11, 23, 39, 242, DateTimeKind.Utc).AddTicks(7631), 14.6523565932541000m, "Cornelius.Abbott91@yahoo.com", "Catharine", 1000m, 994, "Est reiciendis.", "(525) 248-2135", "Yundt" },
                    { new Guid("e9fd4dc2-aa86-357d-8611-4259296ff5b1"), "El Salvador", new DateTime(1948, 1, 30, 20, 3, 57, 575, DateTimeKind.Utc).AddTicks(4577), 164.571992559923000m, "Lupe.Kihn92@gmail.com", "Ariel", 500m, 907, "Sit dignissimos.", "212.444.0859 x156", "Parisian" },
                    { new Guid("ea3e10b3-82bd-7a48-181a-2fa42bd01363"), "Poland", new DateTime(2012, 5, 10, 4, 34, 8, 673, DateTimeKind.Utc).AddTicks(456), 994.866413467434000m, "Myrl.Swaniawski@yahoo.com", "Jillian", 700m, 23, "Explicabo officia.", "(245) 395-6612 x296", "Klein" },
                    { new Guid("ea6007b2-40e7-52b9-6b0c-61ec65dae4a3"), "El Salvador", new DateTime(1966, 6, 2, 13, 35, 52, 231, DateTimeKind.Utc).AddTicks(7590), 502.329927527604000m, "Therese30@hotmail.com", "Cordie", 700m, 214, "Consectetur eum.", "(635) 644-0468", "Walsh" },
                    { new Guid("eb1fd1ae-60ff-6719-be4f-a98347412165"), "Vietnam", new DateTime(1969, 8, 18, 15, 47, 6, 189, DateTimeKind.Utc).AddTicks(2831), 583.81159463964000m, "Makenna_OConnell66@hotmail.com", "Brendan", 900m, 510, "Voluptatem voluptas.", "(876) 918-3022 x190", "Koelpin" },
                    { new Guid("eb7108d2-abcc-21c4-243d-e2f75053983f"), "Guatemala", new DateTime(1936, 9, 18, 3, 23, 35, 849, DateTimeKind.Utc).AddTicks(4363), 913.897527962204000m, "Lon.Klocko@hotmail.com", "Althea", 800m, 887, "Autem et.", "1-388-945-2764", "Hills" },
                    { new Guid("ebb5967a-ede7-2520-1f61-f1e12b149a2a"), "Benin", new DateTime(2024, 8, 9, 19, 24, 54, 414, DateTimeKind.Utc).AddTicks(8578), 155.389224629502000m, "Keenan.Torp3@hotmail.com", "Citlalli", 1000m, 11, "Voluptatibus blanditiis.", "(731) 595-1893 x8976", "Vandervort" },
                    { new Guid("ebb64bda-19bd-3844-56d5-5cf14ceca808"), "Chad", new DateTime(1953, 5, 18, 11, 48, 22, 566, DateTimeKind.Utc).AddTicks(4223), 374.739582944213000m, "Maude61@hotmail.com", "Sandy", 800m, 255, "Eum a.", "469-324-8469 x59534", "Runte" },
                    { new Guid("ebf99995-205a-fc5e-2d20-de1599cc1e43"), "Christmas Island", new DateTime(1937, 9, 29, 15, 36, 1, 455, DateTimeKind.Utc).AddTicks(8051), 904.497974560732000m, "Jamil.Prosacco@gmail.com", "Lilian", 600m, 749, "Rerum commodi.", "565.827.0572", "Feest" },
                    { new Guid("ec8b5b03-63cf-e257-0e47-093b5d5fc6e3"), "Comoros", new DateTime(1963, 5, 13, 21, 35, 53, 509, DateTimeKind.Utc).AddTicks(1852), 851.415008650624000m, "Rosa.Quigley62@hotmail.com", "Trycia", 900m, 708, "Sit molestiae.", "1-427-621-2718 x6460", "Krajcik" },
                    { new Guid("ed0f04cd-0631-0ea4-e4fa-cc200491853c"), "Dominican Republic", new DateTime(1997, 11, 26, 5, 52, 48, 197, DateTimeKind.Utc).AddTicks(9853), 79.9868385105482000m, "Uriah.Gutkowski@yahoo.com", "Idella", 500m, 845, "Tempore excepturi.", "1-696-467-6535 x4279", "Hoppe" },
                    { new Guid("ed3b368e-0fb6-2207-108e-2621f548a5f2"), "Republic of Korea", new DateTime(1984, 8, 21, 1, 2, 59, 949, DateTimeKind.Utc).AddTicks(8868), 731.35047145608000m, "Ayana95@hotmail.com", "Katrina", 700m, 166, "A at.", "732.814.8706 x75591", "Predovic" },
                    { new Guid("ed7ef41f-c404-1a62-4efe-f6092eb4d82c"), "South Georgia and the South Sandwich Islands", new DateTime(1931, 12, 3, 15, 53, 18, 681, DateTimeKind.Utc).AddTicks(5835), 435.265138457188000m, "Madison.McKenzie@hotmail.com", "Makenzie", 700m, 751, "Quo et.", "759.409.3110 x787", "Simonis" },
                    { new Guid("edc0bd60-23b7-f4c3-9c8e-d7ebac84fae3"), "Angola", new DateTime(1937, 9, 1, 1, 53, 5, 289, DateTimeKind.Utc).AddTicks(6297), 607.807049515212000m, "Imelda60@gmail.com", "Neva", 900m, 611, "Voluptatem ullam.", "416.204.0652 x2938", "Kautzer" },
                    { new Guid("edcfe58f-798a-4734-da89-b6b006769fb2"), "Equatorial Guinea", new DateTime(1959, 8, 4, 1, 9, 14, 655, DateTimeKind.Utc).AddTicks(3973), 840.870751500519000m, "Edmund.Nolan@hotmail.com", "Jannie", 700m, 772, "Ullam et.", "923.513.9170 x2789", "Bergstrom" },
                    { new Guid("ee1c08c7-9966-703c-25ff-934f5dd61355"), "Angola", new DateTime(2011, 9, 16, 6, 25, 29, 259, DateTimeKind.Utc).AddTicks(430), 586.920103086932000m, "Jessie.Schuster49@gmail.com", "Wava", 600m, 409, "Similique omnis.", "(548) 272-9972 x160", "Runolfsdottir" },
                    { new Guid("eea582b8-83a3-cdb4-d7ad-075fc2468c75"), "Bolivia", new DateTime(1991, 10, 28, 15, 0, 0, 940, DateTimeKind.Utc).AddTicks(835), 463.292626992644000m, "Jaunita13@yahoo.com", "Jaylin", 800m, 127, "Est aperiam.", "801.292.1151 x38016", "Walsh" },
                    { new Guid("eea5d86d-b541-d42b-a440-0100ba104bea"), "Mauritania", new DateTime(1941, 4, 6, 3, 18, 55, 264, DateTimeKind.Utc).AddTicks(7047), 124.831272571353000m, "Irma94@yahoo.com", "Teagan", 1000m, 915, "Aut et.", "464.801.3937", "Goyette" },
                    { new Guid("eee6dd21-99d3-76f7-7e8f-ae982516330c"), "Christmas Island", new DateTime(2019, 9, 29, 10, 33, 25, 439, DateTimeKind.Utc).AddTicks(3817), 353.242586612944000m, "Kendrick79@hotmail.com", "Elinor", 900m, 333, "Consequatur necessitatibus.", "1-432-357-7708 x0466", "Jerde" },
                    { new Guid("ef239e5e-faa6-fc81-e6aa-b538583dab61"), "British Indian Ocean Territory (Chagos Archipelago)", new DateTime(1964, 6, 30, 9, 58, 44, 886, DateTimeKind.Utc).AddTicks(1493), 844.42898885179000m, "Porter.Becker40@yahoo.com", "Elena", 600m, 295, "Dolores dolorum.", "413.965.5284", "Lebsack" },
                    { new Guid("efd3fcae-daed-bc8b-7331-fee98a8cc3f8"), "Guatemala", new DateTime(1976, 3, 2, 3, 32, 55, 650, DateTimeKind.Utc).AddTicks(5409), 733.091979757043000m, "Winifred55@hotmail.com", "Wyman", 700m, 367, "Quaerat vel.", "642.617.3838 x3597", "Nienow" },
                    { new Guid("f01bbda1-df39-0821-f233-d9e0a1925f42"), "Democratic People's Republic of Korea", new DateTime(1965, 2, 14, 1, 32, 42, 823, DateTimeKind.Utc).AddTicks(7009), 620.413553759738000m, "Muhammad.Strosin25@gmail.com", "Reilly", 800m, 837, "Soluta libero.", "(948) 274-2649", "Mraz" },
                    { new Guid("f065f0ef-e350-9525-a472-45977f25ba80"), "Norfolk Island", new DateTime(1962, 9, 23, 12, 56, 12, 914, DateTimeKind.Utc).AddTicks(6695), 759.64401144962000m, "Kristin_Price@yahoo.com", "Pat", 600m, 46, "Non amet.", "(367) 215-9082 x6663", "Weber" },
                    { new Guid("f1460f86-445c-d169-e34a-071d378d2797"), "Syrian Arab Republic", new DateTime(1926, 5, 12, 11, 15, 4, 153, DateTimeKind.Utc).AddTicks(8000), 119.873300393834000m, "Kelton_Bergstrom78@yahoo.com", "Alisha", 800m, 872, "Similique doloremque.", "767-235-3621 x9980", "Daugherty" },
                    { new Guid("f1e9d54c-2379-e8eb-1a61-014413b90760"), "Saudi Arabia", new DateTime(2003, 11, 10, 0, 42, 9, 281, DateTimeKind.Utc).AddTicks(9386), 269.618417758269000m, "Samantha.Mann@gmail.com", "Daphne", 700m, 454, "Tempore quam.", "1-797-847-3500 x938", "Emmerich" },
                    { new Guid("f213395a-c451-9059-74dc-1374d2836e03"), "Tunisia", new DateTime(1980, 2, 2, 21, 21, 6, 185, DateTimeKind.Utc).AddTicks(6128), 422.686826917237000m, "Jasen80@yahoo.com", "Braulio", 800m, 506, "Officiis aspernatur.", "(815) 212-7119", "Emmerich" },
                    { new Guid("f2641f68-9824-7c7e-f859-11ec16274cc1"), "Central African Republic", new DateTime(1983, 12, 17, 0, 40, 19, 178, DateTimeKind.Utc).AddTicks(8138), 714.587358298102000m, "Adelia18@hotmail.com", "Brycen", 600m, 843, "Consequatur est.", "371.331.9773 x419", "Auer" },
                    { new Guid("f2f8b88e-f5f8-97fa-17a6-ac0642d72603"), "Madagascar", new DateTime(1944, 6, 20, 16, 29, 59, 415, DateTimeKind.Utc).AddTicks(1928), 344.673268417421000m, "Burnice62@yahoo.com", "Renee", 1000m, 782, "Tempora saepe.", "(588) 989-9097", "Cole" },
                    { new Guid("f33f599e-636a-8045-9bad-47673e0af475"), "Mauritania", new DateTime(1990, 4, 5, 18, 25, 18, 702, DateTimeKind.Utc).AddTicks(4846), 622.138008047264000m, "Daisy88@gmail.com", "Oren", 900m, 462, "Quo nostrum.", "(835) 852-0316 x191", "Bruen" },
                    { new Guid("f3ed7d97-8136-28a7-1e3f-77c462f68598"), "Congo", new DateTime(2020, 7, 3, 13, 18, 10, 374, DateTimeKind.Utc).AddTicks(1642), 48.6738671425496000m, "Lisa_Balistreri5@hotmail.com", "Cleora", 800m, 275, "Architecto deserunt.", "228-835-3601 x8008", "Hessel" },
                    { new Guid("f3f581f8-a1a5-55e4-d6d2-3fe3e7e752cf"), "Western Sahara", new DateTime(1947, 10, 28, 11, 13, 59, 886, DateTimeKind.Utc).AddTicks(8072), 318.571923219908000m, "Dorothy_Trantow@gmail.com", "Liza", 900m, 496, "Quia qui.", "(282) 785-8055 x629", "Emmerich" },
                    { new Guid("f4466c8b-dc95-e958-25c7-a97f3de290ed"), "South Africa", new DateTime(1964, 7, 2, 21, 45, 0, 349, DateTimeKind.Utc).AddTicks(5893), 515.897218279109000m, "Casper11@yahoo.com", "Manley", 900m, 694, "Earum libero.", "791-205-8411 x251", "Abbott" },
                    { new Guid("f4991b3f-2c33-5a18-c14e-fc8f1a047998"), "Bhutan", new DateTime(1947, 2, 28, 20, 24, 54, 258, DateTimeKind.Utc).AddTicks(8047), 573.937947881367000m, "Demond.Stark24@gmail.com", "Shad", 900m, 760, "Omnis consequatur.", "(894) 618-2088", "Lowe" },
                    { new Guid("f4b0bbe3-1b29-681b-0d5b-068117caecd0"), "Israel", new DateTime(1999, 11, 10, 9, 24, 12, 768, DateTimeKind.Utc).AddTicks(1762), 356.147344049012000m, "Avis_Friesen@gmail.com", "Arch", 900m, 63, "Labore vitae.", "(413) 349-1048 x6403", "Fadel" },
                    { new Guid("f50a1a8d-c9dd-6906-5e09-a19f7be0d082"), "Venezuela", new DateTime(1983, 1, 20, 16, 15, 48, 766, DateTimeKind.Utc).AddTicks(5840), 494.213740846983000m, "Declan_Hansen@hotmail.com", "Laurie", 500m, 586, "Saepe aut.", "631-746-2670 x1657", "Wintheiser" },
                    { new Guid("f515cae6-56e2-8928-05c5-6fc4f5122cd8"), "Maldives", new DateTime(2023, 8, 4, 15, 11, 11, 568, DateTimeKind.Utc).AddTicks(2050), 377.7762880248000m, "Brandt.Luettgen@yahoo.com", "Arvel", 600m, 398, "Cum id.", "1-279-759-9628 x6987", "Bashirian" },
                    { new Guid("f52a4469-5a5f-a1bb-9fa8-67bb3345dc77"), "Gibraltar", new DateTime(1996, 8, 25, 7, 43, 31, 119, DateTimeKind.Utc).AddTicks(6552), 504.144834307376000m, "Myah.Ryan@hotmail.com", "Jeramie", 800m, 474, "Sit inventore.", "1-739-238-3770 x273", "Nitzsche" },
                    { new Guid("f5372abd-d494-6967-d43f-299dbc4de419"), "Libyan Arab Jamahiriya", new DateTime(1933, 6, 13, 2, 17, 15, 768, DateTimeKind.Utc).AddTicks(832), 788.149448376429000m, "Dorothy_King@hotmail.com", "Laverne", 900m, 524, "Aliquam reiciendis.", "(926) 738-7366", "Prosacco" },
                    { new Guid("f537a53b-fe30-fc7d-ae87-943affe8436e"), "Liberia", new DateTime(1953, 9, 16, 5, 18, 50, 683, DateTimeKind.Utc).AddTicks(6287), 411.271895477442000m, "Bradford.Streich@gmail.com", "Torrance", 700m, 223, "Vel eos.", "(501) 600-9551", "Dicki" },
                    { new Guid("f5eecc0e-6f41-939f-accd-b2b472f59da0"), "Argentina", new DateTime(1958, 10, 28, 17, 53, 33, 885, DateTimeKind.Utc).AddTicks(3812), 270.349293253893000m, "Kaia.Rau@gmail.com", "Fausto", 1000m, 580, "Unde modi.", "815-402-0603", "Parker" },
                    { new Guid("f5ff9472-9746-1383-e10c-b932ecdbd6e2"), "Macedonia", new DateTime(1934, 10, 6, 1, 55, 50, 340, DateTimeKind.Utc).AddTicks(5598), 402.304095076383000m, "Hugh87@yahoo.com", "Douglas", 600m, 304, "Aut est.", "644-399-0180 x54961", "Kessler" },
                    { new Guid("f62231bf-f2d8-7cfb-28a7-d2c575cbc096"), "Guam", new DateTime(1994, 12, 10, 15, 38, 13, 297, DateTimeKind.Utc).AddTicks(8309), 101.386065369661000m, "Paris_Terry99@gmail.com", "Keyon", 500m, 598, "Id quis.", "1-889-275-5419 x959", "Stanton" },
                    { new Guid("f631f9fb-e6a0-276d-4998-8824ca4d982f"), "Guam", new DateTime(1941, 3, 18, 16, 28, 59, 634, DateTimeKind.Utc).AddTicks(6223), 574.357353230752000m, "Chanel_Hodkiewicz@yahoo.com", "Kolby", 1000m, 812, "Accusantium in.", "318.759.3110", "Green" },
                    { new Guid("f655b7ec-690f-1b39-534b-d1967c9682ed"), "Cyprus", new DateTime(2007, 2, 26, 9, 17, 6, 866, DateTimeKind.Utc).AddTicks(291), 886.176266474141000m, "Willow53@yahoo.com", "Amanda", 500m, 620, "Hic id.", "(532) 770-0470 x5440", "Hahn" },
                    { new Guid("f655d820-cbe1-e189-6452-505cf87dd04b"), "Macao", new DateTime(1978, 2, 6, 20, 24, 21, 359, DateTimeKind.Utc).AddTicks(2784), 574.284986227925000m, "Keyshawn6@gmail.com", "Bonnie", 800m, 207, "Quidem ea.", "379.289.0416 x839", "Funk" },
                    { new Guid("f6852580-7124-192e-e673-ea389f05fc85"), "Belize", new DateTime(1954, 10, 16, 13, 33, 48, 966, DateTimeKind.Utc).AddTicks(2336), 334.057134992495000m, "Milo21@gmail.com", "Taylor", 500m, 473, "Deleniti ut.", "695-839-1595", "Abernathy" },
                    { new Guid("f6bc206e-ac09-6f63-694c-e11eb2d8f8bf"), "Botswana", new DateTime(1944, 11, 26, 10, 20, 45, 673, DateTimeKind.Utc).AddTicks(5733), 278.564866628495000m, "Thomas73@gmail.com", "Corene", 800m, 962, "Nihil iste.", "269.799.4675", "Murphy" },
                    { new Guid("f7664ee3-d5b0-b8b8-4fdd-c6577eb7ebc0"), "Saint Barthelemy", new DateTime(1985, 4, 26, 0, 48, 11, 583, DateTimeKind.Utc).AddTicks(6612), 194.640283779146000m, "Jevon_Koelpin8@hotmail.com", "Eleazar", 1000m, 289, "Quisquam expedita.", "(793) 810-4425", "Kling" },
                    { new Guid("f784c6d4-aae8-a8df-591f-d3f500c6302b"), "Antarctica (the territory South of 60 deg S)", new DateTime(1990, 7, 16, 18, 9, 41, 848, DateTimeKind.Utc).AddTicks(4082), 521.670631549882000m, "Maybell_Waters@yahoo.com", "Raymond", 500m, 710, "Reiciendis voluptates.", "995.273.6076", "Reichert" },
                    { new Guid("f81c3d53-b04d-e651-dbaf-356c6a95d1b1"), "Iran", new DateTime(1940, 9, 9, 23, 48, 23, 584, DateTimeKind.Utc).AddTicks(4651), 754.075345393281000m, "Travon_Stanton@hotmail.com", "Lilyan", 700m, 612, "Soluta rerum.", "271.448.2654 x8288", "Mitchell" },
                    { new Guid("f8302a1e-9ef3-3a73-3977-86aa4f110011"), "Georgia", new DateTime(1931, 8, 6, 15, 4, 34, 977, DateTimeKind.Utc).AddTicks(6874), 528.319840235791000m, "Joshuah.Batz45@hotmail.com", "Harrison", 700m, 228, "Eos maiores.", "924.800.2489", "Bernhard" },
                    { new Guid("f83d5074-4537-327d-9f6e-01c002b1eb81"), "Gambia", new DateTime(1952, 8, 26, 3, 59, 13, 418, DateTimeKind.Utc).AddTicks(708), 650.190751225256000m, "Susana.Runolfsdottir@hotmail.com", "Tierra", 700m, 489, "Et ut.", "870-209-6111", "Flatley" },
                    { new Guid("f86820c9-2edc-8e2c-a17f-d8565f233268"), "Moldova", new DateTime(1935, 2, 1, 9, 6, 16, 753, DateTimeKind.Utc).AddTicks(7303), 938.621865893621000m, "Justina_Wyman@gmail.com", "Kenyatta", 900m, 943, "Veritatis non.", "326.561.5397 x384", "Gislason" },
                    { new Guid("f8b75982-752c-895e-9136-6c80fbd32dbc"), "Pitcairn Islands", new DateTime(1995, 8, 26, 13, 27, 38, 687, DateTimeKind.Utc).AddTicks(6104), 434.374666883514000m, "Rickie63@gmail.com", "Alyson", 500m, 18, "Vero magnam.", "307.432.4852", "Kemmer" },
                    { new Guid("f8bea56b-c9c3-4402-65b1-cf64688c7ace"), "Solomon Islands", new DateTime(2011, 11, 20, 10, 23, 59, 745, DateTimeKind.Utc).AddTicks(2095), 668.214428274416000m, "Gay.Keeling@hotmail.com", "Octavia", 600m, 390, "Autem aut.", "721.365.8752", "Wilkinson" },
                    { new Guid("f8c3c70e-0446-415c-f7d7-43a0be93df31"), "Bouvet Island (Bouvetoya)", new DateTime(1968, 9, 17, 23, 30, 52, 437, DateTimeKind.Utc).AddTicks(7798), 49.7432171194472000m, "Laisha20@hotmail.com", "Myrna", 900m, 504, "Et similique.", "992.701.7043 x03351", "Kozey" },
                    { new Guid("f916888c-c839-2a44-3353-514cc899c111"), "Cocos (Keeling) Islands", new DateTime(1990, 8, 1, 16, 47, 9, 2, DateTimeKind.Utc).AddTicks(5976), 594.32875159416000m, "Mohammad75@yahoo.com", "Francisca", 800m, 258, "Porro ab.", "732-536-2567 x251", "Douglas" },
                    { new Guid("f9556c98-f288-6cf8-cdc3-5b750b459fb1"), "Brazil", new DateTime(1963, 7, 6, 6, 17, 49, 519, DateTimeKind.Utc).AddTicks(5662), 48.0475525722746000m, "Bertrand_Schmeler43@hotmail.com", "Carson", 500m, 464, "Explicabo saepe.", "231.507.8437", "Crona" },
                    { new Guid("f95b9ac3-983a-bb35-9f3e-b6671dc689e9"), "United Kingdom", new DateTime(1958, 7, 27, 13, 6, 35, 715, DateTimeKind.Utc).AddTicks(4199), 660.131647096686000m, "Izaiah59@gmail.com", "Thelma", 500m, 216, "Labore deleniti.", "(373) 311-9330", "O'Reilly" },
                    { new Guid("f9836672-49a1-e7ae-4429-3d92b3d04c13"), "Northern Mariana Islands", new DateTime(1954, 8, 27, 12, 21, 18, 242, DateTimeKind.Utc).AddTicks(9904), 181.440673227828000m, "Maudie90@hotmail.com", "Laurine", 1000m, 532, "Omnis molestiae.", "1-341-933-0567 x2881", "Ernser" },
                    { new Guid("f9dab641-34d0-b9b1-8a31-3dfcc61b24b8"), "Tanzania", new DateTime(2006, 2, 20, 8, 17, 30, 292, DateTimeKind.Utc).AddTicks(9721), 188.495591006806000m, "Jett.Schaden@hotmail.com", "Tristin", 800m, 257, "Perferendis velit.", "580-601-8572 x35772", "Torp" },
                    { new Guid("f9ef8fc7-06b7-610e-88e9-d547b496c638"), "United Arab Emirates", new DateTime(1950, 12, 5, 5, 10, 58, 898, DateTimeKind.Utc).AddTicks(2240), 951.635352156855000m, "Alberta.Schaden@yahoo.com", "Arlie", 600m, 234, "Ex non.", "(912) 611-9906", "Prohaska" },
                    { new Guid("fa02de5e-96bd-c923-bb5c-9e4fbc327c46"), "Republic of Korea", new DateTime(1987, 1, 2, 5, 15, 54, 131, DateTimeKind.Utc).AddTicks(6051), 165.698316201092000m, "Missouri_Ledner37@gmail.com", "Caroline", 600m, 651, "Rem modi.", "(496) 226-5195", "Lowe" },
                    { new Guid("fa55db47-6e7d-fafa-ad1c-363cf82cec53"), "Lesotho", new DateTime(1933, 1, 29, 1, 9, 27, 333, DateTimeKind.Utc).AddTicks(6666), 662.794089277546000m, "Cristobal64@hotmail.com", "Jett", 500m, 796, "Impedit aut.", "1-430-855-0112", "Blanda" },
                    { new Guid("fa5b49da-f1ea-e111-5970-087a9b8731fa"), "Norway", new DateTime(1955, 4, 10, 3, 26, 23, 482, DateTimeKind.Utc).AddTicks(6876), 350.254457585706000m, "Zora.Bernhard36@gmail.com", "Zoe", 700m, 330, "Aut eum.", "865-746-7632", "Mraz" },
                    { new Guid("fa68699d-9312-795a-b683-5e0e472863cc"), "Vietnam", new DateTime(1986, 12, 13, 5, 57, 32, 414, DateTimeKind.Utc).AddTicks(3160), 211.88873070455000m, "Darrel37@yahoo.com", "Jamil", 900m, 44, "Expedita sit.", "813.922.8746 x589", "Romaguera" },
                    { new Guid("fa6c7371-f66a-ecf0-183f-8cb4b873a553"), "Kyrgyz Republic", new DateTime(1960, 8, 5, 12, 47, 32, 849, DateTimeKind.Utc).AddTicks(8278), 526.643200663535000m, "Trisha48@yahoo.com", "Rossie", 800m, 761, "Sit itaque.", "933-950-1639 x786", "Greenfelder" },
                    { new Guid("fa9db847-3771-fc0a-53a6-1c7d451eef0b"), "Reunion", new DateTime(2014, 7, 6, 1, 30, 34, 817, DateTimeKind.Utc).AddTicks(7043), 413.25594140551000m, "Ronaldo_Gutkowski@gmail.com", "Mikel", 700m, 995, "Molestiae assumenda.", "460-653-8965", "Rolfson" },
                    { new Guid("fab5afd3-c42e-7cf1-2251-ccbe60cb1e67"), "New Caledonia", new DateTime(1996, 12, 19, 2, 31, 33, 768, DateTimeKind.Utc).AddTicks(1351), 695.682651322997000m, "Mathew10@hotmail.com", "Dedrick", 800m, 448, "Officia exercitationem.", "1-924-932-6462 x188", "Bahringer" },
                    { new Guid("face88b3-6927-41e8-1605-138efcc5d914"), "Madagascar", new DateTime(2005, 9, 15, 8, 20, 17, 98, DateTimeKind.Utc).AddTicks(5669), 983.597283886414000m, "Claudia25@gmail.com", "Terrance", 800m, 468, "Odit officiis.", "(407) 793-9650", "Medhurst" },
                    { new Guid("faed80db-6268-5d60-1334-9b4a45346913"), "Bosnia and Herzegovina", new DateTime(1987, 9, 5, 22, 7, 38, 527, DateTimeKind.Utc).AddTicks(9683), 207.765638240121000m, "German_Collier93@gmail.com", "Alyson", 700m, 882, "Quibusdam quasi.", "(532) 231-7204", "Haag" },
                    { new Guid("fbbc22a9-b056-7782-aeff-b77927971fb2"), "Niger", new DateTime(2007, 8, 18, 16, 17, 22, 268, DateTimeKind.Utc).AddTicks(1959), 160.044247901023000m, "Tiana.Lind17@yahoo.com", "Madge", 1000m, 829, "Eligendi rerum.", "852.898.8060 x1779", "Kshlerin" },
                    { new Guid("fbd30918-1adf-3738-ee91-ba0fe03fb366"), "Bolivia", new DateTime(2008, 4, 14, 14, 27, 12, 719, DateTimeKind.Utc).AddTicks(4279), 886.312606769512000m, "Erika.Bartoletti@gmail.com", "Bret", 800m, 452, "Qui aut.", "957.332.4943", "Abbott" },
                    { new Guid("fbeda8d6-d8b6-ea46-5b70-05922dff8887"), "Bhutan", new DateTime(1930, 11, 19, 10, 11, 15, 555, DateTimeKind.Utc).AddTicks(5419), 897.986997878914000m, "Lourdes.Gulgowski68@hotmail.com", "Nola", 1000m, 696, "Eveniet fugiat.", "(814) 957-9398 x1550", "Kuhlman" },
                    { new Guid("fc4a116c-30d2-ac75-ae09-833762bf9c23"), "Israel", new DateTime(1999, 2, 19, 7, 45, 35, 855, DateTimeKind.Utc).AddTicks(7892), 585.649838537609000m, "Willis.Denesik@hotmail.com", "Amanda", 700m, 806, "Eos odit.", "(738) 597-2855 x310", "Ratke" },
                    { new Guid("fcaeb55b-5702-b7d0-1635-c48b6b269357"), "Bhutan", new DateTime(1955, 7, 12, 0, 15, 3, 211, DateTimeKind.Utc).AddTicks(4696), 216.000726156758000m, "Ruthie11@yahoo.com", "Einar", 600m, 37, "Iure et.", "909.267.6246 x0003", "Jast" },
                    { new Guid("fcb1ac27-1cfc-aabd-6cf2-c3746276f4d1"), "San Marino", new DateTime(1927, 1, 26, 13, 1, 20, 788, DateTimeKind.Utc).AddTicks(5129), 386.424153427207000m, "Westley_Schmeler@yahoo.com", "Solon", 900m, 41, "Quo quia.", "498.360.7657 x28190", "Luettgen" },
                    { new Guid("fcbed392-0073-fb2c-d091-e6326a7f078c"), "Indonesia", new DateTime(2003, 9, 4, 12, 50, 22, 163, DateTimeKind.Utc).AddTicks(4024), 471.897894360886000m, "Bethel74@gmail.com", "Garrison", 600m, 244, "Animi beatae.", "509-437-6371", "Zboncak" },
                    { new Guid("fcd6fecf-a7c0-022e-fedb-f828099219fe"), "Tajikistan", new DateTime(1987, 11, 2, 0, 26, 34, 724, DateTimeKind.Utc).AddTicks(2650), 483.485755648082000m, "Helga23@yahoo.com", "Ricardo", 700m, 356, "Repellat ab.", "697-887-8565 x7892", "Wiza" },
                    { new Guid("fd309860-4313-5298-fff2-acb9ace42cc6"), "Latvia", new DateTime(1949, 3, 28, 15, 31, 46, 935, DateTimeKind.Utc).AddTicks(5349), 50.7226120692734000m, "Jovani.Mann49@hotmail.com", "Joshua", 1000m, 798, "Inventore deserunt.", "544.389.0718 x028", "Lebsack" },
                    { new Guid("fd43fb65-7cde-6dd5-1acb-2ba244565142"), "Angola", new DateTime(1978, 11, 16, 20, 6, 18, 682, DateTimeKind.Utc).AddTicks(9535), 522.426515995389000m, "Una.Emmerich70@hotmail.com", "Elyse", 900m, 113, "Aut quia.", "946-848-0659 x8455", "Runte" },
                    { new Guid("fd743312-a004-84d0-1cbe-04c1e10a0327"), "Anguilla", new DateTime(2010, 8, 17, 16, 8, 11, 569, DateTimeKind.Utc).AddTicks(2291), 117.918494285604000m, "Elliott.Franecki54@hotmail.com", "Kenny", 900m, 695, "Deserunt eum.", "432.519.3262", "Murazik" },
                    { new Guid("fd81634e-e176-a5bc-a354-b52647287291"), "Germany", new DateTime(1992, 5, 1, 16, 37, 4, 61, DateTimeKind.Utc).AddTicks(6888), 627.838466042775000m, "Adolfo.Leffler48@yahoo.com", "Loraine", 500m, 979, "Consequatur qui.", "1-503-782-0329 x905", "Kihn" },
                    { new Guid("fe0f999f-09bd-504b-d25d-dc20a2e48b1a"), "Holy See (Vatican City State)", new DateTime(1983, 2, 2, 10, 58, 15, 756, DateTimeKind.Utc).AddTicks(5524), 910.846365819476000m, "Dayana.Hickle62@hotmail.com", "Karine", 500m, 728, "Exercitationem aut.", "(316) 664-4925", "Wisoky" },
                    { new Guid("fe4e2c18-742b-d7d3-a50b-a2e8dd9b6f4c"), "Democratic People's Republic of Korea", new DateTime(2019, 7, 2, 9, 56, 26, 430, DateTimeKind.Utc).AddTicks(488), 354.123623314865000m, "Neal_VonRueden34@hotmail.com", "Parker", 900m, 633, "Et labore.", "(344) 713-6138", "Lind" },
                    { new Guid("fe929d2f-7d31-cd83-3b4c-10b384fc0980"), "Burundi", new DateTime(1931, 11, 28, 20, 39, 30, 297, DateTimeKind.Utc).AddTicks(7942), 56.7278760651966000m, "Tiffany.Langosh@hotmail.com", "Raheem", 1000m, 65, "Illum necessitatibus.", "1-503-658-3616", "Predovic" },
                    { new Guid("febd8b79-2156-3ff0-9f11-b7b75fc498e7"), "Tonga", new DateTime(1945, 4, 22, 6, 58, 33, 936, DateTimeKind.Utc).AddTicks(6599), 916.852262665583000m, "Krista.Wisozk@hotmail.com", "Hayden", 800m, 912, "Ex dolore.", "961-939-3260 x1485", "Zemlak" },
                    { new Guid("fef0b908-2b25-1ba3-7150-4cb61781dbe4"), "Dominican Republic", new DateTime(1992, 3, 9, 20, 20, 18, 107, DateTimeKind.Utc).AddTicks(7743), 197.349888063322000m, "Creola19@yahoo.com", "Carmella", 700m, 96, "Non modi.", "394.438.4260", "Altenwerth" },
                    { new Guid("ffaa3be1-1a53-3245-e03c-2bc04c729957"), "Montenegro", new DateTime(1952, 9, 9, 23, 37, 55, 434, DateTimeKind.Utc).AddTicks(8599), 312.925145017758000m, "Rolando_Wehner@hotmail.com", "Lawson", 800m, 723, "Non cum.", "690.798.1052 x64731", "White" },
                    { new Guid("ffdec6fa-d05d-f617-6bda-6eca481003d6"), "Belarus", new DateTime(1948, 4, 2, 11, 6, 51, 11, DateTimeKind.Utc).AddTicks(5079), 604.42328469486000m, "Hans.Conroy84@yahoo.com", "Deron", 500m, 970, "Eum omnis.", "(699) 601-0851 x607", "Fahey" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("00a5032f-f7c6-d121-5db7-bd4701cac45a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("0111978d-13c6-6bee-a881-78b170a3b5b9"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("0147b5b0-4542-2bfa-86fd-342f4d6b8921"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("01e13fc1-0b9f-432a-7da5-34d6d8a80044"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("02160680-b6fa-c22a-9824-9836105b6ec8"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("021d3645-1ba8-77bd-691c-3a8480f00028"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("024eb533-5585-2662-b917-7ff5d4196a3d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("025be73d-ffce-884d-e381-302cf3077cff"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("02c21a56-e7ed-b73a-871a-3d6715946210"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("02ea14d3-5d16-266f-f39f-ea226ac3c07f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("033384aa-74a6-66da-bf35-45e127468e52"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("03ece077-f465-6858-df5f-8fa69bf3737a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("041143c7-b296-f8a1-8df0-e4c6f871754c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("045b93a7-b86a-3d57-daea-1b640bed1901"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("0485d652-b904-5cba-c62a-20d0b010521f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("04e0030b-f8c4-1e7b-0dbc-2f836ccc3247"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("050518e5-b133-b4f5-bb0a-2f8a09697392"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("05090f1f-46ec-4731-d44e-e4cd94dba41b"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("05097801-25f0-cb7d-6548-ab9712962130"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("05246b48-ac71-4314-f935-73ae9a6302eb"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("059fe254-ed03-348b-72b0-53b0b63fd664"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("06295574-9771-f1e0-e20b-e72e5d39852d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("0668d09f-da20-695f-11be-ba7bfc77c693"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("068e96a5-8d8e-c3e3-948e-ece17908d986"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("06ee3d5c-c819-d6d0-d6df-20c3d694660b"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("06fe120f-908a-5be2-5aa9-0f57d0e668c1"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("074de468-9cfe-cd15-71b2-8a23829d1e62"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("07992549-335f-0c1d-1ec3-9e168c6c44de"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("07ab722c-5130-f87c-30b2-b6ab8d84c4b3"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("07cd8768-e0ab-13ff-0d58-4d4ee3e7938c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("083f3089-2bb0-3b71-1bab-3d6a52914e22"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("08b4abaf-ca17-817e-c2a3-fbe88fe1ae7f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("08c36232-9ab8-718d-90eb-c62765c91e16"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("08dbd89d-852b-b33c-49a8-a09e50d4a614"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("094b2d1a-1919-811c-ec2b-64e97113d068"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("096d3eab-2665-d0c3-b2e9-f5dfc56c94b2"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("099ce7d5-cdda-545e-92ed-8920730b885a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("09b811d3-d3c7-364a-4f19-b1b8107f1f5a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("09babca5-e967-9460-4eb7-317afa84d919"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("09c769a8-6b4b-3259-3b4b-0d98a3158117"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("09d57690-fed1-b2fa-188e-ae40645fbab5"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("09ec6ad8-9cb7-c424-4919-1cd1012faed5"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("0a317315-1e92-cf08-08d8-5568d40d3305"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("0a5fd863-021f-aacc-7a30-028458565da8"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("0a6d5485-c628-c614-bef8-b78a336bd113"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("0a72c9da-bd3b-acd7-79bc-76dbc7bc5a0b"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("0af64c57-7f15-337a-9efa-5259a6779117"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("0b137cdf-8f04-bca2-e1bf-4c30cf663621"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("0b4d8b13-8a1e-30c6-3e41-f7230bcb691d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("0b64274d-e950-7929-3c7e-d82ed5d0e2ce"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("0c6d4701-fa4a-67f1-05f8-f4d12710ba66"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("0cb4c38f-c26d-388f-0847-ffbfe6a0e309"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("0e036b28-34e6-43f4-f7f5-2595dd6bea4d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("0e0f17a7-f1d0-66e6-d587-5809f5546501"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("0e61812d-1ef2-53c5-65d8-56844cb49409"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("0eeef62a-915f-e4b6-302b-2cedbe60602f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("0f514e6f-bf23-b9ff-d52a-97fd28588fa9"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("0f67eca7-2e4c-b71b-6ac2-c781775687c9"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("0fa1f50a-ff2f-f8a0-4d99-b2ddc9bbb47f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("1028bffa-c23a-84fc-4a61-52d19e2442ca"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("10440ba8-a1f8-6e9a-c335-3e1104386432"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("1055481a-852f-df53-05bc-891def912877"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("10b81a0b-0340-bd0f-4fe6-914a3af1654c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("10e1de7f-fb9b-be0f-30ec-4d8a70f7a4b9"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("11f1bafd-4268-1e83-c1d4-dd02f85723be"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("1214ea69-62d9-a3b1-8e28-90bd9eb96cf5"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("12bfd37b-dc34-ac82-dab0-bfba6f2d29ec"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("131cef0a-eba7-5b71-30c5-386a41125515"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("1330516d-f96b-a781-6ee1-f490eef86a37"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("1353fe8b-ae65-a91a-99bc-42746b03ec2f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("135b10a8-c77e-880c-c79b-1394a078088d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("13d0c4b7-a2a1-bf73-751a-78b4869fd2f1"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("13fcd18a-695e-0fe3-99de-ce1b97dc7262"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("1407b112-2e73-dedf-91bc-376d946cd3a2"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("14135c79-bca4-9aa8-982c-ea6e92ef3f93"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("145b9af6-807f-8a6f-da06-3d787e99378b"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("14dde31c-2158-2f43-010f-b5ddf3ab9be8"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("159ebe22-620d-9960-6cc2-5f4d98bb901b"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("164c0b41-232f-de61-d04b-94a7785e58b6"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("1653d3b0-23c2-36fc-fa91-58a9bf859bb0"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("16f1a881-1c77-bcdf-3437-f30dc1842412"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("176fad9e-d783-114f-0688-6115a6c30a5a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("17cbe43e-a9ef-0297-0901-f71d772872bc"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("17f0e947-798c-93bd-d989-f2de6025e90d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("183d516d-9419-cafd-3aa8-61c6dbb43ebe"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("18460192-2fea-78db-e25f-6d1d3b883d87"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("1873f7a9-58e5-54ad-70b4-cdd4ff637335"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("1887289b-c0f5-38c4-a52c-760e5b67a142"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("18af8ed7-6bec-c182-46e2-e7e4a4480901"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("18c906cb-dc15-ba1e-b1f3-77c4f329e13b"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("18f34dd3-1d5e-7c6a-9a5c-e5c14774474d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("19157c5f-d2b9-5454-447f-fd7365486176"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("193b9bb6-f1a4-ef35-541f-8f977a42330a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("19535bee-6eac-334a-28e7-85c2e31d9c1d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("19aa5543-b682-4dc4-18b2-21a11485d90d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("19d97078-71c7-97c9-3909-976016cba15c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("19dbe816-9c16-61ed-c6e4-b646ed8c2b0a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("1a2dd853-3147-5e17-20ff-e725820cf2c5"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("1a3abb3b-3bd1-1e2e-c02d-1dc139b4b7fb"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("1a43d088-3990-dff1-1b46-2f190a40f56c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("1a839a51-5661-ef74-872d-7074488b16f0"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("1a85d98a-0974-b8e4-f0a0-517dce016ab0"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("1bbcf22f-6cf4-e580-5144-e7e4efb4cb9d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("1bcbcc49-2722-e3f9-17d2-d32598b9b812"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("1c5640cf-7093-963c-85de-0c2bdcf1c720"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("1c625058-fa14-b391-1c81-286825cf4e84"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("1cdadd4a-29f8-b31e-2343-e80c703c2dde"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("1d02aa3f-5202-2efd-41d1-1c185719e7f8"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("1d79ec58-a3cc-03f3-0407-896bfd2b3664"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("1d80a5c5-3709-426a-46cb-c9e0e5aa0e15"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("1d90c141-8a53-16cc-1066-e58f1951630e"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("1e14d451-f1ea-a2ed-a742-fd25869fe5e9"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("1e1cccfc-d3d7-7c17-eeb8-0d43dee5ae48"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("1e737738-6c20-9a32-16f2-1d1fe1bf6794"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("1ed26933-5124-faa2-2c12-43074c1f8206"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("1ee45b99-6e27-5ed8-6c78-bdb4db02a0af"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("1fb51973-75bb-e4d0-1d60-2b2f1efa1537"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("1ff0eacc-e33e-25d0-cc36-d83c39c8bb2a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("202824a4-111d-b751-da36-6cc348390257"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("203fcaa7-8dbe-17ad-ef6e-bdf36d798485"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("20e5f8dc-6ed3-3db2-bd1d-c8275c7688b7"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("213edf6d-ff3a-0fbd-bcb3-11258adc5d74"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("2155c8fc-e5d4-b5e4-5899-288e867ddf52"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("2228fe08-39ae-f41e-0bb3-6a8d43a46111"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("22849655-d8e2-714b-211a-da9889ef7952"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("22a46405-b210-7d9c-5c15-94d9494cc3c1"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("22b5ad7d-7c21-64ed-8cf6-0b9f688b0503"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("2314e9ed-6b9d-f064-9b12-7d32b1485dbb"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("23bf9e55-bb81-24b9-7a90-46aab6eda0d2"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("23d918d5-2efd-f513-93a5-a8f8c6042282"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("243d2580-3b94-400f-4a7c-2fc231c44806"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("24d0e00d-99d9-a066-4f49-f03a52ff233b"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("263b49a7-ec7b-3b4b-db6a-edd036d5b97c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("267e69b5-c90f-4eb2-0d64-8bab2c965d70"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("2731cbc3-aa6b-b5ee-f6a3-f43a13532af3"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("275891ad-964e-e9f7-70d5-53d3313a56d1"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("277c34f6-0c89-21f7-9256-2631f2e70bf6"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("27f87c42-33f7-d030-6919-d77df908728d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("28256165-3178-0ee1-5714-9a4f5762f6f4"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("28e7f848-5323-07ba-d80b-bafa966fcdc3"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("299a9555-0049-1f32-e690-9b3956867518"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("29d45372-71b5-d72c-3309-b054a46afd2c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("29de16e0-1416-2f09-4f7e-06fd09178822"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("2a2b2e37-4237-31da-5fa3-a4b781e4605c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("2a7ecb56-db25-2488-4fd3-959e7874f910"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("2abc4cbb-c010-3b18-509b-364b62a20fa8"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("2afe2516-3af3-4e5c-a0e2-171286342119"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("2b208252-521b-787a-4211-3b54d3be429e"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("2b49267e-0fe2-6dd7-23d7-fb00ff7852df"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("2b4bb993-7ad1-552d-853e-3a5b2d05fe10"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("2ba9b243-794d-ff3f-d4d8-3573646de74c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("2bb56234-4395-c5e9-b919-b38d8d4839ca"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("2bb8e333-4bb7-d016-bcba-049371805f84"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("2bbdceb2-1dee-1e20-a9a3-0e715738bc29"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("2c2f0ee1-dfd9-2ee2-a5c6-8bfd8dbd24bc"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("2c41ff4d-4036-4f5c-92a0-6ccc270ec424"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("2c980578-2f1d-43f8-c93b-50fe7da682d0"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("2cafdcb6-e324-f23c-78e7-76a98103c65f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("2cd7bafe-499e-0e71-9728-2a2c93f87038"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("2d09f2a7-7958-fd95-3143-8846651d3c31"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("2d53da1e-b331-a03c-65c7-b995cb79efaf"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("2d5b5bcc-ee0c-2241-e941-cff5f6487989"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("2d6a6767-a9b6-4123-e4e8-9dec9954ecbd"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("2dfcdc96-14e5-aa0b-a2ab-b127ba79003a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("2e636a3b-ad9f-0603-223f-050d4984229a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("2e7ab621-6806-a492-274e-b82ad16203ac"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("2e9ec634-4f66-b2ac-9585-bbeec45fec60"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("2eb4780d-a4a7-fd58-cd1f-5723351ea405"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("2eedc64b-5189-6c0e-6a20-39e27e0570a0"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("2f25dd73-5672-a52f-5e97-765d80e3b0cb"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("2f4d2963-d06d-020a-dd0a-0de5af15748f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("2fca88c6-27e3-bac1-0116-22119cc849b4"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("2ff91bda-9d2a-8033-79a2-e66412ccc79d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("3005ddf5-309e-97e6-1658-3b9da1dff27d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("303bfca7-ab7c-639a-1582-44daf380cdb3"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("30d90617-4d37-92b9-e081-2fcf8fdd33fd"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("30f78fc2-23c4-4acb-7cfa-ca381a33400b"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("3120604c-b1cd-63c0-bc94-e39d09fbd97d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("31466db7-2819-35c8-b398-39e2fca95ac4"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("31622965-18dc-dcad-9336-1d96b185de07"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("31e16dd2-d43f-143c-3ab2-cc6323d0a33a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("3223e0a3-c658-96af-139a-8920f94316f3"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("325e09d9-f67c-f727-d55b-1cd1706843a9"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("32861c95-8387-7f83-3a57-80caa5049b83"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("328e4f68-08c6-e82f-2167-22a30385cdf0"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("329d4abb-e846-72cc-17e3-e357cfab7e5e"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("3314001f-02e8-89c0-6c6d-9ad5aedae2a5"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("335c1190-c85c-c2da-d3a1-767ede859707"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("3390c3b6-b46d-1f2c-3207-2cef404feb2b"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("33ce96a6-9d6c-3aec-3ae5-cbab52c4c21e"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("33d74ec4-b1f1-6997-f081-858f38b5efde"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("33eb1825-2e2f-9802-1ef8-afb0f1f65ef6"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("33f94973-abb8-3a2b-70db-78e47f307760"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("34201f6c-a7d8-f29e-8a99-36ab903d80b7"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("3449162d-9f82-21e5-64f0-f97b8faad38d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("344abde7-c31f-f966-d113-73e91a7c13e7"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("345538f8-2e90-5c1d-8632-18bf05eeaabd"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("346b925b-dcd2-9161-be90-618d998fcb2e"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("346ff74a-b3c0-1164-79a3-214ab8197d63"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("3497dd38-c41e-ac79-952e-3e05bb8c00d5"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("35223fef-7098-2ae5-f0f0-cf3eb04c8afe"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("3595c5e7-6770-0299-3ef5-7a24d9bfc3fe"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("35a62308-5ba4-0eac-9de6-5e2b8e4c2b88"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("36053568-a612-77a6-45e2-210a548d5dee"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("361e0454-3263-3134-89f1-cb6214d66f7d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("36f95d15-545c-441c-be9f-4c16124ee573"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("370544e5-a0cb-8383-6366-4fe45778b8de"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("371f532f-e1d2-eab5-4ac5-eaefefcf471b"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("37fe84ea-04e2-5b2f-d10b-1a7fdbec1ba2"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("382eae1e-69f4-c7fa-92b0-b155fa83345c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("383756f5-7a82-7374-af75-73b66c7bc126"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("386f5aa0-a48a-58c9-991d-774657ad3bd9"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("3887688d-2942-e084-b47f-fa1ed4f7599e"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("388faf58-78bd-1b2b-d13a-dfaa729f59c2"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("38a19326-3935-77ea-c909-2ad7ef9b5453"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("38ca94a1-5605-8789-269d-d398260d31b1"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("38d4597b-228c-3e37-4f3a-41f619b9bafb"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("38db7e2f-8a54-a769-d2e9-4cf650b264be"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("395ffffb-ec4c-0719-e8cb-f10c92471371"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("398288be-1783-a165-8783-b9e9174391ac"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("3997dbaf-5f34-2f55-8fbf-578f2f31ee27"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("39cae5a3-6599-d7eb-0165-5f5fdca49796"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("3a6759ee-943d-6152-6903-dcb6395d1b20"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("3a7bf0fb-20f2-ef7d-1342-c867e99f0230"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("3a9ab21d-6975-3699-20b9-a12eaee7c58d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("3aa3d476-ae37-b066-3874-3cf1d216c971"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("3ad7ca89-4ae7-4bc9-c8fd-73fa882a2b2c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("3af1ecb9-32b0-78c3-dc29-522efe93b42e"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("3afae1fa-8a06-980a-85dc-96cf911846f3"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("3bed5056-2571-2bf9-36cd-d6514977901f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("3bf16a23-f417-deeb-553e-d442e9622927"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("3c1db86c-0228-0a90-ddb8-ff96a12c8d3d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("3c64ab8c-b9cd-89cd-1e21-b19abc5e6ce5"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("3c8289dc-e5e2-b0c7-3011-f740b1607476"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("3c8453bd-6a80-2cad-cb4a-99ec72eddfd7"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("3c961091-196f-b3c3-0d6a-1db15a7802ac"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("3ca920fe-8475-390d-147a-ab86871cfb90"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("3cdfa7fe-921c-58d9-baba-92861a281534"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("3d27cf9e-a08a-e431-27a9-520fe844d3fc"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("3da4c442-3269-a831-0dae-272f4163ca5e"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("3e1fb220-b08d-5cfc-2a7b-4d0e31ce115d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("3eed4eb8-b5e7-a3aa-26bc-c79fcdec711e"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("3ef6b628-84e3-67f3-7d3a-d256a4453c77"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("3ef8b365-1a4a-f290-5c7d-3249b8241ad9"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("3f3d0db2-db1c-4252-b7da-4e1f3044da5a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("3f6e547e-95ae-aff3-8cc6-d2b964b649a4"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("3f819446-d686-dfbc-2afb-01e44ff81c39"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("3fe86a38-e26a-35b1-a5af-79c0b86f5610"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("40174214-6589-1317-8de5-ab674c12d56d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("406a6865-51a9-c962-a35c-6dde07260f05"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("40952757-19fc-ee67-cf63-d87a0ea1c411"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("409a14ec-3660-09dc-8a32-202199e3334b"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("40c60e1c-4c2b-21a3-8a77-ebdf9a616a7d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("40d12b3e-7e9c-39e2-68a7-d75bebb9b536"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("410e7466-43f1-159a-fbed-1db3271e05ca"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("41275a9f-cb55-1b4a-84c3-cf0d5aa8f81c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("4132e2e6-f51e-1b6b-6b35-159fc2ada9e1"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("419d83de-edac-8079-144c-e3f0356c57c5"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("41cadbe9-6b42-f797-0254-edcdd72acf8d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("41dfab9a-f0db-9aa8-40b9-528ef84733c1"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("41f3a865-3865-2f3f-38f5-873dc61acfaa"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("42251f30-0f2f-b8d3-f220-6fb63c363556"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("4260ca98-9f3b-c196-988f-ab6b09c69ba4"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("428fa322-065c-b98a-f7b3-9432c4936e56"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("4294076c-bd30-2d53-2c2e-9569cd04d2cd"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("42d090f7-aaad-e6dc-50d8-269be5d9cc54"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("4322a1fc-65c1-5dcd-386e-b97a3e3345a9"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("4335a818-82c5-10bc-60ae-b66ef1c7fbe4"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("43401dca-6950-dba0-f64e-3feec0f5c533"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("43433227-cf43-d6c5-11e5-5906f91403cf"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("4349064e-e657-f3f6-42db-08a57d474a99"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("435a95f6-143f-e99a-a0b7-a260b48c19be"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("436c9787-e3e3-2d8f-62ba-096d743222d9"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("43ea3535-c1ae-bc59-7221-563467ea4f3a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("44058857-8ef3-2219-6b3e-d78be1ac1e87"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("4457399a-f2a6-53f9-a616-875406aa0c25"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("447efbb9-3964-bd8c-2bc5-d4e3719f48f9"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("4522463e-562c-d3c2-bfa0-d337f08566c6"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("45be9a16-8914-e206-a682-43a418d3dee4"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("464d59a4-4e95-bce6-1047-ad1d82990915"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("46e5da3b-3061-e490-4208-4eee20d93437"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("470c6f01-db69-c377-fec2-f47fd53dfbac"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("4727d4d7-3b85-d3f5-040c-ddf943c2c80c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("477a986e-142b-271d-a98b-ac7628806db4"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("4801d579-9aa4-052b-682d-874f339bc971"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("48309199-4db9-338b-1a61-abb3f7beeb68"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("483cd2e2-dbca-8005-442e-f5f273c20e13"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("487c1352-0c2c-077c-ba2d-9f0b7f54d569"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("490da1c7-7c09-f186-6c9f-9719e01adab2"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("491d5bd8-25d1-824a-855f-f82137f013a5"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("493d8bcb-6788-55e9-0d2a-d0c1332a279f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("494055d9-71ea-9680-ff36-774733342aac"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("4945fe91-8e6e-5afb-ed79-2a1bbfcf5e25"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("498e0191-4c6e-d990-c544-b78a54b2fec8"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("49b8ffe2-deda-f1ca-4c36-24126edc9182"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("49cfe21b-7918-df1d-7c53-ed434d59d3ea"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("49f0aa8d-1e4b-200e-0149-a7d0e01a7b5c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("4a120d65-1afd-c14e-9156-3c4c213afc16"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("4a2ddfaa-cfdf-671d-b74f-e8f4ab65ca1a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("4a99e866-1041-7a61-efb7-0711c4328678"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("4ab82cb3-3af7-c939-fe9f-520a46fc2777"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("4abc2b9b-5d50-0843-07b8-3385719a1115"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("4b77c489-0fab-af68-36a0-02349b7e2b86"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("4b7bbae8-1f2d-c4bc-9734-9fb4a18d1514"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("4c5a762c-16e8-63ef-e301-e8ebf9de3ecd"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("4cb7c202-cb62-3216-501f-2b4c22003e88"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("4cbbb1f8-57f8-e9ff-e21e-7ca999b3e053"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("4d448b4a-8901-d397-9214-1bcf07d7ebbe"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("4dab3f8c-cde3-e3ce-c537-eb1807059bfc"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("4de2f340-0ecd-1356-95fe-6df2809d173a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("4e00c0e0-77b8-22be-c7cf-c5b610041551"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("4e06894a-bbeb-b732-73bc-e33188047d98"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("4e12b3ca-1b34-8f8b-9d22-32ee24a85d3f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("4e6c7075-00b6-1f11-b8e4-103673a7cb0a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("4e7a6929-fee9-35e5-7eff-e1b6a4a15e71"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("4ecfd8a1-1d4a-789d-7756-8e7be28a2365"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("4f14159d-986f-c32f-a90a-c18d9f8c715e"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("4f1da4c5-d31c-c449-6297-dcca6aec2425"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("4f29d8fb-1e3c-c8bf-f619-0205d02bc2aa"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("4fcd4e53-5f14-6a4f-1710-78f577970136"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("5059d37f-8bce-9c2a-ca7c-298a2f707375"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("51bb9f6e-d907-c61f-45d5-0ad1b268610b"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("51cac733-c096-af2f-9047-0e41d5dab830"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("5215cc7b-c4e4-0c5d-d06d-16b856ae7475"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("524482b9-944d-98a0-449e-650ea0a7cf57"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("52643705-50ad-15b4-ace7-0a579f72a4a9"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("52b099b9-49c7-9ac2-6364-00468fbef186"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("52e9b21f-2de6-12d5-7fe0-f86528b3dacb"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("53027ea9-afdd-c3fe-4247-775ea350a484"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("5318a82e-485e-9e7a-0036-2e86191fe46b"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("5351e240-ba01-2ef6-3151-952a57c659e8"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("53a81c03-d986-470a-66ba-a734ad0976a2"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("53a88993-ccdc-ea4b-4c3b-9e8f62f89e62"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("53da8b75-b84f-396b-88c0-9b893f0fc41d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("540143e2-7e7f-2b8b-c2a4-4231877c5633"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("5552a97b-1da1-ef27-4756-2a884a107b7c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("5568973e-2405-a48b-480f-ffa68c3f3b55"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("55a4fe41-3bea-8b85-8017-99d0a45212ae"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("55c4797b-7e90-8217-2757-9850fa1e6234"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("55d78144-0ed7-155a-c87e-0f2e4473c66f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("55eb2e89-2910-3164-87c7-4bdfa2e8a62b"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("56325f6b-7797-db13-f2de-0523305ad82e"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("563d7c6a-c2cb-34a3-3c91-35ae7880c2c0"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("56a07d9f-ed85-c847-ff0a-d8a5ce8893cf"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("56c6143a-e6e7-08aa-7034-2f7c291d1225"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("574be2cb-b477-17f2-4edc-ee466fea9c16"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("58b48382-f973-5c53-fa09-ce8a4bb673d0"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("58f4c583-7e9f-dffd-e320-94370970e4f8"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("5952ec37-ad47-4aaf-5db2-b14e2d4ab36e"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("595f252c-1357-cbcc-87de-0ec9f3de47da"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("59ae9483-be25-4f9d-8ac2-290ad1520a88"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("5a02a7da-1d70-d041-441a-cad42f46f71a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("5a5283e2-b3ab-2921-a5b8-f1e2d082487b"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("5a8fd88e-8ff4-9205-5450-152e2f7328ba"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("5acce7ad-e256-6ecf-5067-80ddddc60f98"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("5b377e81-bd50-41eb-5650-80a9bcebf179"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("5ba4037e-1aae-cf66-28ad-cefb2bb9a2b5"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("5c23983f-4fd1-9b88-256d-1ed809ce5d75"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("5c734db6-d02e-f107-7893-01738a8baa20"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("5cf23ae3-eb18-6439-e057-b3e03944aa91"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("5d3fcacd-12e3-60a5-7744-a71498bbca13"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("5d4b0ecf-527b-ae92-45cc-07001c0068ce"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("5d625c54-2ea5-adf6-ec42-18e96724a13a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("5d88f2c4-ec84-e005-2f63-ec6cfed919b9"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("5dbcfe48-6561-8de2-7524-201a9b754f24"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("5eb18de9-13c3-16ea-9bab-9e4edaacba99"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("5f0fc63f-2983-1eab-2533-233c63aef8d7"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("5f1ffc66-98cf-df89-96a2-5a9bd0bfc9af"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("5f296466-6e53-2ab2-39d4-2835168353c7"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("5f863408-c80c-c3c5-a402-a8add7a1d6be"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("5fa19fa8-599c-b00c-87a9-0c05bfa75b7e"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("5fc6af5d-ecc5-4553-d096-eb7f53f0cb6b"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("5ff5d53b-2c3c-8d58-ba34-5a85e5919abe"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("600dae9c-2708-450b-df9e-204f0b308028"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("605d19c4-037a-72be-038f-a42d5bd01dac"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("60829b83-be90-f5f6-47e8-8a0607405668"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("60e4d5c9-ea40-1632-dda2-6ced5086460f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("6174c48b-38d0-1047-05d1-d24112a34cb7"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("61788436-22d3-7e83-1f26-0613c11afe37"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("61af5569-13c2-3da0-0f56-cc5db5594015"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("61e24e10-7262-488a-db1a-ed4760f16c6e"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("61ef12df-cda2-216e-3053-7629e1449bd1"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("6254677f-516d-6304-7d72-38f771c0274c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("631a0c4c-3c39-3444-348e-ae360701dcf9"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("6323e3c8-4e02-eae1-26bf-b0c65d3bf926"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("63453ec7-8fef-780a-ce9d-00ee95ab73ae"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("634dbc91-024c-8bfb-c586-911985594e81"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("6352f511-517a-998d-a929-22a578586186"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("6363cd66-44db-3225-a04b-4823ab54eade"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("63735af9-04d5-3f5a-e7c2-7010c448df0e"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("638835b4-a0a1-f647-582d-49fa75f46846"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("6414c1da-9b7b-9eee-43de-89ea676a4438"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("64952740-0aac-3a78-f81f-efcf6e56b573"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("64ad0362-ad54-06d7-1130-77bb0232c089"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("64c6e1dd-65ac-5d67-1b7e-18702bec3d24"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("64e1f4d8-5777-f050-1027-1dde1a60c6ee"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("64ef0baa-13f6-95d5-fc7d-10513a6efe66"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("655a21c0-4570-530e-976e-c97b6ce55f16"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("65cac6b1-f59c-e8fa-a7c5-c57f4ffb5a10"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("65e06eb8-e9d7-4dfd-bee4-6b94cc9b5a5f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("66677998-f086-1b26-968e-b43fd3baf2ff"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("666f100f-7acb-b33f-3de5-1fbfdb304791"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("66b39dba-8d9a-edd0-d570-cd7851e7754d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("66be6157-d24b-6dc0-d547-55faae567545"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("66d34181-a3c4-3ca3-40cf-8b6f2378dab5"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("670868e8-9ef8-9b1b-de75-a167c218a7d0"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("672f0cb6-be72-cef5-7b51-16f921615e10"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("67bed084-5d27-10e2-7433-1aa781529a15"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("67cad329-e0f5-4e3d-755b-2c542dcbe3b4"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("67d9cdc7-5faa-ffb6-4288-52411d0feed1"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("67fbe1a5-de85-0d5e-58af-532ba811dc18"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("6843bb8d-b1c0-ed45-f4be-4d75145e258a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("686d8e78-f2e0-12ae-c872-46e05ee4ef4f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("6898ec6b-de76-2953-7da5-7ba3d24b4075"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("692ece8b-727d-2f0f-cf74-12696caef31a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("693a8e76-777c-6ead-2fe8-016b52b0c496"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("69af5030-19f1-c7ea-6ee8-342945b38f5e"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("69dfc2bf-5694-3e76-1707-804affd59aff"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("69fda974-1c23-b273-3a6b-f558915f5714"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("6a38705e-8e50-9a7b-0287-135d2f5fb734"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("6a3a4279-e398-e54d-d680-0c2eb41404a1"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("6a41a6fe-4258-7f18-a084-d67088559032"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("6a719712-3ecb-f08a-3eaa-6fa2db5489ff"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("6ab62e65-c344-67ed-03e3-e699e4719fd8"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("6aeb4853-3a68-5429-134b-66d806b4aa01"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("6b50ce14-2eba-117c-707a-49f813acc64a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("6b9dba3b-c8af-c922-2a5c-e19ac77e176a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("6c2e3d1e-f201-a87b-051b-ef3bdceb60fa"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("6c3790bd-b529-83fa-58a2-4ec74d4e4c03"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("6c71f18a-51e3-51d2-da4b-a3fb87b7958d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("6cd900b1-29fb-e06b-cb97-4ad20b6e541b"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("6ce6bca9-0d68-8264-3d36-ff35aa5864e9"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("6cec6956-fba4-07fc-6e7d-5b438af25000"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("6d077ddb-68c7-f822-6a77-dfbf99d85a9a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("6d47b20f-3525-94f6-674f-7076c4b1e27d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("6d6d6bde-8098-661b-1d6b-fbfa81dcdb76"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("6dcf6abb-233b-2cbd-edf1-8f3a735ba370"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("6dec2a40-f142-c5fe-d921-4c10b2e351e7"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("6df9a0da-8129-2bf0-7e2d-9dd3f488a97f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("6e5cbc1b-faa2-0e16-8b5c-70450beab9a4"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("6ecb21f6-287d-ee19-6380-2b3bab92bd97"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("6ecb435a-c559-22a3-d5d2-564f35920ac3"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("6ed99472-738f-6f05-3814-4a409a933785"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("6ef498ad-4a1b-a418-b83b-372005f4b39f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("6f6350a3-1f6f-d55f-6a65-df97de21b587"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("6fccf737-342c-4f36-077d-b97198b86ffd"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("701931a6-b26a-1e2e-a5de-ad550c369d86"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("7070f030-c528-65ec-eb2b-5ac3291cba87"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("70b6b192-bcbb-eae4-d635-919e894336fd"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("70e323ee-1eaa-c824-d78f-1e67dc1676fd"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("70e71989-2972-80d0-5e80-a26952f145ce"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("70fb285a-0a02-5deb-30f4-9d414db376c6"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("71693a9b-8ef2-e564-abbf-d376ac0858be"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("719c5ca8-a413-8cbe-32e0-b75742cf7653"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("71ee2984-2153-c237-19b8-148a59869efd"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("721ec482-f6ff-601a-a5d7-9dff5c5f21d1"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("737b03e1-1f7f-4e04-f554-b5219332a852"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("739794f5-6245-c8db-f724-b432b27be3f0"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("73a45bf3-bab8-c9c2-5b2b-6f6836f6b51a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("73a64638-f59b-1376-72f6-52075bf8c14a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("740ecebc-0435-3875-c7cc-1d4eb6ce9c78"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("74511b4c-eb7b-0a50-3192-df823f660b3a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("749dcf66-b26b-e69f-5f79-f48340e1ded0"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("74e45480-3918-5990-6c66-68b3f2cedf9d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("751f529d-0483-954e-3358-8b9fbbe80399"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("7667c8f3-0513-e74e-19c2-88b36806e745"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("76a0ac00-ae93-d419-d0a7-3e94ba0f957a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("77038cd9-da2c-61e4-13ef-44f57780c1af"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("77132cec-c669-c20e-80e1-59947e80c6d3"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("77353466-4cc0-8279-a686-2a9762dadb49"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("7744f3b6-821c-a593-a995-25c4010408a5"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("7750f634-9492-624d-f0ef-263f5b6965f8"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("7751a381-a7f8-3f10-ab7a-915b8754c265"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("783fd678-ab5b-0c78-741f-a9b65806a2dd"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("78d0467f-c455-8e5e-9619-1da24e0acddc"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("7969b10c-96c5-4d01-cbaa-6a647db2abfe"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("79779255-0217-1def-c163-eaa3d8020ea4"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("79b98e33-7420-f06a-7239-17a408d4e1f4"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("79ba348b-192d-4659-9edb-72a5a57457a3"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("79c70010-b750-1dfd-ff69-ee64589f99e8"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("7a57bce5-0abb-14d0-7670-10cbf86889a4"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("7a62990a-557a-854e-ad06-e0848049cd08"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("7a81be91-8869-0679-ec7c-3929db703c29"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("7abed367-e192-d41b-47af-0bf90a7e9329"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("7aec075a-9056-817f-011e-af8e44fa8d37"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("7bf4a24d-a16e-e705-737b-a6f715d8086e"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("7c715c5f-e246-6fd5-01a6-9c9495f0b588"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("7c8df571-fa0e-754c-409b-f682582b4632"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("7d5fbc42-acc2-323e-ebec-2436dd267ff2"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("7d6edd8a-27ba-de4a-bcf9-61fe4ba73e48"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("7d8e57d9-2641-0ab6-974c-ed94423638f3"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("7dc84b4d-194b-f8ea-6fb2-cdbb9661b927"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("7de1f484-d1a0-110f-e4cc-f9b004b02ed7"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("7e204c10-6961-ef1f-89fe-55163adcdc38"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("7e40792a-f9ea-c3c2-4b20-e0fb5712fac8"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("7ed86292-50e7-cbe9-3c6a-307f15b01508"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("7ee67557-5f9c-493f-b733-00302ad4f8df"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("7fb1fee0-fdc9-fb8e-7930-39e2fcec5dce"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("7fc3668b-4c4c-eebd-81fe-e477baffb4e4"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("7fd73726-4be2-acae-8fb3-aaf1aefbe166"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("8078afa6-e250-4460-d12d-685d78c01965"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("80e71255-dfa1-35f8-2ef3-a5987796c184"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("81112740-0d3b-0fa6-b48c-7c69f2715c9a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("8154b6fb-c2de-104e-a841-a0cd2f323ca7"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("816fede8-49b2-29d3-f3c4-75e07d28e3bd"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("81b20841-30b5-8c97-db58-669a196fab20"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("82134279-cc02-e698-b80b-8764963d2af3"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("8215da26-1fd3-34ac-04f1-8afed3b9a297"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("82b1324e-d296-3608-28d8-8e2c22e03d49"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("82b8c03a-c98e-2e68-dc97-efe9968fc721"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("82cc35ae-11c6-1457-e813-1cc28184248b"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("82e7a79a-e740-3f9f-5564-1df5f69a0943"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("82e811be-b0c2-4c1d-7525-3501849e6720"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("8352a451-c2c0-17d3-1ac8-12140a9eb21c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("835c4db8-9da0-1dad-954f-eb497a8d9563"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("83a44ef9-6be8-c0f8-bb3b-0f09c95a3f60"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("83d3b504-23b3-4e7e-0c0a-d17bfa5e99c6"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("845f8ed2-2e54-7082-553c-64d12acd529a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("846fc437-9ef1-59d4-1083-1d9422fec194"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("84bc14d9-cf8c-59e6-d30c-748aeec20a79"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("8541d29e-b123-3bb8-72b4-da9db91ff248"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("85787e47-5375-a481-214b-64ef18b66884"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("859791ec-18c9-3b51-455a-f6e7e0de7366"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("85b2c482-3697-a8fb-366e-6c66bfaa3645"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("8622133f-230d-07a3-9677-3052b8ca2692"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("868f1bde-4776-0618-f6f7-9bad06a41015"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("86c82461-fd0a-99ec-e2eb-6ac822c9726e"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("8735a91f-77c5-8bc8-a80c-40c62bf74b10"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("875ca2a1-9233-e6f9-6b51-c96c840d9ccc"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("8767610c-5c68-9372-ec62-4583edd1e1f8"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("87743ae9-78b6-a274-df11-a924684f9acb"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("87951618-5ccc-bf6a-a977-a5488a805bff"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("87d6fe7a-c79c-4bf0-dc37-9fad9e66bca6"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("87e5b503-e303-471e-a614-9d8b587a36b2"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("88c8a218-7ac9-5063-859e-0d884212ea61"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("8945b4ef-b7bf-7161-d66a-470bff09e80d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("8964d2e4-795d-7a5b-fb4c-4c693c9d5697"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("89daba21-3297-056f-af9e-4485b712ea4f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("8a238b46-a90a-6568-7e6e-71172e373c08"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("8a34972e-2985-b5a5-da29-5acc4cdc97c8"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("8a97af3b-4b03-b8e1-4940-24979518a5a5"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("8ad7ed19-bc83-245c-9ab8-de9549588c9d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("8ae17024-49a5-1a24-0dd6-e4ba70c3f5ee"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("8ba252e1-a0c9-af10-a4e8-699b2200da24"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("8bb13476-6fb2-c8f3-cd84-ad79473c68f7"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("8bd9ea1b-e393-e5b5-ab78-3cfe72bc5dfa"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("8bdf6e83-fc2a-9520-6753-c53978ed1a86"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("8c263c63-da2c-7457-f30e-6cfad636cac3"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("8ca8b3b2-6c8c-c405-2ca4-5dab0f09d69b"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("8d105d34-e730-d2d4-0c49-7b0ce214aa4c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("8d2e3d0e-2f4a-4e2a-295e-3c6257794f78"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("8d355578-c443-c27a-4888-27da91ee6d2b"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("8d4f33bc-d146-ae4e-6a63-f14a4fa4a491"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("8d79cbb0-71d1-7bf6-e0f2-3bbef02c4f63"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("8db30915-81ca-3301-3511-588882f3f60f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("8dc4ffcf-051e-64a8-8fd4-cccdcf0c30d4"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("8de33e75-be6a-c416-1099-b5f788209951"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("8e3abc13-be73-e186-dbf0-2d39e8fa5514"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("8e535efc-dcf3-1bba-407e-ec0322e5fb3f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("8e9956c3-e006-59d7-d9fc-e1d9c18744a8"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("8ee29a27-87a3-bc15-d7ae-6ffee6f18dd8"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("8f42cf41-9577-d457-1e55-76c039d10867"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("8f9e9e1c-9607-0f6b-107c-213b9010a130"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("8fe89587-e6d8-71ed-14bb-ab3bf0cfbff5"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("90065049-d406-db5e-47e9-898e13d8678d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("90d0611f-97c7-347a-0bde-20d8b529560e"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("90ec991a-c48a-7d8a-cdca-315a096cb77e"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("917ce8c4-2bd9-a4e1-dd8b-6288e69e90ea"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("9185acf1-0e10-9731-b31f-8c62b90f68cd"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("91a375d6-6236-34ab-ca17-e7447b077588"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("91b2cb8b-310a-24f8-bdb1-4f4bb5aea418"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("91f38fa6-b2d4-e273-ea51-aa8b58549b1a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("920e88a9-8000-6a87-a8cf-976f3b3131ec"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("9225dd17-d947-74a7-dced-23c86728aa6b"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("92ac0723-eb26-74d1-a3cc-2324a2d30843"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("92b4440d-abb2-3ffe-626e-0338e5880ea3"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("93f4e90d-55d1-99bd-ed19-bb92095e9d2b"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("944b1537-eff1-b7e8-5d93-10d70b477194"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("945c381a-e5fe-d33c-13c7-bf4fbdc2562a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("946337e9-c879-b1b9-d397-0eec46d8d238"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("94cf5ae0-0190-b102-45ec-2bdbc7c2d2c8"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("95e71f00-c449-67af-427c-e70b45ab9ec1"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("9631f3fb-8203-701f-f084-c38175ec4306"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("965785e4-6da1-f2aa-5047-301cb086f912"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("96a43c82-f459-fcad-bdd7-baea0f09b3ec"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("970f2862-4ead-779b-2c7a-85ef40674670"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("97751adb-12f4-b3a6-0f45-0ac1e0589782"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("97de49e7-fe9e-cae7-d4aa-71ced959f7f2"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("97f28248-45ba-25ff-6a0b-1a9855aa0a8c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("97f4d58b-e375-f8ea-fb9e-52d86ead602d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("97f82900-874e-fd7b-b38f-881404a6c7e3"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("98734065-0a6e-5b7d-a569-3f22695f4e7f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("9878dbf8-2f9b-4743-7bfb-efd29da02292"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("98803569-aad6-1386-0e36-c827c95d21cd"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("988c3e91-e54a-1cb4-bf91-8fc05e309206"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("98bb1f94-6fe4-b3cd-8e63-f55ff4ac60e3"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("98f3c2d4-0c5a-2029-41a7-f98f419eaae7"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("9943d578-81c1-29d3-5221-d5d0d0cc8710"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("994f6b23-968b-59bf-fef2-8c222ca83597"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("9994174e-c11f-1bc1-de9f-72460d94ccaa"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("99aeea9e-6b2e-f9bc-ec82-835311c3cd13"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("99df2e51-d0ff-85f2-07dd-f4d69cca1ce1"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("99e2ecb5-1b40-f8f4-053c-b4ce04947481"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("9a3ffb29-2eb5-a754-e552-53c699b3744b"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("9ace82d0-9df2-7ea8-53c4-ed9286bf169e"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("9b07a9b9-acae-1740-7977-3ba2a6fb2df0"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("9b10f398-0747-a522-30be-6e1cdd6287b3"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("9b1d0431-8f62-25c7-230a-856ddb0814cd"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("9bbdb29c-d757-5823-36b7-352cbbdc8412"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("9bce9681-8454-acc2-35ed-fd4a98542570"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("9c27ed1c-222b-1e6c-318d-088088bfc4ad"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("9c9c38de-4a7a-e079-1fd1-f4cf55815c0a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("9ca86d2e-e687-53cb-33d5-3530aeebf41f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("9ca87510-1ff8-fef7-435f-37f118200663"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("9cab906d-43eb-5bb2-f7af-209969f4d91a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("9cbe9730-5fc3-b5cc-9a24-b2c5a07723d3"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("9d7ba346-61f5-f502-746c-935901a8930b"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("9e478f28-476f-b3e1-7f6d-11414c6d2141"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("9e671a8b-7837-9e7f-c5b3-26c26b8ffb25"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("9e7aa956-50c8-f44c-2fe9-3c1d6dbe8b16"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("9ee17f0a-b77d-ca8e-3b3f-7fb323f308c6"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("9f9847ce-892c-762b-9704-48e91fc829d0"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("a0ad1d98-dc51-620a-cc58-5d96de57f75a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("a0c80924-a337-0ec2-0dd3-1be133be8d89"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("a0ed32c8-6f70-eafb-7484-79568e6c2e5d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("a10b00a9-e0f0-31bf-2886-c4226ac1c1b5"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("a13a18b0-a5fb-b8c2-1511-3e5a688d0199"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("a1418834-2f4e-b10a-ea89-d142912f4f62"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("a191afbc-72ff-bde8-4761-2466a2176719"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("a19480f3-bdba-6247-2b0b-ef6b5c1bb178"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("a1d216e5-1704-c704-72d6-ad46f882690c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("a1d45f1b-84be-7839-f874-10117f33ff95"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("a1de40e2-792f-bc64-feaf-b7ba8f5319e6"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("a27798ca-97c1-3df2-71d2-a10654649969"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("a299b992-feff-499b-9377-49e6b4897e26"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("a29c2eac-c65c-b369-5636-546f9d5795ff"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("a2b667c4-73e2-5b39-94c5-b562b3e31b31"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("a2ff4933-6723-e913-c6eb-f820edd58e38"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("a30c9e46-1078-8a21-855c-0d9582db9783"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("a3ab7e5f-f674-0421-a391-227f54e619ee"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("a3b6581c-1fca-ad37-6d81-af8e13d0a7c8"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("a3c605d8-285a-2839-f5d6-8e8adc8403ac"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("a3c9cb02-52b7-9063-52c3-260bbaad557e"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("a426ed49-95c3-f939-8a74-5ae69eb59c54"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("a51c6fe4-c0a4-14f9-a136-fee2f6ef3ca8"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("a5a925d4-011c-2793-0a32-d2c8e568af03"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("a5b7aadf-6b08-00f7-4ed5-e736d4116c55"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("a5bf6eae-7283-a2e7-cfef-41471f9d9721"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("a5dfbedb-ebfc-806f-2756-1556fd3d8750"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("a5f3829a-3d87-e29f-0b80-027e64541803"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("a619eec6-31be-d9d6-377c-c01b1a861467"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("a62c64ca-5519-7364-192a-83994268840d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("a6ae9353-f7aa-823d-7fcd-b853f94d23bf"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("a72c074d-b9d5-15fb-53a8-5fc3573cfc97"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("a739e9b1-9a5b-a8a3-32ad-699038ff62b8"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("a75e50f6-5b55-c7f8-5f4a-6a5ad1b9c09b"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("a7a684ac-f08b-1135-8060-1b2f7934ec95"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("a7ae254b-75da-edd3-88df-6195e4acbcf9"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("a7d78dc5-bb1c-1623-7b3f-0d7aff596253"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("a8309fe0-6024-c4ce-776f-1f844570fb29"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("a8311f94-c620-1470-d8bd-4e1c4c050f1a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("a862cd30-f1d2-47de-3f81-cbc16d8e97fb"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("a8c28b09-7466-57a3-5ca4-c92ce99e08d5"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("a979582b-3c05-8177-644e-dcb28638f736"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("a9bbe6a8-a493-1b47-4767-c99085c4e1af"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("a9ca86c7-5578-ee6b-9ad9-af685dbe0b02"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("aacad52a-ddbe-9fd6-205f-3b05890ad968"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("ab7ba48e-25a2-215e-3b50-89a292515c87"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("abeef740-76fe-f0ed-1d45-050353f6a02d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("abfc612a-9c5a-f6de-b5a1-5cab14b438eb"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("ac2de8b4-af40-89b7-426e-90473b859c09"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("ac5b76ef-3c12-7163-3c93-a2787842e5a8"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("ac658946-ee43-88fc-0304-a7165512fe1f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("ac8ae869-920a-079e-7e25-6baba6b51589"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("acec305e-686f-4f25-4b1b-9f5c4ea322a0"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("ad63b217-fea5-63dd-37e4-3f995f281798"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("ad7377e6-47c0-9973-7daa-f616aee797e2"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("ade81c7c-c195-565d-2b2f-a4b368e712f0"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("adf36958-a481-a298-fcbc-c9f0cfc1e44d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("ae2cf3c0-6fe3-d8a1-8fef-a9d1351e6e69"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("ae98b165-0ccb-9c86-38a7-4628d60c54cd"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("aeaa874a-9714-3318-3cf8-e7a34a0ae5a6"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("aeea8c89-6195-2144-6152-1f08f40b8b46"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("aef2e121-657f-e32a-281b-3cf3291f9f8b"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("af339f89-5105-89af-1162-5798d3f76131"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("b009476b-2591-22bf-467d-09f3276d34cf"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("b03a546e-137b-be99-481f-dbcbcb44ebf6"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("b07028aa-a08b-0540-280f-b94172addd23"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("b0ba1630-7529-943a-4984-a9cd644567b3"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("b1344ea1-7bdb-1ef0-3a1a-e149e7374b55"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("b151047b-b1e6-10a0-9ae1-f96a922f996c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("b19389e4-3c2c-e378-e6a9-6fcb9e84b601"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("b1aa2cb7-e3df-f76e-7018-9fcd68def546"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("b1d31a27-d040-28fd-a004-3ab8b822d3e0"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("b27858d4-23e5-91eb-6a62-19da4682c420"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("b27bfe3f-5adc-ac21-65ab-a96cc99f07a8"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("b28f63a9-da82-8f10-c66b-a0d43bc17077"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("b3f23e12-9cfc-8423-eb65-1e839d2b71b4"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("b4377d80-22f8-621a-2c61-856c62c429c4"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("b462b556-2fc9-bc12-883e-f5bce5f82e62"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("b4ce13d9-9e1e-3321-05e2-228b191f43cf"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("b4db8d42-2358-2eb7-32c5-1a930ce7e070"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("b4e08800-ab49-8f3a-bcb0-64f2eee934b9"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("b501d1a1-5b02-5a44-e1be-e17402258115"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("b504c0a2-a0fb-5d5d-e0e5-8683d9b6ed6e"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("b534ad12-45a2-8276-079c-bef54d93c6e6"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("b5849829-e791-41f1-04a9-85dbfd79777c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("b5d0877a-d40a-86b3-f669-af3bc3dd290d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("b5ebe789-9e16-aabe-59fe-63346c7f7a76"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("b5fb7950-e2e3-df8b-4421-bfdce6f0a4d9"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("b601d6aa-8bc8-897a-9f9b-055d99d8f04e"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("b60bc345-5908-1ffb-4dcd-84743e0dfbed"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("b6a1a4f3-1c93-36a8-1d22-1d11afc29408"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("b78b5a68-456f-ad26-c4a3-b18467188525"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("b7da6d10-a390-41f2-5f59-4b002c020060"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("b7f1faa8-a1d5-b6ed-7fc1-f5de1db2fc17"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("b84f7da9-f70b-46e0-7a61-ece995bec5bb"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("b8a6b5cb-97b6-5571-d6f3-f3f252be1513"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("b8ca8d97-e8c3-9828-536f-77ae488dd451"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("b90200dc-41b7-7c3d-c492-57bd0e1efefe"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("b941913f-7fe1-f8a6-f31d-e7c065475ef8"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("b95cd647-d2b2-ad65-cf40-efc148e41269"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("b9cdbf1e-8ae6-3f7d-c7a8-d33521a13e4c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("ba0b1bd3-4efa-6017-0189-55d7e06b703e"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("ba236be1-e7d5-98b2-daaf-7d59552ca2e0"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("ba2836a8-f414-313d-411f-3d12b5e58ee9"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("ba9eec63-23f3-7663-f9f9-12464cbf24a3"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("bac80c9b-4962-5554-966e-d3e9fc7a11e2"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("bb66e27d-82cd-4837-d599-2b6939002d93"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("bc4e36dd-1163-3b11-4227-07669f802e5f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("bcb2f805-12e8-320d-ca36-7a4122fbc15a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("bcd5fbd8-0cdd-2da3-8b67-ac8538004a4c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("bd0370a4-dcba-0778-1149-4cc340bb9758"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("bd26bdb2-29ee-3a38-a510-16fbfebf5948"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("bd3e6c7b-6738-05c7-931a-e546aaf71f13"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("bdc1e6b3-7355-14b1-1976-5f4b2e765f8f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("bdcacb3a-04a2-4ae8-8f58-88fcd7fa4886"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("bdd1af5b-fc3d-7a0d-de41-d69d9f5a2f0d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("be2b765b-7301-0290-a2a2-f7e40fc7c0a9"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("be74f5aa-fe8a-17f9-b347-d17a016723fb"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("be8c4c83-f350-7184-da88-782cbd83b5b7"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("bed10572-0291-3d15-1504-623c9fed2d62"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("bed35d93-495c-08a0-c401-64cb7b03a693"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("bf056dad-0e49-fa1d-be2e-47c26caa0cd8"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("bf249b59-cdea-ac34-32ce-9ff01eba47ca"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("bf8b8cfc-a2e7-ff7e-97a5-972f7c250dc2"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("bfbe0b46-9f64-1e40-3e3c-1bf0c841f948"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("bfd79268-f647-1387-6ca7-37c5c7fe28d2"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("bff2e876-a6c5-2354-1b2e-f4ec74105200"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("c004b9d2-bce6-1b3c-b7de-1fbe20f98642"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("c00d5dc6-8e9a-1f25-74d4-e090980fe7ec"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("c0641507-7edd-9eb6-90db-6b3dceb254d6"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("c099f5a3-104c-c8fd-51da-1d2add17762d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("c0d4aff5-4641-e05f-5c8e-47dce0ae8eba"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("c0e4740c-f33e-061c-8fbf-fad5e20ce062"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("c1c7182c-1ddc-e449-3e54-f01103742276"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("c2001e99-09b6-406f-a5a6-22b2dd3e4025"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("c235bd6f-b60c-f7e4-5cd0-e0091f8c22b2"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("c26237d5-3b92-d373-6129-07aafcc18c52"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("c265a267-a32b-f40b-825a-195451275bcd"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("c2bbdc15-0749-16d4-a6f4-f5128a28686d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("c2e0719f-3182-2118-1f51-4ade6462e182"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("c3053d0d-cc46-3fee-87be-7e934f0fa5b7"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("c305cbd0-b68c-eb7e-953a-9ab81e6485aa"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("c330e07e-72b2-ecc3-49c3-f6f90c5cb7bb"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("c38e1c3e-c8e6-4db3-760b-f5af0a209425"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("c3936005-1d50-644b-7989-acb459cfabb4"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("c3a3bfbb-2002-a374-729f-cf51791c1fd0"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("c425715f-d7db-9b29-cd6a-4300464c6d6f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("c447a3f4-6290-dd41-1d44-ea6de4c8673c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("c471498c-bcb0-d3e8-4454-862cea6604ff"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("c4d76343-92c8-f39e-aa4c-ef1c34a9b6a9"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("c4ed17f6-275c-28f5-6fe5-5ed79bc9e7e9"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("c5912c59-9585-6b7b-14b0-073129205cb6"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("c5d40d34-a31b-97ca-88ac-3baa5e194f58"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("c5e134e7-1240-49da-4dcd-aadf1648d03d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("c618243d-a7b1-d27c-490e-ded21d97774e"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("c6398cc9-66c2-6687-7cdc-e6f2158c0d2d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("c6a302a4-f174-89d2-c915-7c6a61e6edc6"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("c6da7adc-1b40-f86c-03c2-74afa0d94d56"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("c72b13b1-5b4c-1b1d-4a02-4c11cb47bb58"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("c851ac51-e143-8e71-9974-e2e8e3b0a4e1"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("c8674f48-40df-7a54-3666-24ff253b9348"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("c86f0c05-0a16-ad41-2391-c4c2842ef3f3"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("c8b3d192-adb5-8059-48da-e477b2f519c1"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("c95d7f28-91d1-90b1-f157-e8f1aa772c15"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("c96ad0db-3b66-0bdf-4d02-e7a017784965"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("c978bb2c-a84d-3ad6-cf32-1596a58b6a58"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("c9a3c2a4-e684-5289-8808-0da9b54f662c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("c9bce1d7-7e0b-582f-251c-e522a45134ba"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("c9e5966e-ca9a-8abc-055d-53b758bff69e"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("ca315d75-4b8d-c26f-cc4e-ee0c10f0c582"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("ca5a0868-a5ac-6a4d-70db-458d6ab57e29"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("ca801a7c-6764-7179-68a4-495a083acbfd"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("cab21111-fae8-4e5a-46de-bb1ff7fa3de7"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("cac23cda-aefc-0281-5645-ff0a0c179dfb"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("cad1d3f8-5268-d10e-9124-59505c8e35e1"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("cb17e2f1-46d6-093d-c750-247e79e840f2"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("cb1f16a3-db3a-2cc3-9e82-72941d1f685c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("cb507f40-0d30-5573-cadc-eba9923614aa"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("cb660c88-d30d-0628-eb25-6ac2e56cf30b"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("cb9af17e-16a8-6d48-e687-3536405d63e7"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("cb9b7741-e4a1-1c8f-dcc1-b7e6ec99a6af"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("cbb0d5c6-5ea8-5599-8ff9-4afe2b04d276"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("cbde7514-9017-bf0c-d778-9ca6af404f7d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("cc2f5cd0-2755-4448-8738-2e901924772c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("cc9805b9-0316-7cb7-aae7-b9cee0c3c94a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("cca61cc6-b110-ef10-bd12-610c34403818"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("cd057aa1-4bf9-1f58-4173-1471a57914d5"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("cd36ab9c-0845-25c9-f335-2294e9d627c0"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("cd632fa2-1929-418a-162b-27957b68c65c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("cd694a32-3182-44d5-a47b-9962afd2cc0f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("cde26bd1-d0b8-a32c-9118-c0af3f430c19"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("ce238385-ad03-c04c-669b-74839be5ad73"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("ce2a3a4f-493b-f4e6-1bc8-53d54d304104"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("ce305890-e143-474c-9b29-feb99fd4620c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("cede73a7-7f9a-611a-b60e-5715bc8f4c5f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("cef339bf-ccfd-edef-bfee-ab170117eca2"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("cf213fc0-3ebc-d704-1754-35484a7079ab"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("cf6cffad-3604-070a-df3f-32a9de001a9b"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("cfefed0a-d235-5d53-1e3c-404d403e54d6"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("d06ad412-eea8-bd03-d880-247b1308a01c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("d0dee0d3-8dc7-ec9b-442e-486ca49b9557"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("d16d3e0c-ac97-5b11-4b2f-12cc5414b8d4"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("d18b69a9-8477-4f97-7360-1ce21022e4e9"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("d1c60a42-511d-083d-a3dc-3c27018ae98a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("d1e73f81-5136-213d-f67e-b7e1960b9dcf"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("d1fc4ea6-4bec-034c-8b18-9ae1226115de"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("d207b8d0-2297-b501-b7eb-c93e143d1c3c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("d2153473-238f-b8f1-554e-9623307ee4df"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("d23a7c48-16d9-c1a6-3954-93ed5e18fbcf"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("d242c73a-de1e-226a-9872-c3ae087b1327"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("d263959d-61f4-ebfb-73d5-1a65e78e6e93"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("d2d80b5a-7989-0fc7-a442-4533a45cdbc1"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("d2da744b-b266-24a4-913f-ed047640031a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("d2fe2fa1-666b-fc61-8772-d005438377d8"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("d30e6da5-5972-c677-3c26-905ae7157d96"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("d322f008-3ff8-5b65-76c2-3f81fe5476d1"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("d345d640-c29c-8dd3-8f11-9df515e08827"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("d354832e-5fbd-7947-e303-6a1f2a4980b9"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("d3cfb233-47e3-1188-0071-3be17029370c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("d43cd1bb-fcbd-0e68-db55-4c84937063ed"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("d46e432c-5602-e0c8-4dff-1fdbd9091bd2"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("d492dc80-adb1-5227-0196-93306c9f5baf"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("d51622d9-712e-4f70-aff7-5a3ece1d9ff8"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("d59fe568-c590-175a-d732-12a50b343b85"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("d5a6bbb0-b5a6-883d-51d6-e72936199698"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("d6d3a348-5d9e-78c9-49b5-a27ec993cda9"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("d79e8c8c-3c26-9f97-78e6-33a1846bd0b3"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("d7ff157b-5ceb-a344-4817-3f86452dc95d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("d8749f70-8b7a-4a77-31f1-254976341551"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("d8850e4d-d0da-e540-6123-8dd0e9d5f798"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("d88adca0-4380-545a-742d-8c4edaacf6e9"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("d9720dbc-8f98-a299-26e8-1dd0a19de3ee"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("da19196a-a8ed-e6fe-962a-da26286497d8"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("da41930a-c6fa-cd86-1de1-0f6da1c5ad2a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("da4bb2f8-665d-81b9-e992-8c4eaab43853"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("dac050af-8d7a-aac5-481d-6fda1c7b95d5"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("db0c9da8-826a-e234-b776-e792eafbe38f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("db0f4930-43e3-3f7f-8ba2-28c7bc6fa3ae"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("db18189b-6120-36c1-97f4-3e92990d7bfb"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("db1e4c35-1666-2be8-f98f-4e13cbcbbb78"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("db3778ef-f152-b04d-d531-0df0d9842249"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("dbe58f2e-2d58-ee20-6743-8360bd4350be"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("dc068319-a0a3-7e5d-fba6-aa239b4d3e01"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("dc30baed-bec1-02d3-db5c-7e02228e40af"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("dc3cd85a-3366-1809-2184-bb33bd529bed"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("dc4d700f-bb75-bdfb-dfca-882440d30039"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("dcb7dd91-7d90-d63c-ddac-909bef5896cc"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("dcc25a05-2c09-6f03-740b-1f61c2c435ef"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("dd50345c-3ef6-7865-3836-b0a8c8865c88"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("dd5df1a7-90bb-73e4-7932-adcae5dd9b15"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("dd5eef92-3d15-d7a9-ca73-611d8dad873b"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("ddb024c0-dcba-18d3-bf8e-1f938f1dc014"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("ddd31981-3e79-b1b5-3311-64c3e15d818f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("de4abf0c-827d-2938-fe85-37e87dbcff0b"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("de6c3ddf-d45b-7031-5b98-a11329ce7203"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("defdb9a5-7b20-4f09-81ba-76d773be4253"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("df892a69-2421-d8d3-f716-d1e750d593bb"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("dfb31950-49dd-46bb-d78c-0e07f8b495de"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("dfc85ce6-f3f2-e378-738e-fd8ab7484526"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("dfcfb420-419e-b31d-5402-92cd5ee31fbc"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("e02e2a02-fa6a-ad9f-597e-da2eaca7ef0f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("e0b50464-929c-b03b-fb96-91dec36316f7"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("e0d4517f-2f03-2e5b-b9df-f63b0fcea9a6"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("e109c02e-f4b1-bd20-a0b1-efac458261bf"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("e12e0c1a-086b-4a04-32e3-6728678e2275"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("e1f8bd49-8784-9122-3b93-53d127e8785c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("e26adc19-c6d4-3336-325d-6708a211f765"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("e2bf59ed-bbfe-e740-6928-48eaeef3da4c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("e2fc6ba2-2b7b-421b-05cd-42b24eeb204c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("e3252268-f2eb-da32-a558-25d6c47df31a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("e3c1b08d-23d5-f54c-db70-12ada72b49fc"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("e3f239f6-4dff-8a2c-023f-1a1ee895a341"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("e43766b2-e1dc-3a3e-3e30-fd1713ca6ffb"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("e46095f7-f6ef-4292-f088-080b53b52901"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("e51d6251-b0e5-6f14-08ec-880be615e8c2"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("e52f21cf-c420-b01c-1715-cb4ff2af1b3a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("e5402402-ed75-3b4a-3e18-368f41907eb1"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("e5702034-9d2f-5693-1b72-f9fa479f7da9"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("e5c9e5ed-0d5d-6ddc-9645-688c637350c2"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("e5d4d9d0-54b5-a393-6010-7c4d2314865c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("e6bb1bc5-0a66-a2e4-dfaa-947d013f5441"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("e72fb755-4538-710a-557a-5a0cdb6184a3"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("e770799f-0058-bb09-28fb-0df3878b67ae"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("e7ac7d68-fb3b-70fb-2b26-864a3012594c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("e7dbc2e4-1274-f0c6-509c-653d1d986039"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("e8d4f4ae-73b6-3751-2262-f19e1a1a8593"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("e8f84772-842f-fd0a-2d9b-7ed036b0ad5b"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("e904e41a-ef4a-317d-586d-c2598898f82e"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("e9449898-f20e-0b6e-ee19-bdec89eba7a4"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("e9fd4dc2-aa86-357d-8611-4259296ff5b1"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("ea3e10b3-82bd-7a48-181a-2fa42bd01363"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("ea6007b2-40e7-52b9-6b0c-61ec65dae4a3"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("eb1fd1ae-60ff-6719-be4f-a98347412165"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("eb7108d2-abcc-21c4-243d-e2f75053983f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("ebb5967a-ede7-2520-1f61-f1e12b149a2a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("ebb64bda-19bd-3844-56d5-5cf14ceca808"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("ebf99995-205a-fc5e-2d20-de1599cc1e43"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("ec8b5b03-63cf-e257-0e47-093b5d5fc6e3"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("ed0f04cd-0631-0ea4-e4fa-cc200491853c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("ed3b368e-0fb6-2207-108e-2621f548a5f2"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("ed7ef41f-c404-1a62-4efe-f6092eb4d82c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("edc0bd60-23b7-f4c3-9c8e-d7ebac84fae3"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("edcfe58f-798a-4734-da89-b6b006769fb2"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("ee1c08c7-9966-703c-25ff-934f5dd61355"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("eea582b8-83a3-cdb4-d7ad-075fc2468c75"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("eea5d86d-b541-d42b-a440-0100ba104bea"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("eee6dd21-99d3-76f7-7e8f-ae982516330c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("ef239e5e-faa6-fc81-e6aa-b538583dab61"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("efd3fcae-daed-bc8b-7331-fee98a8cc3f8"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("f01bbda1-df39-0821-f233-d9e0a1925f42"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("f065f0ef-e350-9525-a472-45977f25ba80"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("f1460f86-445c-d169-e34a-071d378d2797"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("f1e9d54c-2379-e8eb-1a61-014413b90760"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("f213395a-c451-9059-74dc-1374d2836e03"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("f2641f68-9824-7c7e-f859-11ec16274cc1"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("f2f8b88e-f5f8-97fa-17a6-ac0642d72603"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("f33f599e-636a-8045-9bad-47673e0af475"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("f3ed7d97-8136-28a7-1e3f-77c462f68598"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("f3f581f8-a1a5-55e4-d6d2-3fe3e7e752cf"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("f4466c8b-dc95-e958-25c7-a97f3de290ed"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("f4991b3f-2c33-5a18-c14e-fc8f1a047998"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("f4b0bbe3-1b29-681b-0d5b-068117caecd0"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("f50a1a8d-c9dd-6906-5e09-a19f7be0d082"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("f515cae6-56e2-8928-05c5-6fc4f5122cd8"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("f52a4469-5a5f-a1bb-9fa8-67bb3345dc77"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("f5372abd-d494-6967-d43f-299dbc4de419"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("f537a53b-fe30-fc7d-ae87-943affe8436e"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("f5eecc0e-6f41-939f-accd-b2b472f59da0"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("f5ff9472-9746-1383-e10c-b932ecdbd6e2"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("f62231bf-f2d8-7cfb-28a7-d2c575cbc096"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("f631f9fb-e6a0-276d-4998-8824ca4d982f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("f655b7ec-690f-1b39-534b-d1967c9682ed"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("f655d820-cbe1-e189-6452-505cf87dd04b"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("f6852580-7124-192e-e673-ea389f05fc85"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("f6bc206e-ac09-6f63-694c-e11eb2d8f8bf"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("f7664ee3-d5b0-b8b8-4fdd-c6577eb7ebc0"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("f784c6d4-aae8-a8df-591f-d3f500c6302b"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("f81c3d53-b04d-e651-dbaf-356c6a95d1b1"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("f8302a1e-9ef3-3a73-3977-86aa4f110011"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("f83d5074-4537-327d-9f6e-01c002b1eb81"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("f86820c9-2edc-8e2c-a17f-d8565f233268"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("f8b75982-752c-895e-9136-6c80fbd32dbc"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("f8bea56b-c9c3-4402-65b1-cf64688c7ace"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("f8c3c70e-0446-415c-f7d7-43a0be93df31"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("f916888c-c839-2a44-3353-514cc899c111"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("f9556c98-f288-6cf8-cdc3-5b750b459fb1"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("f95b9ac3-983a-bb35-9f3e-b6671dc689e9"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("f9836672-49a1-e7ae-4429-3d92b3d04c13"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("f9dab641-34d0-b9b1-8a31-3dfcc61b24b8"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("f9ef8fc7-06b7-610e-88e9-d547b496c638"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("fa02de5e-96bd-c923-bb5c-9e4fbc327c46"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("fa55db47-6e7d-fafa-ad1c-363cf82cec53"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("fa5b49da-f1ea-e111-5970-087a9b8731fa"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("fa68699d-9312-795a-b683-5e0e472863cc"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("fa6c7371-f66a-ecf0-183f-8cb4b873a553"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("fa9db847-3771-fc0a-53a6-1c7d451eef0b"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("fab5afd3-c42e-7cf1-2251-ccbe60cb1e67"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("face88b3-6927-41e8-1605-138efcc5d914"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("faed80db-6268-5d60-1334-9b4a45346913"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("fbbc22a9-b056-7782-aeff-b77927971fb2"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("fbd30918-1adf-3738-ee91-ba0fe03fb366"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("fbeda8d6-d8b6-ea46-5b70-05922dff8887"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("fc4a116c-30d2-ac75-ae09-833762bf9c23"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("fcaeb55b-5702-b7d0-1635-c48b6b269357"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("fcb1ac27-1cfc-aabd-6cf2-c3746276f4d1"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("fcbed392-0073-fb2c-d091-e6326a7f078c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("fcd6fecf-a7c0-022e-fedb-f828099219fe"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("fd309860-4313-5298-fff2-acb9ace42cc6"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("fd43fb65-7cde-6dd5-1acb-2ba244565142"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("fd743312-a004-84d0-1cbe-04c1e10a0327"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("fd81634e-e176-a5bc-a354-b52647287291"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("fe0f999f-09bd-504b-d25d-dc20a2e48b1a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("fe4e2c18-742b-d7d3-a50b-a2e8dd9b6f4c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("fe929d2f-7d31-cd83-3b4c-10b384fc0980"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("febd8b79-2156-3ff0-9f11-b7b75fc498e7"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("fef0b908-2b25-1ba3-7150-4cb61781dbe4"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("ffaa3be1-1a53-3245-e03c-2bc04c729957"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id_client",
                keyValue: new Guid("ffdec6fa-d05d-f617-6bda-6eca481003d6"));
        }
    }
}
