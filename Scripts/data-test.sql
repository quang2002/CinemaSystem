USE [CinemaSystem];
GO

-- Categories
INSERT INTO [Category]([Name], [Desc]) VALUES 
(N'Action', N'Là thể loại có nội dung hành động, đánh đấm hoặc sử dụng nhiều loại vũ khí và nhiều băng nhóm giang hồ đối địch với nhau. Truyện thường mang đến cảm giác mạnh cho người đọc, có thể là những cảnh đánh nhau tất tay, máu me và không dành cho những người yếu tim hoặc tâm lý yếu.'),
(N'Comedy', N'Là thể loại chứa đựng nhiều tình tiết hài hước, dễ khiến độc giả bật cười, tuy nhiên, thể loại này không chỉ dừng lại ở đó, đan xen giữa những yếu tố gây cười là những bài học về cuộc sống không thể bỏ qua.'),
(N'Mystery', N'Là thể loại luôn khiến cho người xem có cảm giác thích thú tò mò, đôi khi phải “xoắn não” để phân tích những tình tiết trong phim. Các chủ đề quen thuộc trong anime thuộc thể loại này thường là án mạng, những tội ác, các sự kiện trong quá khứ, kí ức hay hành động của con người,… Với cách xây dựng cốt truyện ly kì, thể loại Mystery luôn khiến người xem phải chăm trú, tập trung vào từng cảnh phim, đôi khi phải ngẫm nghĩ, suy luận về những vấn đề trong phim.'),
(N'Romance', N'Là những câu chuyện về tình yêu. Ớ đây chúng ta sẽ lấy ví dụ như tình yêu giữa một người con trai và con gái, bên cạnh đó đặc điểm thể loại này là kích thích trí tưởng tượng của bạn về tình yêu. Đây cũng là thể loại mà nói dễ hiểu là "lãng mạng, mơ mộng, bay bổng".'),
(N'Fiction', N'Là từ chỉ mọi loại tác phẩm, mà trong một phần hay xuyên suốt toàn bộ, chúng nói về các thông tin và sự kiện không có thật. Những tác phẩm này là do hư cấu nên hay dựa trên các giả thuyết — nói cách khác, chúng là sản phẩm của trí tưởng tượng của tác giả.'),
(N'Isekai', N'là một tiểu thể loại light novel, manga, anime và video game kỳ ảo (fantasy) của Nhật Bản, xoay quanh một người bình thường được đưa đến hoặc bị mắc kẹt trong một vũ trụ song song. Isekai bao gồm hay không chỉ có thể loại xuyên không hay chuyển sinh (sinh ra ở một thế giới khác).'),
(N'Harem', N'Harem là một thể loại của anime và manga, trong đó tập trung vào nhân vật chính, thường là tình yêu, gắn kết với 2 hoặc nhiều hơn nhân vật khác giới hoặc cùng giới[1] Dạng phổ biến nhất của harem là một nhân vật nam chính và một nhóm nhân vật nữ[2] Một số biến thể gần đây của harem cho phép cả mối quan hệ thân mật giữa nhiều nhân vật cùng giới là yuri harem và yaoi harem.'),
(N'Fantasy', N'Fantasy thường xuất hiện các yếu tố chỉ có trong tưởng tượng như phép thuật, thần chú, các nàng tiên, phù thủy, quái vật, quỷ vương, rồng, các vị thần, hiệp sĩ, anh hùng,... Đúng như ý nghĩa của nó, thể loại fantasy tạo nên một thế giới khiến chúng ta tha hồ thỏa mãn trí tưởng tượng, đó là lí do tại sao fantasy được coi là một trong những thể loại được yêu thích nhất trên toàn thế giới.'),
(N'Psychological thriller', N'Là một thể loại mà yếu tố căng thẳng thường xuyên được các nhà làm phim khai thác để cuốn người xem vào bí ẩn cuối cùng.')


