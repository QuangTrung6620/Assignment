using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T1809E_UWP_DAPI.Models;

namespace T1809E_UWP_DAPI.Services
{
    public class SongService
    {
        public ObservableCollection<Song> LoadSong()
        {
            ObservableCollection<Song> list = new ObservableCollection<Song>();
            list.Add(new Song()
            {
                SongName = "Cánh Hoa Tổn Thương",
                Link = "https://c1-ex-swe.nixcdn.com/NhacCuaTui993/CanhHoaTonThuong-HoangYenChibi-6198745.mp3",
                Views = 13109482,
                Description = "Cánh Hoa Tổn Thương",
                Thumbnail = "https://sohanews.sohacdn.com/thumb_w/660/2019/12/1/img2-15751648821851354482571-crop-15751648893251453788890.jpg"
            });
            list.Add(new Song()
            {
                SongName = "Liệu Giờ",
                Link = "https://c1-ex-swe.nixcdn.com/NhacCuaTui987/LieuGio-2TVan-5943444.mp3",
                Views = 5245345,
                Description = "Liệu Giờ",
                Thumbnail = "https://v-phinf.pstatic.net/20190507_268/1557217554946lRNMD_JPEG/upload_Lieu%2Bgio_2T.jpg"
            });
            list.Add(new Song()
            {
                SongName = "Từng Yêu",
                Link = "https://c1-ex-swe.nixcdn.com/NhacCuaTui983/TungYeu-PhanDuyAnh-5989256.mp3",
                Views = 43431200,
                Description = "Từng Yêu",
                Thumbnail = "https://i.ytimg.com/vi/pENMETTGamA/maxresdefault.jpg"
            });
            list.Add(new Song()
            {
                SongName = "Sáng Mắt Chưa",
                Link = "https://c1-ex-swe.nixcdn.com/NhacCuaTui987/SangMatChua-TrucNhan-6042213.mp3",
                Views = 43431200,
                Description = "Sáng Mắt Chưa",
                Thumbnail = "https://nguoi-noi-tieng.com/images/post/tieu-su-ca-si-truc-nhan-370330.jpg"
            });
            list.Add(new Song()
            {
                SongName = "Trách Ai Vô Tình",
                Link = "https://c1-ex-swe.nixcdn.com/NhacCuaTui935/TrachAiVoTinh-HienThuc-4748994.mp3",
                Views = 43431200,
                Description = "Trách Ai Vô Tình-Hiền Thục",
                Thumbnail = "https://nguoi-noi-tieng.com/images/post/tieu-su-ca-si-hien-thuc-136683.jpg"
            });
            list.Add(new Song()
            {
                SongName = "Hà Lan (Mắt Biếc OST)",
                Link = "https://c1-ex-swe.nixcdn.com/NhacCuaTui994/HaLanMatBiecOST-PhanManhQuynh-6199175.mp3",
                Views = 43431200,
                Description = "Phan Mạnh Quỳnh",
                Thumbnail = "https://photo-resize-zmp3.zadn.vn/w240_r1x1_jpeg/avatars/0/2/9/a/029a1e473c230215ee5d272eb89cd571.jpg"
            });
            list.Add(new Song()
            {
                SongName = "Vì Một Người Ra Đi",
                Link = "https://c1-ex-swe.nixcdn.com/Singer_Audio5/ViMotNguoiRaDi-UngHoangPhuc-2806067.mp3",
                Views = 43431200,
                Description = "Ưng Hoàng Phúc",
                Thumbnail = "https://tieusunguoinoitieng.com/wp-content/uploads/2019/09/tieu-su-ung-hoang-phuc-3371.jpg"
            });
            return list;
        }
    }
}
