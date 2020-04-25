using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_CodeFirst_School.Migrations
{
    public partial class MIgration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Area",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Career",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Career", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Diploma",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diploma", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lapse",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lapse", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: true),
                    Nif = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(maxLength: 15, nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    Phone = table.Column<string>(maxLength: 20, nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Address = table.Column<string>(maxLength: 500, nullable: true),
                    Cp = table.Column<string>(maxLength: 5, nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    StudentId = table.Column<int>(nullable: true),
                    TeacherId = table.Column<int>(nullable: true),
                    TutorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Section",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<int>(nullable: false),
                    Grade = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Section", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    AreaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Course_Area_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Area",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Average = table.Column<double>(nullable: false),
                    EnrollmentDay = table.Column<DateTime>(nullable: false),
                    PersonId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Student_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Salary = table.Column<double>(nullable: false),
                    PersonId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teacher_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tutor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Occupation = table.Column<string>(nullable: true),
                    PersonId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tutor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tutor_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentDiploma",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(nullable: false),
                    DiplomaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentDiploma", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentDiploma_Diploma_DiplomaId",
                        column: x => x.DiplomaId,
                        principalTable: "Diploma",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentDiploma_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Enrollment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Grade = table.Column<double>(nullable: false),
                    StudentId = table.Column<int>(nullable: true),
                    TeacherId = table.Column<int>(nullable: true),
                    CourseId = table.Column<int>(nullable: true),
                    LapseId = table.Column<int>(nullable: true),
                    SectionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Enrollment_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Enrollment_Lapse_LapseId",
                        column: x => x.LapseId,
                        principalTable: "Lapse",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Enrollment_Section_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Section",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Enrollment_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Enrollment_Teacher_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teacher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TeacherCareer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherId = table.Column<int>(nullable: false),
                    CareerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherCareer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeacherCareer_Career_CareerId",
                        column: x => x.CareerId,
                        principalTable: "Career",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeacherCareer_Teacher_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teacher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TutorStudent",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(nullable: false),
                    TutorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TutorStudent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TutorStudent_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TutorStudent_Tutor_TutorId",
                        column: x => x.TutorId,
                        principalTable: "Tutor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Course_AreaId",
                table: "Course",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollment_CourseId",
                table: "Enrollment",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollment_LapseId",
                table: "Enrollment",
                column: "LapseId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollment_SectionId",
                table: "Enrollment",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollment_StudentId",
                table: "Enrollment",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollment_TeacherId",
                table: "Enrollment",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_PersonId",
                table: "Student",
                column: "PersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StudentDiploma_DiplomaId",
                table: "StudentDiploma",
                column: "DiplomaId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentDiploma_StudentId",
                table: "StudentDiploma",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_PersonId",
                table: "Teacher",
                column: "PersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TeacherCareer_CareerId",
                table: "TeacherCareer",
                column: "CareerId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherCareer_TeacherId",
                table: "TeacherCareer",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Tutor_PersonId",
                table: "Tutor",
                column: "PersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TutorStudent_StudentId",
                table: "TutorStudent",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_TutorStudent_TutorId",
                table: "TutorStudent",
                column: "TutorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enrollment");

            migrationBuilder.DropTable(
                name: "StudentDiploma");

            migrationBuilder.DropTable(
                name: "TeacherCareer");

            migrationBuilder.DropTable(
                name: "TutorStudent");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Lapse");

            migrationBuilder.DropTable(
                name: "Section");

            migrationBuilder.DropTable(
                name: "Diploma");

            migrationBuilder.DropTable(
                name: "Career");

            migrationBuilder.DropTable(
                name: "Teacher");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Tutor");

            migrationBuilder.DropTable(
                name: "Area");

            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}
