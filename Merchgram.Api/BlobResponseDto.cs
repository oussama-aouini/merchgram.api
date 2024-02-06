using Merchgram.Api;

namespace service.files
{
    public class BlobResponseDto
    {
        public BlobResponseDto()
        {
            Blob = new BlobDto();
        }

        public string? Status { get; set; }
        public bool Error { get; set; }
        public BlobDto Blob { get; set; }
    }
}
