﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Ymagi.Data;

namespace Ymagi.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200518051053_Roles")]
    partial class Roles
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Ymagi.Models.Entrega", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data");

                    b.Property<int>("MembroId");

                    b.Property<int>("ProdutoId");

                    b.Property<double>("Quantidade");

                    b.Property<int>("Status");

                    b.Property<int>("UsuarioId");

                    b.Property<double>("ValorTotal");

                    b.Property<double>("ValorUnit");

                    b.HasKey("Id");

                    b.HasIndex("MembroId");

                    b.HasIndex("ProdutoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Entrega");
                });

            modelBuilder.Entity("Ymagi.Models.Fornecedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro");

                    b.Property<string>("Cep");

                    b.Property<string>("Cidade");

                    b.Property<string>("Cnpj");

                    b.Property<string>("Complemento");

                    b.Property<string>("Contato");

                    b.Property<string>("Email");

                    b.Property<string>("Endereço");

                    b.Property<string>("Estado");

                    b.Property<string>("InscEstadual");

                    b.Property<int>("MembroId");

                    b.Property<string>("NomeFantasia");

                    b.Property<string>("Numero");

                    b.Property<string>("RazaoSocial");

                    b.Property<string>("Telefone");

                    b.HasKey("Id");

                    b.HasIndex("MembroId");

                    b.ToTable("Fornecedor");
                });

            modelBuilder.Entity("Ymagi.Models.Membro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro");

                    b.Property<string>("Cep");

                    b.Property<string>("Cidade");

                    b.Property<string>("Complemento");

                    b.Property<string>("Cpf");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<string>("Email");

                    b.Property<string>("Endereco");

                    b.Property<string>("Estado");

                    b.Property<string>("EstadoCivil");

                    b.Property<string>("Filhos");

                    b.Property<DateTime>("Nascimento");

                    b.Property<string>("Nome");

                    b.Property<string>("Numero");

                    b.Property<int>("OscId");

                    b.Property<string>("Rg");

                    b.Property<string>("Sexo");

                    b.Property<string>("Telefone");

                    b.HasKey("Id");

                    b.HasIndex("OscId");

                    b.ToTable("Membro");
                });

            modelBuilder.Entity("Ymagi.Models.Osc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro");

                    b.Property<string>("Cep");

                    b.Property<string>("Cidade");

                    b.Property<string>("Cnpj");

                    b.Property<string>("Complemento");

                    b.Property<string>("Contato");

                    b.Property<DateTime>("Data");

                    b.Property<string>("Email");

                    b.Property<string>("Endereço");

                    b.Property<string>("Estado");

                    b.Property<string>("Nome");

                    b.Property<string>("Numero");

                    b.Property<string>("Observacao");

                    b.Property<string>("RazaoSocial");

                    b.Property<string>("Responsavel");

                    b.Property<string>("Telefone");

                    b.HasKey("Id");

                    b.ToTable("Osc");
                });

            modelBuilder.Entity("Ymagi.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<int>("FornecedorId");

                    b.Property<int>("MembroId");

                    b.Property<string>("Nome");

                    b.Property<double>("Quantidade");

                    b.Property<string>("Unidade");

                    b.Property<int>("UsuarioId");

                    b.Property<double>("ValorTotal");

                    b.Property<double>("ValorUnit");

                    b.HasKey("Id");

                    b.HasIndex("FornecedorId");

                    b.HasIndex("MembroId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("Ymagi.Models.Recebimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data");

                    b.Property<int>("FornecedorId");

                    b.Property<int>("MembroId");

                    b.Property<int>("ProdutoId");

                    b.Property<double>("Quantidade");

                    b.Property<int>("Status");

                    b.Property<int>("UsuarioId");

                    b.Property<double>("ValorTotal");

                    b.Property<double>("ValorUnit");

                    b.HasKey("Id");

                    b.HasIndex("FornecedorId");

                    b.HasIndex("MembroId");

                    b.HasIndex("ProdutoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Recebimento");
                });

            modelBuilder.Entity("Ymagi.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro");

                    b.Property<string>("Cep");

                    b.Property<string>("Cidade");

                    b.Property<string>("Complemento");

                    b.Property<string>("Cpf");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<string>("Email");

                    b.Property<string>("Endereco");

                    b.Property<string>("Estado");

                    b.Property<string>("EstadoCivil");

                    b.Property<string>("Filhos");

                    b.Property<int>("MembroId");

                    b.Property<DateTime>("Nascimento");

                    b.Property<string>("Nome");

                    b.Property<string>("Numero");

                    b.Property<string>("Rg");

                    b.Property<string>("Sexo");

                    b.Property<string>("Telefone");

                    b.HasKey("Id");

                    b.HasIndex("MembroId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Ymagi.Models.ViewModels.ProjectRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleName");

                    b.HasKey("Id");

                    b.ToTable("ProjectRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ymagi.Models.Entrega", b =>
                {
                    b.HasOne("Ymagi.Models.Membro", "Membro")
                        .WithMany("Entregas")
                        .HasForeignKey("MembroId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Ymagi.Models.Produto", "Produto")
                        .WithMany("Entregas")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Ymagi.Models.Usuario", "Usuario")
                        .WithMany("Entregas")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ymagi.Models.Fornecedor", b =>
                {
                    b.HasOne("Ymagi.Models.Membro", "Membro")
                        .WithMany("Fornecedores")
                        .HasForeignKey("MembroId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ymagi.Models.Membro", b =>
                {
                    b.HasOne("Ymagi.Models.Osc", "Osc")
                        .WithMany("Membros")
                        .HasForeignKey("OscId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ymagi.Models.Produto", b =>
                {
                    b.HasOne("Ymagi.Models.Fornecedor", "Fornecedor")
                        .WithMany("Produtos")
                        .HasForeignKey("FornecedorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Ymagi.Models.Membro", "Membro")
                        .WithMany("Produtos")
                        .HasForeignKey("MembroId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Ymagi.Models.Usuario", "Usuario")
                        .WithMany("Produtos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ymagi.Models.Recebimento", b =>
                {
                    b.HasOne("Ymagi.Models.Fornecedor", "Fornecedor")
                        .WithMany("Recebimentos")
                        .HasForeignKey("FornecedorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Ymagi.Models.Membro", "Membro")
                        .WithMany("Recebimentos")
                        .HasForeignKey("MembroId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Ymagi.Models.Produto", "Produto")
                        .WithMany("Recebimentos")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Ymagi.Models.Usuario", "Usuario")
                        .WithMany("Recebimentos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ymagi.Models.Usuario", b =>
                {
                    b.HasOne("Ymagi.Models.Membro", "Membro")
                        .WithMany("Usuarios")
                        .HasForeignKey("MembroId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
