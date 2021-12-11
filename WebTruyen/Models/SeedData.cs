using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace WebTruyen.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            var scope = app.ApplicationServices.CreateScope();

            ApplicationDbContext context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            if (!context.Truyens.Any())
            {
                context.Truyens.AddRange(
                    //1
                    new Truyen
                    {
                        TenTruyen= "Xuyên nhanh: Nữ xứng, bình tĩnh một chút",
                        ChuThich= "Nàng nguyên lai là cái nữ xứng, mỗi lần kết cục đều thực thảm. Sau lại mới tỉnh ngộ, trói định nàng hoang dại hệ thống là cái thiểu năng trí tuệ, không cho tân thủ lễ bao, không cho lão thủ lễ bao, hoàn thành nhiệm vụ còn không có khen thưởng, nàng quyết định không làm.\n" +
                        "\n"+
                        "Hệ thống: Cảnh cáo! Thỉnh hảo hảo làm việc, bằng không sẽ bị mạt sát.\n" +
                        "\n" +
                        "Đường Quả: Nằm mơ.\n" +
                        "\n" +
                        "Hệ thống: Ký chủ, cầu xin ngươi, không cần lại khi dễ nam nữ chủ.\n" +
                        "\n" +
                        "Đường Quả: Không có khả năng.\n" +
                        "\n" +
                        "Hệ thống: Đại đại tính toán như thế nào tai họa thế giới này, cầu mang phi a.\n" +
                        "\n" +
                        "Hệ thống: Đại đại tính toán như thế nào tai họa thế giới này, cầu mang phi a.\n" +
                        "\n" +
                        "Hệ thống: Anh anh anh…… Hảo đát! Đại đại, thỉnh chờ một lát nga.\n" +
                        "\n" +
                        "【 nữ cường, 1v1】\n" +
                        "\n" +
                        "Tác phẩm nhãn: Sủng văn, phúc hắc, hệ thống lưu, lâu ngày sinh tình",
                        TrangThai="Hoàn Thành",
                        TheLoai ="Xuyên Nhanh",
                        SoChuong=5814,
                        ImageUrl="nuxungbinhtinhmotchut.jpeg"
                    },
                    //2
                    new Truyen
                    {
                        TenTruyen= "Tà Vương truy thê / Một đời khuynh thành / Lầm chọc yêu nghiệt Vương gia: Phế tài nghịch thiên tứ tiểu thư",
                        ChuThich= "Nàng, thế kỷ 21 kim bài sát thủ, lại xuyên vì Tô phủ nhất vô dụng phế sài Tứ tiểu thư trên người.\n" +
                        "\n" +
                        "Hắn, đế quốc Tấn Vương điện hạ, lãnh khốc tà mị cường thế bá đạo, thiên phú trác tuyệt.\n" +
                        "\n" +
                        "Thế nhân đều biết nàng là bao cỏ phế tài, tùy ý ức hiếp lăng nhục, duy độc hắn tuệ nhãn thức châu đối nàng cường thế bá đạo dây dưa thề sống chết không buông tay.\n" +
                        "\n" +
                        "Thả xem bọn hắn như thế nào cường giả cùng cường giả va chạm, trình diễn vừa ra truy đuổi cùng bị truy đuổi trò hay.",
                        TrangThai = "Hoàn Thành",
                        TheLoai= "Ngôn tình",
                        SoChuong=11745,
                        ImageUrl ="tavuongtruythe.jpeg"
                    },
                    //3
                    new Truyen
                    {
                        TenTruyen = "Xuyên nhanh: Cứu mạng, nam chủ tất cả đều tan vỡ!",
                        ChuThich = "【【 hồng tụ đọc sách —— lần thứ nhất “Toàn cầu yêu cầu viết bài đại tái” 】 tác phẩm dự thi 】\n" +
                        "\n" +
                        "( 1v1, song khiết, sủng sủng sủng văn ) tô đường nguyện vọng, tích cóp đủ một trăm triệu, về nhà dưỡng lão.\n" +
                        "\n" +
                        "Nhưng mà liền ở nàng hoàn thành nhiệm vụ, sắp vui rạo rực về nhà khi, bị hệ thống báo cho, tích phân đông lại, thế giới tan vỡ, nam chủ tất cả đều hắc hóa!\n" +
                        "\n" +
                        "Bạo quân: Ta muốn giết cái này tiểu pháo hôi!\n" +
                        "\n" +
                        "Bá tổng: Tỷ tỷ thật đáng yêu, muốn giết.\n" +
                        "\n" +
                        "Nguyên soái: A, tiểu dẫn đường, đánh gãy chân.\n" +
                        "\n" +
                        "Đối này, tô đường run bần bật: Ta khuyên nam chủ thiện lương.\n" +
                        "\n" +
                        "Tác phẩm nhãn: Nhẹ nhàng, bạo quân, giả heo ăn hổ, xuyên qua, mạo hiểm",
                        TrangThai= "Hoàn Thành",
                        TheLoai = "Xuyên Nhanh",
                        SoChuong =1452,
                        ImageUrl="cuumangnamchutanvo.jpeg"
                    },
                    //4
                    new Truyen
                    {
                        TenTruyen= "Xuyên nhanh: Nữ chủ giá lâm, nữ xứng mau lui tán!",
                        ChuThich= "Thanh Hà quận chúa Cố Thịnh Nhân đã chết.\n" +
                        "\n" +
                        "Nàng dung sắc quan kinh hoa, tài danh động thiên hạ, lại thua ở một cái mọi thứ không bằng chính mình nữ nhân trong tay\n" +
                        "\n" +
                        "Thẳng đến sau khi chết, Cố Thịnh Nhân mới hiểu được, chính mình bất quá là một cái nữ xứng nghịch tập chuyện xưa nữ chính, xứng đáng chính là xuyên qua nữ xứng pháo hôi……\n" +
                        "\n" +
                        "Thuần trắng không gian nội, Cố Thịnh Nhân mặt vô biểu tình tiếp thu hệ thống truyền cho nàng ký ức……\n" +
                        "\n" +
                        "Thuần trắng không gian nội, Cố Thịnh Nhân mặt vô biểu tình tiếp thu hệ thống truyền cho nàng ký ức……\n" +
                        "\n" +
                        "Cố Thịnh Nhân trong ánh mắt lập loè hàn mang, cười phong hoa tuyệt đại: “Vậy để cho ta tới nhìn xem: Ai, mới là hẳn là bị đá rớt chướng ngại vật, ai, lại là cuối cùng người thắng!”\n" +
                        "\n" +
                        "Những cái đó muốn xử lý nữ chủ thượng vị nữ xứng nhóm pháo hôi nhóm, các ngươi tưởng hảo, muốn chết như thế nào sao?\n" +
                        "\n" +
                        "Bổn văn 1V1.\n" +
                        "\n" +
                        "Tác phẩm nhãn: Sủng văn, mỹ nam, chuyên tình, dưỡng thành, nhất kiến chung tình.",
                        TrangThai = "Hoàn Thành",
                        TheLoai = "Xuyên Nhanh",
                        SoChuong=2214,
                        ImageUrl="nuchugialam.jpeg"
                    },
                    //5
                    new Truyen 
                    {
                        TenTruyen= "Đệ nhất gieo trồng đại sư ( thực tế ảo )",
                        ChuThich= "Thể loại truyện: Nguyên sang - vô CP- ảo tưởng tương lai - cốt truyện\n" +
                        "\n" +
                        "Thị giác tác phẩm: Nam chủ\n" +
                        "\n" +
                        "Phong cách tác phẩm: Nhẹ nhàng\n" +
                        "\n" +
                        "---------------------------\n" +
                        "\n" +
                        "Tô Dung sau khi chết trọng sinh. Tuy rằng từ rường cột chạm trổ Tô phủ trọng sinh tới rồi một gian rách tung toé nhà tranh, bất quá, nhìn đến phòng trước hoang phế thổ địa, Tô Dung tâm tình sung sướng cầm lấy góc tường cái cuốc cái xẻng. Không bằng gieo trồng, cẩm y ngọc thực cũng không bằng gieo trồng. Đánh chết quá tưởng cường đoạt thực vật dã thú, trêu đùa lại đây trích thực trái cây con khỉ, Tô Dung phát hiện hắn loại thực vật tựa hồ có đặc thù công hiệu. Thẳng đến có một ngày, bên tai vang lên một đạo dễ nghe thanh âm “Chúc mừng người chơi đạt thành gieo trồng đại sư thành tựu, trở thành thế giới thứ hai duy nhất gieo trồng đại sư. Nguyện người chơi có thể mở ra sở trường, tiền đồ như gấm.”\n" +
                        "\n" +
                        "Tô Dung:……\n" +
                        "\n" +
                        "Không bằng gieo trồng, tiền đồ như gấm cũng không bằng gieo trồng.\n" +
                        "\n" +
                        "---------------------------\n" +
                        "\n" +
                        "Tag: Cổ xuyên kim, làm ruộng văn, trò chơi võng du, sảng văn\n" +
                        "\n" +
                        "Từ khóa tìm kiếm: Vai chính: Tô Dung ┃ vai phụ: ┃ cái khác:\n" +
                        "\n" +
                        "Một câu tóm tắt: Ta ái gieo trồng, gieo trồng sử ta vui sướng\n" +
                        "\n" +
                        "Lập ý: Lao động sáng tạo tốt đẹp sinh hoạt",
                        TrangThai = "Hoàn Thành",
                        TheLoai= "Nguyên sang",
                        SoChuong=68,
                        ImageUrl ="denhatgieotrongdaisu.jpeg"
                    },
                    //6
                    new Truyen
                    {
                        TenTruyen= "Hắc hóa nam chủ tổng tưởng kịch bản ta",
                        ChuThich= "P.s: đã fix một số chương thiếu, nếu còn là do chưa tìm thấy raw.\n" +
                        "\n" +
                        "【bệnh kiều siêu ngọt sủng, một chọi một】\n" +
                        "\n" +
                        "# Tô Yên thần cách ····· rớt. #\n" +
                        "\n" +
                        "nàng hệ thống nói, nếu muốn tìm hoàn hồn cách, phải thực hiện nam chủ nguyện vọng.\n" +
                        "\n" +
                        "Kết quả là, nàng bắt đầu rồi từ từ công lược nam chủ chi lộ.\n" +
                        "\n" +
                        "Kiệt ngạo thiếu niên mặt mày lệ khí:\n" +
                        "\n" +
                        "“Ngươi chỉ có thể thích ta một người.”\n" +
                        "\n" +
                        "Bệnh kiều hoàng tử ánh mắt sâu kín:\n" +
                        "\n" +
                        "“Ngươi nói ngươi sẽ ở ta bên người bồi ta cả đời.”\n" +
                        "\n" +
                        "Tà mị ảnh đế mắt đào hoa một chọn:\n" +
                        "\n" +
                        "“Tiểu Tô Yên, lại đây làm ta thân thân.”\n" +
                        "\n" +
                        "Tô Yên rối rắm, nàng chỉ là muốn tìm về chính mình thần cách mà thôi, như thế nào còn cấp quấn lên? ···· nhìn trước mặt nam nhân tầm mắt không thích hợp, lập tức sửa lại khẩu, là là là, đều là vì ngươi, thích nhất ngươi!\n" +
                        "\n" +
                        "Nam chủ đầy tay là huyết, từng bước tới gần, lẩm bẩm:\n" +
                        "\n" +
                        "“Ngươi đã nói, sẽ lưu tại ta bên người, vĩnh viễn đều sẽ không rời đi.”\n" +
                        "\n" +
                        "Tô Yên nhẹ hống:\n" +
                        "\n" +
                        "“Hảo hảo hảo, đều nghe ngươi, ta trước đem này huyết sát sát, đừng dọa người khác??”",
                        TrangThai= "Hoàn Thành",
                        TheLoai= "Ngôn tình",
                        SoChuong=2162,
                        ImageUrl="hachoanamchu.jpeg"
                    },
                    //7
                    new Truyen
                    {
                        TenTruyen= "Mao Sơn tróc quỷ nhân",
                        ChuThich= "Mao Sơn bắt quỷ người Diệp Thiếu Dương dũng sấm đô thị, cùng người đấu, cùng quỷ đấu, cùng mị yêu mỹ hồ đấu. Tương tây thi vương, bất tử tà thần, đĩa tiên hung linh, tứ phương quỷ khấu. Dưỡng tiểu quỷ nữ minh tinh, hút máu hoàng gia công chúa, hồ yêu quấn thân nữ tổng tài. Mao Sơn thần thuật, một đường toàn thu!\n" +
                        "\n" +
                        "-------------------\n" +
                        "\n" +
                        "Truyện được nhúng từ link tiếng Trung của trang uukanshu, do hệ thống dịch tự động dựa theo file từ điển BQT biên soạn và từ điển name riêng do hệ thống lọc ra, người nhúng và Đồng Quản Lý bổ sung thêm.\n" +
                        "\n" +
                        "Khi uukanshu xuất hiện chương mới, hệ thống sẽ tự động copy chương tiếng Trung về, tự động chuyển ngữ. Cho nên:\n" +
                        "\n" +
                        "- Xin đừng thúc giục chương mới, vì chương mới là do hệ thống tự cập nhật, link nhúng có thì wiki mới có, link nhúng ko có thì wiki ko thể tự hô biến ra được. Nếu phát hiện chương nào có nội dung sai, hãy bấm nút Báo lỗi ở cuối chương đó, hoặc nhắn tin cho admin để sửa lại:\n" +
                        "\n" +
                        "- Khi xem truyện nếu phát hiện tên nhân vật dịch sai hoặc ko viết hoa, bạn cũng có thể tự sửa lại, bằng cách xin làm Đồng quản lý rồi thêm name này vào.\n" +
                        "\n" +
                        "Truyện trên wiki được xử lý tự động hóa, nếu muốn đọc truyện với chất lượng tốt hơn, hãy tự phục vụ mình.\n" +
                        "\n" +
                        "--------------------\n" +
                        "\n" +
                        "Ghi chú : đã sửa thủ công 1 số chương, đừng đổi link và đừng sử dụng chất tẩy cực mạnh khi vá phòng trộm.",
                        TrangThai= "Hoàn thành",
                        TheLoai = "Nam sinh",
                        SoChuong =1041,
                        ImageUrl="maosontrocquynhan.jpeg"
                    },
                    //8
                    new Truyen
                    {
                        TenTruyen = "Ẩn hôn ngọt sủng: Đại tài phiệt tiểu kiều thê",
                        ChuThich = "【 trọng sinh ngọt sủng + ngược tra ngược cẩu 】\n" +
                        "\n" +
                        "Kiếp trước, Cố Vi Vi bị sở ái nam nhân đào đi trái tim, nhổ trồng cho nàng tín nhiệm nhất khuê mật.\n" +
                        "\n" +
                        "Một sớm trọng sinh, lại thành Hoa Quốc đệ nhất tài phiệt Phó Hàn Tranh tiểu nữ hữu.\n" +
                        "\n" +
                        "Nàng từng bước tiểu tâm, hướng đã từng ám hại nàng người báo thù. Hắn nơi chốn bảo hộ, đem nàng sủng đến mức tận cùng.\n" +
                        "\n" +
                        "Đều nói, Phó Hàn Tranh cao lãnh bạc tình vô nhân tính. Ngày đó thiên liêu đến mặt nàng hồng tâm nhảy, sủng nàng sủng đến vô pháp vô thiên hoàn mỹ lão công, là cái giả lão công sao?\n" +
                        "\n" +
                        "“Tiên sinh, trường học thật nhiều nam sinh ở truy thái thái.”\n" +
                        "\n" +
                        "“Đem trường học nam sinh toàn bộ thôi học, cho ta cải biến thành nữ giáo.”\n" +
                        "\n" +
                        "“Tiên sinh, thái thái cùng trong vòng đương hồng nam tinh truyền tai tiếng, xào CP.”\n" +
                        "\n" +
                        "“Đem cái kia nam tinh phong sát!”\n" +
                        "\n" +
                        "“Đó là ngươi đệ đệ.”\n" +
                        "\n" +
                        "“…… Vậy đánh chết đi.”",
                        TrangThai= "Hoàn thành",
                        TheLoai= "Ngôn tình",
                        SoChuong=287,
                        ImageUrl ="anhonngotsung.jpeg"
                    },
                    //9
                    new Truyen
                    {
                        TenTruyen= "Tu tiên: Hóa thân tượng đá hàng yêu trừ ma",
                        ChuThich= "Linh Châu có tòa thành.\n" +
                        "\n" +
                        "Ban ngày, bên trong thành ngựa xe như nước, ngoài thành non xanh nước biếc.\n" +
                        "\n" +
                        "Đêm tối, bên trong thành yêu ma tàn sát bừa bãi, ngoài thành mãnh quỷ đêm hành.\n" +
                        "\n" +
                        "Cửa thành chỗ có tòa tượng đá, trấn áp ác linh ba ngàn năm, thẳng đến mỗ một ngày, tượng đá đột nhiên chớp một chút mắt, 8000 ác quỷ ngang trời xuất thế, mười vạn yêu ma đạp đất thành tinh.\n" +
                        "\n" +
                        "Mà đỗ thiên phàm chẳng qua là ngủ một giấc, tỉnh lại sau phát hiện, thế giới này yêu ma quỷ quái như thế nào liền nhiều như vậy?",
                        TrangThai= "Còn tiếp",
                        TheLoai= "Nam sinh",
                        SoChuong=46,
                        ImageUrl="hangyeutruma.jpeg"
                    },
                    //10
                    new Truyen
                    {
                        TenTruyen= "Xuyên thư: Hôm nay ngươi phất nhanh sao?",
                        ChuThich= "Tây Lương xuất thân xóm nghèo, mộng tưởng có một ngày có thể gả vào hào môn, giao cái phú nhị đại bạn trai sau, các loại ôn nhu săn sóc chiếu cố, kết quả bị quăng 500 vạn chi phiếu, cũng báo cho nàng bất quá là hắn bạch nguyệt quang thế thân mà thôi.\n" +
                        "\n" +
                        "Tây Lương lại giao cái bạn trai, lần này, Tây Lương cảm thấy ôn nhu bạn trai khẳng định sẽ không giống thượng một cái bạn trai như vậy, kết quả lại bị quăng một bộ giá trị một ngàn vạn biệt thự, mới biết được chính mình cùng hắn bạn gái cũ thập phần tương tự.\n" +
                        "\n" +
                        "Tây Lương cầm kia trương 500 vạn chi phiếu cùng một bộ giá trị một ngàn vạn biệt thự quyền tài sản giấy chứng nhận, châm chước hồi lâu, bạn cùng phòng biểu cô mẫu gả vào hào môn sau tiền tiêu vặt nguyệt hai mươi vạn, nàng đương ba tháng thế thân được 1500 vạn……\n" +
                        "\n" +
                        "Tây Lương làm giấc mộng, mơ thấy bạn trai cũ bạch nguyệt quang cùng nốt chu sa đều là cùng cái hải vương, xuyên thư nữ chủ dưỡng cái ao cá, bên trong cá phi phú tức quý.\n" +
                        "\n" +
                        "Tháng thứ nhất, Tây Lương một thân OL đi ngang qua mỗ bá tổng Maybach, tương tự sườn mặt, cùng ngày, bá tổng liền ở công ty thấy được cái này tân nhiệm bí thư.\n" +
                        "\n" +
                        "Tháng thứ hai, Tây Lương một tịch tri tâm tỷ tỷ khoản ngồi ở tiểu học đệ bậc thang bên, cười đến minh nhã diễm lệ.\n" +
                        "\n" +
                        "Tháng thứ ba……\n" +
                        "\n" +
                        "Sau lại, nàng tiền nhiệm nhóm nhớ tới Tây Lương tại bên người khi ấm áp nhật tử, ở một cái mưa to bàng bạc ban đêm, quỳ gối nàng phòng trước quỳ cầu hợp lại.\n" +
                        "\n" +
                        "Từng người phát hiện đối phương, đánh lên……\n" +
                        "\n" +
                        "Tây Lương ngồi ở biệt thự đếm một xấp ảnh chụp: Là cái này cuồng dã hệ đại chó săn hảo? Vẫn là cái này cấm dục hệ chó con hảo?\n" +
                        "\n" +
                        "Tiền nhiệm nhóm: Ngươi thế nhưng cầm chúng ta tiền đi nuôi chó nam nhân?\n" +
                        "\n" +
                        "Hải vương phát hiện, nàng ao cá cá, đều thành người khác tôm.\n" +
                        "\n" +
                        "PS: Tiền nhiệm đều là chia tay sau lại tìm.\n" +
                        "\n" +
                        "Tag: Nữ xứng Xuyên thư Sảng văn\n" +
                        "\n" +
                        "Từ khóa tìm kiếm: Vai chính: Tây Lương\n" +
                        "\n" +
                        "Từ khóa tìm kiếm: Vai chính: Tây Lương\n" +
                        "\n" +
                        "Lập ý: Mộng tưởng yêu cầu làm đến nơi đến chốn đi thực hiện",
                        TrangThai= "Còn tiếp",
                        TheLoai= "Ngôn tình",
                        SoChuong=17,
                        ImageUrl="homnaynguoiphatnhanhsao.jpeg"
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
