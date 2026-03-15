namespace VDWebsiteBuilder.Models
{
    public class VisualElement
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Tag { get; set; } = "p";
        public string Content { get; set; } = "";
        public string FontSize { get; set; } = "18";
        public string TextAlign { get; set; } = "left";
        public string Color { get; set; } = "#000000";
        public Microsoft.AspNetCore.Components.MarkupString GetColoredHtml()
        {
            string tagColor = "#569cd6";
            string attrColor = "#9cdcfe";
            string valColor = "#ce9178";
            if (Tag == "img")
            {
                return (Microsoft.AspNetCore.Components.MarkupString)$@"<span style='color:{tagColor}'>&lt;img</span> <span style='color:{attrColor}'>src</span>=<span style='color:{valColor}'>""{Content}""</span> <span style='color:{attrColor}'>style</span>=<span style='color:{valColor}'>""width:{FontSize}px;""</span><span style='color:{tagColor}'>&gt;</span>";
            }
            return (Microsoft.AspNetCore.Components.MarkupString)$@"<span style='color:{tagColor}'>&lt;{Tag}</span> <span style='color:{attrColor}'>style</span>=<span style='color:{valColor}'>""color:{Color}; font-size:{FontSize}px; text-align:{TextAlign};""</span><span style='color:{tagColor}'>&gt;</span>{Content}<span style='color:{tagColor}'>&lt;/{Tag}&gt;</span>";
        }
        public string GetHtmlCode() => $"<{Tag} style=\"color: {Color};\">{Content}</{Tag}>";
        public string GetExplanation() => Tag switch {
            "h1" => "Заголовок <h1> — самый важный текст на странице.",
            "p" => "Абзац <p> используется для основного текста.",
            "button" => "Кнопка <button> делает страницу интерактивной.",
            _ => "Это стандартный HTML-элемент."
        };
        public List<(string Key, string Value, string Desc)> GetPropertyBreakdown()
        {
            var list = new List<(string, string, string)>();
            list.Add(("<" + Tag + ">", "Тег", "Определяет тип элемента (заголовок, абзац или фото)."));
            list.Add(("color", Color, "Цвет текста: задает оттенок шрифта."));
            list.Add(("font-size", FontSize + "px", "Размер: определяет высоту символов в пикселях."));
            list.Add(("text-align", TextAlign, "Выравнивание: положение текста в блоке (слева, центр, справа)."));
            return list;
        }
    }
}