namespace Carto.IO
{
    /// <summary>
    /// The peer-mod request object passed to <see cref="IO.Export(ExportRequest)"/>.
    /// （傳遞給 <see cref="IO.Export(ExportRequest)"/> 的對等模組請求物件。）<br/>
    /// Allows downstream mods to drive Carto's export pipeline without reading
    /// the user's <see cref="Instance.Settings"/> or surfacing UI side effects.
    /// （讓下游模組得以驅動 Carto 的輸出流程，而不需讀取使用者設定或觸發 UI 效果。）
    /// </summary>
    public class ExportRequest
    {
        /// <summary>
        /// The target file format. Honored strictly — no silent fallback.
        /// （目標檔案格式，嚴格遵守，不進行預設回退。）
        /// </summary>
        public FileFormat Format { get; set; } = FileFormat.GeoJSON;

        /// <summary>
        /// Absolute path to the output directory. Created if missing.
        /// （輸出目錄的絕對路徑。若不存在則會建立。）
        /// </summary>
        public string OutputDirectory { get; set; }

        /// <summary>
        /// Bitmask of layers to export.
        /// （即將輸出的圖層位元遮罩。）
        /// </summary>
        public Feature Features { get; set; } = Feature.None;

        /// <summary>
        /// Bitmask of Carto systems to run.
        /// （參與輸出的 Carto 系統位元遮罩。）
        /// </summary>
        public System Systems { get; set; } = System.Unknown;
    }
}
