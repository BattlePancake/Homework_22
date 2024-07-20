//using Homework_22.Pages;

//namespace Homework_22.Tests
//{
//    internal class UploadPageTest : BaseTest
//    {

//        [Test]
//        [Description("Upload file test")]
//        public void UploadPageTest1()
//        {
//            UploadPage.UploadFile();
//            var result = UploadPage.IsFileUploaded();
//            Assert.That(result, Is.True);
//        }

//        [Test]
//        [Description("Download file test")]
//        public void UploadPageTest2()
//        {
//            UploadPage.DeleteFile();

//            UploadPage.DownloadFile();
//            UploadPage.Refresh();

//            var result = UploadPage.IsFileDownloaded();
//            Assert.That(result, Is.True);
//        }
//    }
//}
