using System;
using System.Collections.Generic;
using System.Text;
using YoutubeExplode;
using System.Threading.Tasks;
using YoutubeExplode.Converter;

namespace Modul18
{
    class YoutubeReceiver
    {

        YoutubeClient youtube;

        public YoutubeReceiver()
        {
            youtube = new YoutubeClient();
        }

        public async Task OperationInfo(string UrlVideo)
        {

            var info = await youtube.Videos.GetAsync(UrlVideo);
            Console.WriteLine("Информация о видео " + UrlVideo);
            Console.WriteLine($"Название  видео  -  {info.Title}");
            Console.WriteLine($"Описание видео -  {info.Description}\n");

        }

        public async Task OperationDownload(string UrlVideo)
        {
            Console.WriteLine("Видео в данный момент загружается.");

            await youtube.Videos.DownloadAsync( UrlVideo,  "video.mp4",
                builder => builder.SetPreset(ConversionPreset.UltraFast));

            Console.WriteLine("Загрузка завершена! \n Наименование скаченного файла - video.mp4");
            Console.ReadKey();

        }
    }
}