-- SPY x Family
INSERT INTO [Film]([Name], [Desc], [ImageURL], [Length], [ReleaseDate])
VALUES
(N'SPY x FAMILY', N'Đặc vụ "Twilight" của Westalis được cử trà trộn vào nước địch để thám sát kẻ thù đang có âm mưu phá hoại nền hòa bình đông tây. Vì tính chất của nhiệm vụ, bậc thầy cải trang Twilight bắt buộc phải lập gia đình và có con thì mới có thể tiếp cận được mục tiêu. Với một kẻ chưa từng có người thân và luôn làm việc một mình, Twilight sớm tìm thấy mình mắc kẹt trong chuyện gia đình dở khóc dở cười.', 'https://res.cloudinary.com/quang2002/image/upload/spy-x-family_phgcz5', 1234, GETDATE())

INSERT INTO [FilmCategory] VALUES 
(1, 1), 
(1, 2)

-- Suy Luận Hư Cấu
INSERT INTO [Film]([Name], [Desc], [ImageURL], [Length], [ReleaseDate])
VALUES
(N'Suy Luận Hư Cấu', N'Kotoko Iwanaga là một cô gái đã được "Yêu ma" tôn làm thần trí tuệ để đứng ra giải quyết những vẫn đề chúng gặp phải mỗi ngày. Cô dính tiếng sét ái tình với  Kuro Sakuragawa, người bị chúng "Yêu ma" khiếp sợ. Tổ hợp hai người khác thường từ đó ngày ngày giải quyết các sự vụ của "Yêu quái" tạo nêu những câu chuyện "Tình yêu x Truyền thuyết x Bí ẩn"! Liệu hai người họ sẽ gặp những chuyện gì, tình yêu của họ sẽ tới được đâu?', 'https://res.cloudinary.com/quang2002/image/upload/in_spectre_smjhfm', 1234, GETDATE())

INSERT INTO [FilmCategory] VALUES
(2, 3),
(2, 4),
(2, 5)

-- Lúc đó tôi đã chuyển sinh thành Slime OAD
INSERT INTO [Film]([Name], [Desc], [ImageURL], [Length], [ReleaseDate])
VALUES
(N'Lúc đó tôi đã chuyển sinh thành Slime OAD', N'Satoru Mikami vốn đang có cuộc sống bình lặng thì bị một gã côn đồ đâm chết trên phố. Anh kết thúc cuộc đời ở tuổi 37. Bỗng nhiên khi lấy lại ý thức, anh không thể nghe, cũng không thể nhìn thấy gì. Anh phát hiện ra mình đã chuyển sinh thành một con Slime. Anh bắt đầu tận hưởng cuộc đời mới của mình, tuy cũng chưa hài lòng lắm vì mình thuộc giống quái vật cấp thấp nhất. Tuy nhiên, cuộc chạm trán với một con quái vật cấp thảm họa, "Bạo Phong Long Veldora", đã khiến cuộc đời chú Slime bé nhỏ thay đổi hoàn toàn. Veldora đặt cho anh một cái tên mới là Rimuru. Và kể từ đây, Rimuru bắt đầu cuộc hành trình khám phá thế giới mới, bị cuốn vào trận chiến giữa tộc Yêu tinh và tộc Nha Lang, gặp gỡ thêm nhiều bạn bè và chạm trán với nhiều kẻ thù hùng mạnh. Huyền thoại về chú Slime mạnh nhất sắp sửa được mở ra.', 'https://res.cloudinary.com/quang2002/image/upload/72e24c93e7b0c336fa188eb1201565e1_vu42zf', 1234, GETDATE())

INSERT INTO [FilmCategory] VALUES
(3, 1),
(3, 6),
(3, 7),
(3, 8)

