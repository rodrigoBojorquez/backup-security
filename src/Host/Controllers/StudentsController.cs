using ApplicationCore.DTOs.Students;
using ApplicationCore.Interfaces;
using Infraestructure.Persistence;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Layout.Properties;
using Microsoft.AspNetCore.Mvc;
using Document = iText.Layout.Document;

namespace Host.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentsController : ControllerBase
{
    private readonly IStudentService _studentService;
    private readonly ApplicationDbContext _context;

    public StudentsController(IStudentService studentService, ApplicationDbContext context)
    {
        _studentService = studentService;
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var students = await _studentService.ListStudents();
        return Ok(students);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var student = await _studentService.GetStudent(id);
        return Ok(student);
    }

    [HttpPost]
    public async Task<IActionResult> Create(StudentCreateDto request)
    {
        var student = await _studentService.CreateStudent(request);
        return Ok(student);
    }

    // /**
    //  * Crea el documento con los datos del estudiante
    //  */
    // [HttpGet("pdf/{id}")]
    // public async Task<IActionResult> GetStudentPdf(int id)
    // {
    //     var student = await _context.Students.FindAsync(id);
    //     if (student is null)
    //         return NotFound();
    //
    //
    //     try
    //     {
    //         // using (var memoryStream = new MemoryStream())
    //         // {
    //         //     PdfWriter pdfWriter = new PdfWriter(memoryStream);
    //         //     PdfDocument pdfDocument = new PdfDocument(pdfWriter);
    //         //     var document = new iText.Layout.Document(pdfDocument);
    //         //
    //         //     // Agregar contenido al PDF
    //         //     document.Add(new iText.Layout.Element.Paragraph($"ID: {student.Id}"));
    //         //     document.Add(new iText.Layout.Element.Paragraph($"Nombre: {student.Name ?? "N/A"}"));
    //         //     document.Add(new iText.Layout.Element.Paragraph($"Edad: {(student.LastName)}"));
    //         //     document.Add(new iText.Layout.Element.Paragraph($"Email: {student.Email ?? "N/A"}"));
    //         //
    //         //     document.Close();
    //         //     pdfDocument.Close();
    //         //     pdfWriter.Close(); 
    //         //
    //         //     // Asegurarse de resetear el stream
    //         //     memoryStream.Flush();
    //         //     memoryStream.Position = 0;
    //         //
    //         //     return File(memoryStream.ToArray(), "application/pdf", $"Estudiante_{student.Id}.pdf");
    //
    //         PdfWriter writer = new PdfWriter("./Pdf.pdf");
    //         PdfDocument pdf = new PdfDocument(writer);
    //         Document document = new Document(pdf);
    //         Paragraph header = new Paragraph("Estudiante")
    //             .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER).SetFontSize(20);
    //
    //         document.Add(header);
    //         document.Close();
    //
    //         return Ok();
    //     }
    //     catch (Exception ex)
    //     {
    //         return StatusCode(500,
    //             new { Messages = new[] { ex.Message }, Source = ex.Source, Exception = ex.GetType().Name });
    //     }
    // }

    [HttpGet("pdf/{id}")]
    public async Task<IActionResult> GetStudentPdf(int id)
    {
        var student = await _context.Students.FindAsync(id);
        if (student is null)
            return NotFound();

        // Crear un archivo temporal
        // string tempFilePath = Path.GetTempFileName();
        //
        // using (var writer = new PdfWriter(tempFilePath))
        // {
        //     PdfDocument pdf = new PdfDocument(writer);
        //     Document document = new Document(pdf);
        //
        //     // Encabezado
        //     Paragraph header = new Paragraph("Estudiante")
        //         .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
        //         .SetFontSize(20);
        //     document.Add(header);
        //
        //     // Datos del estudiante
        //     document.Add(new Paragraph($"ID: {student.Id}"));
        //     document.Add(new Paragraph($"Nombre: {student.Name ?? "N/A"}"));
        //     document.Add(new Paragraph($"Apellido: {student.LastName ?? "N/A"}"));
        //     document.Add(new Paragraph($"Email: {student.Email ?? "N/A"}"));
        //
        //     document.Close();
        // }
        //
        // // Leer el archivo y devolverlo como respuesta
        // var pdfBytes = System.IO.File.ReadAllBytes(tempFilePath);
        // System.IO.File.Delete(tempFilePath); // Limpiar el archivo temporal
        //
        // return File(pdfBytes, "application/pdf", $"Estudiante_{student.Id}.pdf");

        PdfWriter writer = new PdfWriter("./demo.pdf");
        PdfDocument pdf = new PdfDocument(writer);
        Document document = new Document(pdf);
        Paragraph header = new Paragraph("HEADER")
            .SetTextAlignment(TextAlignment.CENTER)
            .SetFontSize(20);

        document.Add(header);
        document.Close();

        return Ok();    
    }


    [HttpPut]
    public async Task<IActionResult> Update(StudentUpdateDto request)
    {
        var student = await _studentService.UpdateStudent(request);
        return Ok(student);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _studentService.DeleteStudent(id);
        return Ok();
    }
}