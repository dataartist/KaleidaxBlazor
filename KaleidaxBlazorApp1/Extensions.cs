namespace KaleidaxBlazorApp1
{
    public static class Extensions
    {
        public static string ToggleImage(this string image, bool forceOff = false)
        {
            return image.IndexOf("Selected") >= 0 || forceOff ? image.Replace("Selected", "") : image.Replace(".", "Selected.");
        }
    }
}