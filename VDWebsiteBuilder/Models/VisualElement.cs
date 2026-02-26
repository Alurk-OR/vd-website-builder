namespace VDWebsiteBuilder.Models
{
    public class VisualElement
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Tag { get; set; } = "p";
        public string Content { get; set; } = "";
        public string FontSize { get; set; } = "18";

        public string Color { get; set; } = "#000000";
        public string GetHtmlCode() => $"<{Tag} style=\"color: {Color};\">{Content}</{Tag}>";
        public string GetExplanation() => Tag switch {
            "h1" => "Заголовок <h1> — самый важный текст на странице.",
            "p" => "Абзац <p> используется для основного текста.",
            "button" => "Кнопка <button> делает страницу интерактивной.",
            _ => "Это стандартный HTML-элемент."
        };
    }
}