-- Shikimori-san của tôi không chỉ dễ thương
INSERT INTO [Film]([Name], [Desc], [ImageURL], [Length], [ReleaseDate])
VALUES
(N'Shikimori-san của tôi không chỉ dễ thương', N'Izumi là một nam sinh trung học bị xui xẻo bẩm sinh. Bạn gái của cậu là một cô bạn cùng lớp tên là Shikimori. Shikimori rất xinh đẹp, dễ thương và tràn đầy tình yêu, tuy nhiên mỗi khi Izumi gặp rắc rối, cô lại trở thành người bạn gái ngầu nhất trên đời! Cuộc sống thường ngày dễ thương và đầy những pha kỳ thú của Shikimori, Izumi và những người bạn sẽ bắt đầu tại đây.', 'https://i.ytimg.com/vi/jjd_anr5KwU/maxresdefault.jpg', 1234, GETDATE())

INSERT INTO [FilmCategory] VALUES
(4, 2),
(4, 4)

-- Đại ma vương mạnh nhất lịch sử chuyển sinh thành dân làng A
INSERT INTO [Film]([Name], [Desc], [ImageURL], [Length], [ReleaseDate])
VALUES
(N'Đại ma vương mạnh nhất lịch sử chuyển sinh thành dân làng A', N'Varvatos là Ma Vương mạnh nhất lịch sử đã được lưu danh trong thần thoại. Quá chán nản với kiếp làm vua dài đằng đẵng bởi sức mạnh đã khiến mà trở nên cô độc, cậu đã chuyển sinh thành một dân làng tên Ard Meteor ở 1000 năm sau. Tuy nhiên, tương lai lại là nơi mà nền văn minh ma pháp đã suy tàn. Ma pháp cũng đã suy yếu đi nhiều. Ard và người bạn thơ ấu Ireena đã nhập học tại học viện ma pháp. Dù cậu có muốn không tỏ ra là người đặc biệt, nhưng sức mạnh của cậu lại quá đỗi khác thường. Những lời khiêu chiến, những lời đồn đại cứ vậy mà tới không ngừng. Thế rồi, Ma Tộc từng một thời thống trị thế giới đã bắt đầu có hành động mờ ám... Liệu cựu Ma Vương có thể mang lại hòa bình và sống một cuộc đời bình dị chăng?', 'https://cdn.myanimelist.net/s/common/uploaded_files/1615037475-de748543fba24f4553c983172690afce.jpeg', 1234, GETDATE())

INSERT INTO [FilmCategory] VALUES
(5, 6),
(5, 8)

-- Chào mừng đến với lớp học đề cao thực lực
INSERT INTO [Film]([Name], [Desc], [ImageURL], [Length], [ReleaseDate])
VALUES (N'Chào mừng đến với lớp học đề cao thực lực', N'Truyện kể về trường cao trung Koudo Ikusei, một ngôi trường danh tiếng với cơ sở vật chất cực kì hiện đại, nơi 100% học sinh sẽ đỗ đại học hoặc tìm được việc làm. Học sinh nơi đây có thể hưởng mọi quyền lợi và tự do cá nhân. Việc chi tiêu trong trường được thanh toán bằng điểm tích lũy. Nhưng sự thật thì các quyền lợi này chỉ dành cho những học sinh cao cấp. Nhân vật chính là Ayanokoji Kiyotaka – thành viên của lớp D, là nơi các học sinh "yếu kém" bị đào thải, không ai coi trọng. Ayanokoji sẽ làm gì để tồn tại trong ngôi trường này?', 'https://preview.redd.it/s2frn7kz9ou31.jpg?width=640&crop=smart&auto=webp&s=40d98be1411e93d49ca528fe54d61424b4c062dc', 1234, GETDATE())

INSERT INTO [FilmCategory] VALUES
(6, 9)

--Mob Psycho 100
INSERT INTO [Film]([Name], [Desc], [ImageURL], [Length], [ReleaseDate])
VALUES (N'Mob Psycho 100', N'Shigeo "MOB" Kageyama là một học sinh trung học năm hai bình thường, muốn sống một đời bình dị.Tuy là một người dễ dàng mất hút trong đám đông, nhưng cậu lại có siêu năng lực bẩm sinh mạnh mẽ hơn người.Mob chỉ muốn có một tuổi thanh xuân yên bình nên đã luôn cố gắng kìm nén, nhưng bao trận chiến lại tới khiến cảm xúc của cậu bùng nổ.Những ngày thanh xuân trở nên thật hỗn loạn, tương lai nào sẽ đón đợi Mob?','https://i-amp.ex-cdn.com/mgn.vn/files/news/2021/10/23/mob-psycho-100-mua-3-duoc-an-dinh-voi-vi-tri-dao-dien-moi-031418.jpg', 1234, GETDATE())

