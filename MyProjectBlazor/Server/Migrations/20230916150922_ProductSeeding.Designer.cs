﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyProjectBlazor.Server.Data;

#nullable disable

namespace MyProjectBlazor.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230916150922_ProductSeeding")]
    partial class ProductSeeding
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MyProjectBlazor.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Мишель Пэнсон попадает в рай. Он оказывается на «страшном суде», который ведут три архангела. Самым страшным испытанием для человека считается последующая реинкарнация. От реинкарнации его спасает ангел-хранитель Эмиль Золя. За Мишелем встаёт выбор: стать ангелом или проповедником на земле. Выбор падает на ангела. Ему открывается путь в мир ангелов, в котором его ангелом-наставником становится Эдмонд Уэллс. Каждому ангелу даётся три «клиента». Это название возникает из-за того, что ангелы предстают в качестве адвокатов этих душ на страшном суде. Выбор своих клиентов стоит за ангелами, и Мишель выбирает три семьи, которые показаны в «озере зачатия». Одна семья оказывается богатой — из Америки, другая средней — из Франции и очень бедная семья — из России. Эдмонд Уэллс повествует о том, что у души есть три основных показателя: 25 % происходящих с человеком событий определяются наследственностью, 25 % — кармой, и ещё 50 % остаются для свободного выбора. В то же время Мишель Пэнсон и Рауль Разорбак ищут мир «седьмых», которые находятся выше по уровню развития, чем ангелы. Рауль предполагает, что это боги.",
                            ImgUrl = "https://upload.wikimedia.org/wikipedia/ru/7/7a/Empire_des_anges.jpg",
                            Price = 9.99m,
                            Title = "Империя ангеловss"
                        },
                        new
                        {
                            Id = 2,
                            Description = "В романе «Американские боги» смешиваются элементы американской культуры, фэнтези и различные переплетения древней и современной мифологии, центрирующиеся на образе загадочного и молчаливого протагониста по имени Тень (Shadow). В романе заметную роль играют мифологические персонажи: Один, Локи, Чернобог (и сёстры Зори/Зари), норны, Ананси, Белая Богиня, отождествляемая с Иштар и Эостерой, Кали, Тот, Анубис, Гор и Бастет. Кроме того, в событиях книги участвуют и персонажи из мифов реального мира, включая нескольких героев комиксов «Песочный человек». Изданная в 2001 году, уже в 2002 году книга получила премию Хьюго за лучший роман, премию Небьюла за лучший роман и премию имени Брэма Стокера. Также в 2002 роман был номинирован на премию Британской ассоциации научных фантастов",
                            ImgUrl = "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg",
                            Price = 5.99m,
                            Title = "Американские боги"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Действие романа разворачивается в Лондоне далёкого будущего (в 26 веке нашей эры, а именно в 2540 году[4]. Люди на всей Земле живут в едином «прогрессирующем» государстве, где возведены в основу следующие ценности: беззаботность (работа не принята во внимание по причине естественного желания ей заниматься), сексуальная свобода и потребление. Отсчитывается новое летоисчисление — Эра Т — с появления Форда Т. Потребление возведено в культ, символом потребительского бога выступает Генри Форд, а вместо крестного знамения люди «осеняют себя знаком Т».",
                            ImgUrl = "https://upload.wikimedia.org/wikipedia/ru/6/62/BraveNewWorld_FirstEdition.jpg",
                            Price = 1.99m,
                            Title = "О дивный новый мир"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}