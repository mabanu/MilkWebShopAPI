using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MilkWebShopAPI.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MilkProducts",
                columns: new[] { "Id", "Name", "Storage", "Type" },
                values: new object[,]
                {
                    { new Guid("0037a064-7ce1-4c97-b8a0-51848775a7a9"), "Elliot's recent almond milk", 50, "Almond milk" },
                    { new Guid("0597329f-b2fb-49a9-a5fd-13797fa1d7ce"), "Marion's torpid soy milk", 41, "Soy milk" },
                    { new Guid("06d60157-e9c7-4bd9-b2a6-00fd63bb2033"), "Christa's fearful rice milk", 46, "Rice milk" },
                    { new Guid("0798ae22-c922-4b47-adc5-23feac38020f"), "Tea's scientific rice milk", 15, "Rice milk" },
                    { new Guid("0ac95b83-bdce-497c-b0c3-7c0071419324"), "Christa's wealthy whole milk", 84, "Whole milk" },
                    { new Guid("10aed344-837d-4621-873e-aeac9394c99f"), "Duane's salty soy milk", 24, "Soy milk" },
                    { new Guid("1627d6d8-1a96-4011-8294-49b9f1e90ba8"), "Kentrell's scientific macadamia milk", 1, "Macadamia milk" },
                    { new Guid("179670c3-e49f-4655-ab71-12a90b912cc5"), "Dillion's rough rice milk", 56, "Rice milk" },
                    { new Guid("1bba8dfc-07af-414d-b85d-663443612e5b"), "Catrina's fallacious almond milk", 62, "Almond milk" },
                    { new Guid("1d52f5a1-4c39-4352-85df-168320fb3575"), "Kasey's wide rice milk", 54, "Rice milk" },
                    { new Guid("1dda5869-263d-460c-8275-3b131e17c601"), "Gaven's early cashew milk", 36, "Cashew milk" },
                    { new Guid("1fcb5bbb-0fa4-40d5-92ae-0e751c18d704"), "Lincoln's scared walnut milk", 71, "Walnut milk" },
                    { new Guid("2356a84e-0fbb-4b5b-993c-0bc6c70586e2"), "Quincy's whole soy milk", 10, "Soy milk" },
                    { new Guid("2534898d-223e-49f8-9a4f-2993458fc5f2"), "Kristian's quickest oat milk", 37, "Oat milk" },
                    { new Guid("264a505c-4d88-4a61-966c-471d5233d8d1"), "Korbin's fearful walnut milk", 27, "Walnut milk" },
                    { new Guid("2702fab9-db1c-44bf-a43f-9107cf21e499"), "Joan's full pea milk", 67, "Pea milk" },
                    { new Guid("27ebf833-e1ba-40a6-b101-da4eb71313d8"), "Jonah's second hemp milk", 26, "Hemp milk" },
                    { new Guid("28327307-f377-4fc4-b497-d85e09552449"), "Kristian's divergent soy milk", 24, "Soy milk" },
                    { new Guid("283ff036-d83d-403c-8a67-b25f1c096682"), "Kentrell's unequaled whole milk", 51, "Whole milk" },
                    { new Guid("2ce0972a-915a-4f42-afe9-09e9364c9668"), "Catrina's fallacious coconut milk", 54, "Coconut milk" },
                    { new Guid("2ceec543-8fd9-4c7c-855a-c1388a68ca78"), "Deangelo's rotten hemp milk", 59, "Hemp milk" },
                    { new Guid("2ef1b9a2-870b-4b78-87c1-1d73070c4cd4"), "Jedidiah's cumbersome oat milk", 16, "Oat milk" },
                    { new Guid("2f1ce24b-9536-4988-a8b5-c7d9334b74ce"), "Judith's steady pea milk", 32, "Pea milk" },
                    { new Guid("33f05a1b-de2e-4319-b279-2313478dd891"), "Duane's typical walnut milk", 89, "Walnut milk" },
                    { new Guid("34a5ceb6-0c67-4794-936b-db67c5ff9109"), "Karlee's rough soy milk", 99, "Soy milk" },
                    { new Guid("352139db-6f31-4856-83eb-4142c92a3c44"), "Joshua's full macadamia milk", 44, "Macadamia milk" },
                    { new Guid("38730f3c-009e-4873-995e-7a023a8f759f"), "Judith's quickest oat milk", 84, "Oat milk" },
                    { new Guid("396937ec-6ae7-4a16-977b-de9544c152b1"), "Sheldon's tasteless hemp milk", 4, "Hemp milk" },
                    { new Guid("3989e76f-0546-4b01-bad6-5d52535e8136"), "Jessi's unbiased almond milk", 76, "Almond milk" },
                    { new Guid("3dbf9e44-fb2f-487b-8b34-7e6e6700e17e"), "Cora's early almond milk", 58, "Almond milk" },
                    { new Guid("3e437e24-8d75-4063-acbf-827d3c833d90"), "Judith's orange cashew milk", 85, "Cashew milk" },
                    { new Guid("3f2a611a-4d0b-41e1-8165-2f8f9a1f66aa"), "Jean's scared coconut milk", 25, "Coconut milk" },
                    { new Guid("41916cd4-9d74-4222-9fa8-114a2d3a64ce"), "Zain's wealthy cashew milk", 71, "Cashew milk" },
                    { new Guid("4500a34b-e06e-4a5f-89fd-7804611e9e51"), "Tea's alive almond milk", 55, "Almond milk" },
                    { new Guid("48029d08-8dcb-486e-8cc8-86961f8658dc"), "Dominik's rough whole milk", 83, "Whole milk" },
                    { new Guid("4e46d68b-cd90-4549-8f49-644fd4fe7a61"), "Joan's numberless soy milk", 98, "Soy milk" },
                    { new Guid("4f183948-3744-4e9e-8907-c6f10644cfbf"), "Johnny's quickest rice milk", 41, "Rice milk" },
                    { new Guid("50045980-f3c9-408b-83bf-a98db403d42d"), "Dillion's taboo hemp milk", 58, "Hemp milk" },
                    { new Guid("50a70194-f239-43f6-81de-25628b27ea5a"), "Jaeden's cooing cashew milk", 33, "Cashew milk" },
                    { new Guid("52c82b59-042b-4b40-8c12-6475156cc87e"), "Kristian's bumpy pea milk", 33, "Pea milk" },
                    { new Guid("602d410e-46e1-4744-9b82-cfc7dd5d0940"), "Lucero's wholesale whole milk", 46, "Whole milk" },
                    { new Guid("62603a88-f96f-4beb-a0ed-98358826974a"), "Deangelo's onerous walnut milk", 57, "Walnut milk" },
                    { new Guid("63937d8a-aaf5-46b4-a997-f78eda7b6157"), "Harlie's squealing pea milk", 47, "Pea milk" },
                    { new Guid("663da2d8-bde6-4eb6-94a3-01bf4c3f8c4f"), "Rodney's relevant hemp milk", 56, "Hemp milk" },
                    { new Guid("6774d933-12ec-4db4-ac3e-215e817a4a56"), "Judith's rotten rice milk", 43, "Rice milk" },
                    { new Guid("6905f2f6-e80c-4601-8ae6-5408485ef9c5"), "Shakayla's loose coconut milk", 82, "Coconut milk" },
                    { new Guid("697a783b-43e4-478e-bd1b-253676e43c0b"), "Joshua's existing rice milk", 73, "Rice milk" },
                    { new Guid("72204ea0-29e2-4da8-bf57-648b37268b71"), "Macie's broad walnut milk", 23, "Walnut milk" },
                    { new Guid("7786da9f-efb9-4e4d-828b-3cf85f1e63c6"), "Kristian's wealthy cashew milk", 11, "Cashew milk" },
                    { new Guid("77afcf09-4b31-445d-b33d-66e197dcbdd0"), "Karlee's painful rice milk", 55, "Rice milk" },
                    { new Guid("78b2fb8e-4c91-439e-a479-f8c1e9595343"), "Kasey's quickest hemp milk", 4, "Hemp milk" },
                    { new Guid("7be33cd3-311a-4418-a24d-a501c8d31465"), "Stephen's fearful macadamia milk", 100, "Macadamia milk" },
                    { new Guid("7cb2ff70-98b4-4735-8cc0-25bc2d37ad44"), "Tyquan's wholesale almond milk", 21, "Almond milk" },
                    { new Guid("7d1d6d3d-160c-4461-9b93-385041a224a2"), "Kentrell's loose hemp milk", 79, "Hemp milk" },
                    { new Guid("7fb4ac10-d5ba-4403-85d1-236ccc76b378"), "Jonah's bumpy hemp milk", 72, "Hemp milk" },
                    { new Guid("81bd9a68-5599-4018-990a-694b519a9bdb"), "Korbin's open pea milk", 94, "Pea milk" },
                    { new Guid("85a307d1-3af5-410a-8cfa-31489fdc9df1"), "Benjamin's scared whole milk", 4, "Whole milk" },
                    { new Guid("87704f41-8529-4268-aaad-5c20023d0db6"), "Jaquez's whole oat milk", 50, "Oat milk" },
                    { new Guid("886fa2ee-e61f-42e8-8f90-80d46f792924"), "Catrina's aware macadamia milk", 64, "Macadamia milk" },
                    { new Guid("9001c051-305d-462c-aefb-be220eadae6b"), "Jaquez's unequaled hemp milk", 76, "Hemp milk" },
                    { new Guid("9373d575-0d21-4e11-80d6-e7e35a836f28"), "Stephen's wealthy hemp milk", 34, "Hemp milk" },
                    { new Guid("9466032f-db34-49d3-9ae3-7385cc0082f7"), "Chandler's full oat milk", 32, "Oat milk" },
                    { new Guid("95992ab8-183a-4e19-b404-970e24d5300a"), "Elliot's unbiased pea milk", 48, "Pea milk" },
                    { new Guid("9811f876-ebc9-44f0-88ae-1d087cb940db"), "Brittney's unbiased coconut milk", 96, "Coconut milk" },
                    { new Guid("99370f4e-7b31-4d0f-94ab-bd6dae094ddb"), "Nehemiah's salty hemp milk", 4, "Hemp milk" },
                    { new Guid("9a2bfc2f-2a8f-4a62-92b0-dcdcca37bba2"), "Felicity's second cashew milk", 76, "Cashew milk" },
                    { new Guid("a3df7049-9b81-476d-a803-e8ed8aca161a"), "Johnny's second whole milk", 54, "Whole milk" },
                    { new Guid("a83d309f-ebe5-4bed-9555-bc18869d98ca"), "Elliot's voiceless cashew milk", 87, "Cashew milk" },
                    { new Guid("aa5ce91a-67e6-4349-b1c2-4c4050efb49e"), "Jedidiah's early almond milk", 49, "Almond milk" },
                    { new Guid("ad3bf06b-9c2d-4c3e-8fdd-d0fec4ef99b6"), "Kentrell's rough almond milk", 40, "Almond milk" },
                    { new Guid("b1b4f84b-57f2-420a-9506-ac0636935ab0"), "Kasey's painful pea milk", 62, "Pea milk" },
                    { new Guid("b3a8ed8d-be54-40b7-9880-5e7df192b981"), "Stephen's torpid walnut milk", 26, "Walnut milk" },
                    { new Guid("b48a9bbd-ef6b-4205-8c06-014e891a9faf"), "Dominik's fearful oat milk", 25, "Oat milk" },
                    { new Guid("b6679277-32a8-4d7c-9e19-2799aa9a3fb3"), "Karlee's tan oat milk", 39, "Oat milk" },
                    { new Guid("ba46543f-2bd3-449e-8e62-ee6f269bfc10"), "Jonah's early hemp milk", 44, "Hemp milk" },
                    { new Guid("cc96a41f-bb3a-450c-ae76-683edc71be52"), "Michele's alive walnut milk", 25, "Walnut milk" },
                    { new Guid("ce87d24d-e70d-4b21-961c-addc7162f792"), "Nehemiah's wealthy cashew milk", 35, "Cashew milk" },
                    { new Guid("cf5a5299-c4dd-4699-a8d7-1eed6382888b"), "Kristian's early coconut milk", 35, "Coconut milk" },
                    { new Guid("d2f12e7b-f096-4391-ad72-b4517deb24cf"), "Jessalyn's fallacious almond milk", 65, "Almond milk" },
                    { new Guid("d3ba0a73-29a1-4802-b284-a498df060c42"), "Benjamin's taboo soy milk", 87, "Soy milk" },
                    { new Guid("d407b372-2624-4e7b-8e8b-d6b2c1641e5a"), "Lance's steady walnut milk", 59, "Walnut milk" },
                    { new Guid("d6e96a38-ce76-42d9-95a4-7247ea4dcb7a"), "Christa's squealing cashew milk", 100, "Cashew milk" },
                    { new Guid("d84696a9-600d-4912-914d-bbb7f6a5e744"), "Tea's wide pea milk", 40, "Pea milk" },
                    { new Guid("dd9140c5-af1d-4861-9736-e0b4f4a81bb7"), "Gaven's numberless walnut milk", 89, "Walnut milk" },
                    { new Guid("df679bb2-a8b0-41af-a291-02b28c10c4ff"), "Tea's strong hemp milk", 19, "Hemp milk" },
                    { new Guid("e0041dbf-13bf-4371-9b2c-ff575492411e"), "Nehemiah's open almond milk", 23, "Almond milk" },
                    { new Guid("e250de50-a606-49d9-afa7-fa118c9a3184"), "Joshua's rotten oat milk", 15, "Oat milk" },
                    { new Guid("e554d358-ec1c-4b9b-97a3-97fa999abb64"), "Dominik's alive whole milk", 97, "Whole milk" },
                    { new Guid("e80064ce-5599-46f6-a2d9-6bc7a1aca872"), "Jocelyn's rough soy milk", 25, "Soy milk" },
                    { new Guid("ea1aadc3-bd1e-4f43-a46d-e035e7a96282"), "Jonah's aware cashew milk", 79, "Cashew milk" },
                    { new Guid("f6e801ff-336e-4aa7-879b-13b16bef285f"), "Samuel's broad soy milk", 33, "Soy milk" },
                    { new Guid("f8021d2c-c37a-4e62-afe6-02487057cc3b"), "Kerry's unbiased whole milk", 21, "Whole milk" },
                    { new Guid("fd2349a0-3d48-4d9b-ac22-6290d1053495"), "Sheldon's tasteless cashew milk", 80, "Cashew milk" },
                    { new Guid("fe7c5123-4141-427e-92ed-e9b41bf88c2a"), "Jean's wide hemp milk", 90, "Hemp milk" },
                    { new Guid("ff6524a8-ab9c-4320-8c41-17e3a8da268e"), "Judith's bumpy almond milk", 66, "Almond milk" },
                    { new Guid("ffd3b484-ede9-43da-aad8-d4d318438d7d"), "Cora's loose pea milk", 70, "Pea milk" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("0037a064-7ce1-4c97-b8a0-51848775a7a9"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("0597329f-b2fb-49a9-a5fd-13797fa1d7ce"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("06d60157-e9c7-4bd9-b2a6-00fd63bb2033"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("0798ae22-c922-4b47-adc5-23feac38020f"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("0ac95b83-bdce-497c-b0c3-7c0071419324"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("10aed344-837d-4621-873e-aeac9394c99f"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("1627d6d8-1a96-4011-8294-49b9f1e90ba8"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("179670c3-e49f-4655-ab71-12a90b912cc5"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("1bba8dfc-07af-414d-b85d-663443612e5b"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("1d52f5a1-4c39-4352-85df-168320fb3575"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("1dda5869-263d-460c-8275-3b131e17c601"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("1fcb5bbb-0fa4-40d5-92ae-0e751c18d704"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("2356a84e-0fbb-4b5b-993c-0bc6c70586e2"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("2534898d-223e-49f8-9a4f-2993458fc5f2"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("264a505c-4d88-4a61-966c-471d5233d8d1"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("2702fab9-db1c-44bf-a43f-9107cf21e499"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("27ebf833-e1ba-40a6-b101-da4eb71313d8"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("28327307-f377-4fc4-b497-d85e09552449"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("283ff036-d83d-403c-8a67-b25f1c096682"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("2ce0972a-915a-4f42-afe9-09e9364c9668"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("2ceec543-8fd9-4c7c-855a-c1388a68ca78"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("2ef1b9a2-870b-4b78-87c1-1d73070c4cd4"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("2f1ce24b-9536-4988-a8b5-c7d9334b74ce"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("33f05a1b-de2e-4319-b279-2313478dd891"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("34a5ceb6-0c67-4794-936b-db67c5ff9109"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("352139db-6f31-4856-83eb-4142c92a3c44"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("38730f3c-009e-4873-995e-7a023a8f759f"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("396937ec-6ae7-4a16-977b-de9544c152b1"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("3989e76f-0546-4b01-bad6-5d52535e8136"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("3dbf9e44-fb2f-487b-8b34-7e6e6700e17e"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("3e437e24-8d75-4063-acbf-827d3c833d90"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("3f2a611a-4d0b-41e1-8165-2f8f9a1f66aa"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("41916cd4-9d74-4222-9fa8-114a2d3a64ce"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("4500a34b-e06e-4a5f-89fd-7804611e9e51"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("48029d08-8dcb-486e-8cc8-86961f8658dc"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("4e46d68b-cd90-4549-8f49-644fd4fe7a61"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("4f183948-3744-4e9e-8907-c6f10644cfbf"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("50045980-f3c9-408b-83bf-a98db403d42d"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("50a70194-f239-43f6-81de-25628b27ea5a"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("52c82b59-042b-4b40-8c12-6475156cc87e"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("602d410e-46e1-4744-9b82-cfc7dd5d0940"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("62603a88-f96f-4beb-a0ed-98358826974a"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("63937d8a-aaf5-46b4-a997-f78eda7b6157"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("663da2d8-bde6-4eb6-94a3-01bf4c3f8c4f"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("6774d933-12ec-4db4-ac3e-215e817a4a56"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("6905f2f6-e80c-4601-8ae6-5408485ef9c5"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("697a783b-43e4-478e-bd1b-253676e43c0b"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("72204ea0-29e2-4da8-bf57-648b37268b71"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("7786da9f-efb9-4e4d-828b-3cf85f1e63c6"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("77afcf09-4b31-445d-b33d-66e197dcbdd0"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("78b2fb8e-4c91-439e-a479-f8c1e9595343"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("7be33cd3-311a-4418-a24d-a501c8d31465"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("7cb2ff70-98b4-4735-8cc0-25bc2d37ad44"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("7d1d6d3d-160c-4461-9b93-385041a224a2"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("7fb4ac10-d5ba-4403-85d1-236ccc76b378"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("81bd9a68-5599-4018-990a-694b519a9bdb"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("85a307d1-3af5-410a-8cfa-31489fdc9df1"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("87704f41-8529-4268-aaad-5c20023d0db6"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("886fa2ee-e61f-42e8-8f90-80d46f792924"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("9001c051-305d-462c-aefb-be220eadae6b"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("9373d575-0d21-4e11-80d6-e7e35a836f28"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("9466032f-db34-49d3-9ae3-7385cc0082f7"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("95992ab8-183a-4e19-b404-970e24d5300a"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("9811f876-ebc9-44f0-88ae-1d087cb940db"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("99370f4e-7b31-4d0f-94ab-bd6dae094ddb"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("9a2bfc2f-2a8f-4a62-92b0-dcdcca37bba2"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("a3df7049-9b81-476d-a803-e8ed8aca161a"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("a83d309f-ebe5-4bed-9555-bc18869d98ca"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("aa5ce91a-67e6-4349-b1c2-4c4050efb49e"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("ad3bf06b-9c2d-4c3e-8fdd-d0fec4ef99b6"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("b1b4f84b-57f2-420a-9506-ac0636935ab0"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("b3a8ed8d-be54-40b7-9880-5e7df192b981"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("b48a9bbd-ef6b-4205-8c06-014e891a9faf"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("b6679277-32a8-4d7c-9e19-2799aa9a3fb3"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("ba46543f-2bd3-449e-8e62-ee6f269bfc10"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("cc96a41f-bb3a-450c-ae76-683edc71be52"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("ce87d24d-e70d-4b21-961c-addc7162f792"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("cf5a5299-c4dd-4699-a8d7-1eed6382888b"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("d2f12e7b-f096-4391-ad72-b4517deb24cf"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("d3ba0a73-29a1-4802-b284-a498df060c42"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("d407b372-2624-4e7b-8e8b-d6b2c1641e5a"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("d6e96a38-ce76-42d9-95a4-7247ea4dcb7a"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("d84696a9-600d-4912-914d-bbb7f6a5e744"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("dd9140c5-af1d-4861-9736-e0b4f4a81bb7"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("df679bb2-a8b0-41af-a291-02b28c10c4ff"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("e0041dbf-13bf-4371-9b2c-ff575492411e"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("e250de50-a606-49d9-afa7-fa118c9a3184"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("e554d358-ec1c-4b9b-97a3-97fa999abb64"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("e80064ce-5599-46f6-a2d9-6bc7a1aca872"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("ea1aadc3-bd1e-4f43-a46d-e035e7a96282"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("f6e801ff-336e-4aa7-879b-13b16bef285f"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("f8021d2c-c37a-4e62-afe6-02487057cc3b"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("fd2349a0-3d48-4d9b-ac22-6290d1053495"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("fe7c5123-4141-427e-92ed-e9b41bf88c2a"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("ff6524a8-ab9c-4320-8c41-17e3a8da268e"));

            migrationBuilder.DeleteData(
                table: "MilkProducts",
                keyColumn: "Id",
                keyValue: new Guid("ffd3b484-ede9-43da-aad8-d4d318438d7d"));
        }
    }
}