INSERT INTO [FilmCategory] VALUES
(7, 1),
(7, 2), 
(7, 5)

-- Cạo râu xong, tôi nhặt gái về nhà
INSERT INTO [Film]([Name], [Desc], [ImageURL], [Length], [ReleaseDate])
VALUES (N'Cạo râu xong, tôi nhặt gái về nhà', N'Yoshida là một nhân viên văn phòng 26 tuổi, vừa bị crush suốt 5 năm trời từ chối. Trên đường mượn rượu giải sầu về, anh nhìn thấy một nữ sinh trung học đang ngồi bên xó đường. <br> - "Sao em lại ngồi đây?". <br> - "Nè... Em cho anh xơi đó. <br> Cho em ở nhà anh được không?"', 'https://otakukart.com/wp-content/uploads/2021/04/featured.png', 1234, GETDATE())

INSERT INTO [FilmCategory] VALUES
(8, 2),
(8, 4)

-- Cuộc Phiêu Lưu Kỳ Bí của JoJo
INSERT INTO [Film]([Name], [Desc], [ImageURL], [Length], [ReleaseDate])
VALUES (N'Cuộc Phiêu Lưu Kỳ Bí của JoJo', N'Năm 2001 tại thành phố Naples của Ý, Giorno Giovanna - con trai của DIO, nhưng là hậu duệ của Jonathan Joestar, có ước mơ trở thành Gangstar để loại bỏ những kẻ buôn ma túy cho trẻ em từ nội bộ bên trong.','https://wallpaperaccess.com/full/2671779.jpg', 1234, GETDATE())

INSERT INTO [FilmCategory] VALUES
(9, 1),
(9, 5),
(9, 8)

-- Re:Zero - Bắt đầu lại từ con số 0 tại thế giới khác
INSERT INTO [Film]([Name], [Desc], [ImageURL], [Length], [ReleaseDate])
VALUES (N'Re:Zero - Bắt đầu lại từ con số 0 tại thế giới khác', N'Câu chuyện kể về Natsuki Subaru, một chàng trai tuổi teen đã bỏ học làm NEET bỗng nhiên được triệu hồi đến một thế giới khác. Tại đây, cậu được ban cho sức mạnh ""Trở về từ cái chết"". Mỗi lần chết đi, cậu sẽ quay trở lại một mốc thời gian xác định nào đó. Điều đặc biệt là cậu không được phép tiết lộ với bất cứ ai về sức mạnh này.Trong một thế giới tàn khốc, nơi tính mạng của những người quan trọng với mình liên tục bị đe dọa, một mình gánh trên vai một trọng trách lớn lao, Natsuki Subaru bắt đầu cuộc hành trình của mình.', 'https://cdn.akamai.steamstatic.com/steam/apps/1277510/capsule_616x353.jpg?t=1611984622', 1234, GETDATE())

INSERT INTO [FilmCategory] VALUES
(10, 6),
(10, 7),
(10, 8)

-- Rooms
INSERT INTO [Room]([Name], [Rows], [Cols])
VALUES (N'Phòng Thường 1', 10, 15)

INSERT INTO [Room]([Name], [Rows], [Cols])
VALUES (N'Phòng Thường 2', 10, 15)

INSERT INTO [Room]([Name], [Rows], [Cols])
VALUES (N'Phòng Thường 3', 10, 15)

INSERT INTO [Room]([Name], [Rows], [Cols])
VALUES (N'Phòng VIP', 10, 10)

UPDATE [User]
SET [Role] = 2