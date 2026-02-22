namespace VD Website Builder.Models
{
    public class VisualElement
    {
        public string Tag { get; set; } = "p";
        public string Content { get; set; } = "";
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
