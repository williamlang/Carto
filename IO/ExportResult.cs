namespace Carto.IO
{
    /// <summary>
    /// The result returned by <see cref="IO.Export(ExportRequest)"/>.
    /// （<see cref="IO.Export(ExportRequest)"/> 的回傳結果。）<br/>
    /// Errors are reported via <see cref="ErrorMessage"/> rather than modal dialogs.
    /// （錯誤透過 <see cref="ErrorMessage"/> 回報，而不會彈出對話框。）
    /// </summary>
    public class ExportResult
    {
        /// <summary>
        /// Whether the export completed successfully.
        /// （輸出是否成功完成。）
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Absolute paths of files written during the export.
        /// （輸出過程中寫入的檔案絕對路徑。）<br/>
        /// Empty array when nothing was written (including on failure).
        /// （未寫入任何檔案時為空陣列（含失敗的情況）。）
        /// </summary>
        public string[] FilesWritten { get; set; } = new string[0];

        /// <summary>
        /// Diagnostic message on failure. Null when <see cref="Success"/> is true.
        /// （失敗時的診斷訊息。<see cref="Success"/> 為真值時為 null。）
        /// </summary>
        public string ErrorMessage { get; set; }
    }
}
