﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StarNote.DataAccess;

namespace StarNote.Migrations
{
    [DbContext(typeof(Starnoteapicontext))]
    partial class StarnoteapicontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("StarNote.Models.DBModels.ADMenus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("Createdtime")
                        .HasColumnType("datetime");

                    b.Property<string>("Createduser")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Deletetime")
                        .HasColumnType("datetime");

                    b.Property<string>("Guid")
                        .HasColumnType("text");

                    b.Property<bool>("Isactive")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("Modifiedtime")
                        .HasColumnType("datetime");

                    b.Property<string>("Modifieduser")
                        .HasColumnType("text");

                    b.Property<string>("Parametername")
                        .HasColumnType("text");

                    b.Property<int>("Vieworder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ADMenus");
                });

            modelBuilder.Entity("StarNote.Models.DBModels.ADOrderproduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("Baseprice")
                        .HasColumnType("double");

                    b.Property<DateTime?>("Createdtime")
                        .HasColumnType("datetime");

                    b.Property<string>("Createduser")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Deletetime")
                        .HasColumnType("datetime");

                    b.Property<string>("Groupname")
                        .HasColumnType("text");

                    b.Property<string>("Guid")
                        .HasColumnType("text");

                    b.Property<bool>("Isactive")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("Modifiedtime")
                        .HasColumnType("datetime");

                    b.Property<string>("Modifieduser")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<double>("Totalprice")
                        .HasColumnType("double");

                    b.Property<string>("Unit")
                        .HasColumnType("text");

                    b.Property<int>("Vieworder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ADOrderproduct");
                });

            modelBuilder.Entity("StarNote.Models.DBModels.ADProductbase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("Amount")
                        .HasColumnType("double");

                    b.Property<string>("Productguid")
                        .HasColumnType("text");

                    b.Property<string>("Stockguid")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("AdDProductbase");
                });

            modelBuilder.Entity("StarNote.Models.DBModels.ADProductoption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("Amount")
                        .HasColumnType("double");

                    b.Property<double>("Baseprice")
                        .HasColumnType("double");

                    b.Property<string>("Optionproductguid")
                        .HasColumnType("text");

                    b.Property<string>("Productguid")
                        .HasColumnType("text");

                    b.Property<double>("Totalprice")
                        .HasColumnType("double");

                    b.Property<string>("Unit")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ADProductoption");
                });

            modelBuilder.Entity("StarNote.Models.DBModels.GLCase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("Createdtime")
                        .HasColumnType("datetime");

                    b.Property<string>("Createduser")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Deletetime")
                        .HasColumnType("datetime");

                    b.Property<string>("Guid")
                        .HasColumnType("text");

                    b.Property<bool>("Isactive")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("Modifiedtime")
                        .HasColumnType("datetime");

                    b.Property<string>("Modifieduser")
                        .HasColumnType("text");

                    b.Property<string>("Parametergroup")
                        .HasColumnType("text");

                    b.Property<string>("Parametername")
                        .HasColumnType("text");

                    b.Property<int>("Vieworder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("GLCase");
                });

            modelBuilder.Entity("StarNote.Models.DBModels.GLCostumertype", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("Createdtime")
                        .HasColumnType("datetime");

                    b.Property<string>("Createduser")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Deletetime")
                        .HasColumnType("datetime");

                    b.Property<string>("Guid")
                        .HasColumnType("text");

                    b.Property<bool>("Isactive")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("Modifiedtime")
                        .HasColumnType("datetime");

                    b.Property<string>("Modifieduser")
                        .HasColumnType("text");

                    b.Property<string>("Parametergroup")
                        .HasColumnType("text");

                    b.Property<string>("Parametername")
                        .HasColumnType("text");

                    b.Property<int>("Vieworder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("GLCostumertype");
                });

            modelBuilder.Entity("StarNote.Models.DBModels.GLLisance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Durum")
                        .HasColumnType("text");

                    b.Property<string>("LisansAdı")
                        .HasColumnType("text");

                    b.Property<string>("Sonaermetarihi")
                        .HasColumnType("text");

                    b.Property<string>("Ürünanahtarı")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("GLLisance");
                });

            modelBuilder.Entity("StarNote.Models.DBModels.GLNote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("Createdtime")
                        .HasColumnType("datetime");

                    b.Property<string>("Createduser")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Deletetime")
                        .HasColumnType("datetime");

                    b.Property<string>("Guid")
                        .HasColumnType("text");

                    b.Property<bool>("Isactive")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("Modifiedtime")
                        .HasColumnType("datetime");

                    b.Property<string>("Modifieduser")
                        .HasColumnType("text");

                    b.Property<string>("Parametergroup")
                        .HasColumnType("text");

                    b.Property<string>("Parametername")
                        .HasColumnType("text");

                    b.Property<int>("Vieworder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("GLNote");
                });

            modelBuilder.Entity("StarNote.Models.DBModels.GLPaymenttype", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("Createdtime")
                        .HasColumnType("datetime");

                    b.Property<string>("Createduser")
                        .HasColumnType("text");

                    b.Property<double>("Dailygoal")
                        .HasColumnType("double");

                    b.Property<DateTime?>("Deletetime")
                        .HasColumnType("datetime");

                    b.Property<string>("Guid")
                        .HasColumnType("text");

                    b.Property<bool>("Isactive")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("Modifiedtime")
                        .HasColumnType("datetime");

                    b.Property<string>("Modifieduser")
                        .HasColumnType("text");

                    b.Property<string>("Parametername")
                        .HasColumnType("text");

                    b.Property<string>("Parametersmallname")
                        .HasColumnType("text");

                    b.Property<int>("Vieworder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("GLPaymenttype");
                });

            modelBuilder.Entity("StarNote.Models.DBModels.GLProcesstype", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("Createdtime")
                        .HasColumnType("datetime");

                    b.Property<string>("Createduser")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Deletetime")
                        .HasColumnType("datetime");

                    b.Property<string>("Guid")
                        .HasColumnType("text");

                    b.Property<bool>("Isactive")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("Modifiedtime")
                        .HasColumnType("datetime");

                    b.Property<string>("Modifieduser")
                        .HasColumnType("text");

                    b.Property<string>("Parametername")
                        .HasColumnType("text");

                    b.Property<int>("Stockmovementvalue")
                        .HasColumnType("int");

                    b.Property<int>("Vieworder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("GLProcesstype");
                });

            modelBuilder.Entity("StarNote.Models.DBModels.GLProducttype", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("Createdtime")
                        .HasColumnType("datetime");

                    b.Property<string>("Createduser")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Deletetime")
                        .HasColumnType("datetime");

                    b.Property<string>("Guid")
                        .HasColumnType("text");

                    b.Property<bool>("Isactive")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("Modifiedtime")
                        .HasColumnType("datetime");

                    b.Property<string>("Modifieduser")
                        .HasColumnType("text");

                    b.Property<string>("Parametergroup")
                        .HasColumnType("text");

                    b.Property<string>("Parametername")
                        .HasColumnType("text");

                    b.Property<int>("Vieworder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("GLProducttype");
                });

            modelBuilder.Entity("StarNote.Models.DBModels.GLReminding", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("Createdtime")
                        .HasColumnType("datetime");

                    b.Property<string>("Createduser")
                        .HasColumnType("text");

                    b.Property<string>("Cycleper")
                        .HasColumnType("text");

                    b.Property<string>("Cycletype")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Deletetime")
                        .HasColumnType("datetime");

                    b.Property<string>("Guid")
                        .HasColumnType("text");

                    b.Property<bool>("Isactive")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Message")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Modifiedtime")
                        .HasColumnType("datetime");

                    b.Property<string>("Modifieduser")
                        .HasColumnType("text");

                    b.Property<string>("Remindingtype")
                        .HasColumnType("text");

                    b.Property<string>("Reporttype")
                        .HasColumnType("text");

                    b.Property<string>("Users")
                        .HasColumnType("text");

                    b.Property<int>("Vieworder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("GLReminding");
                });

            modelBuilder.Entity("StarNote.Models.DBModels.GLRoles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("Createdtime")
                        .HasColumnType("datetime");

                    b.Property<string>("Createduser")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Deletetime")
                        .HasColumnType("datetime");

                    b.Property<string>("Guid")
                        .HasColumnType("text");

                    b.Property<bool>("Isactive")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("Modifiedtime")
                        .HasColumnType("datetime");

                    b.Property<string>("Modifieduser")
                        .HasColumnType("text");

                    b.Property<string>("Rolename")
                        .HasColumnType("text");

                    b.Property<string>("Rolevalue")
                        .HasColumnType("text");

                    b.Property<int>("Vieworder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("GLRoles");
                });

            modelBuilder.Entity("StarNote.Models.DBModels.GLSalesman", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("Createdtime")
                        .HasColumnType("datetime");

                    b.Property<string>("Createduser")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Deletetime")
                        .HasColumnType("datetime");

                    b.Property<string>("Guid")
                        .HasColumnType("text");

                    b.Property<bool>("Isactive")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("Modifiedtime")
                        .HasColumnType("datetime");

                    b.Property<string>("Modifieduser")
                        .HasColumnType("text");

                    b.Property<string>("Parametergroup")
                        .HasColumnType("text");

                    b.Property<string>("Parametername")
                        .HasColumnType("text");

                    b.Property<int>("Vieworder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("GLSalesman");
                });

            modelBuilder.Entity("StarNote.Models.DBModels.GLSalestype", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("Createdtime")
                        .HasColumnType("datetime");

                    b.Property<string>("Createduser")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Deletetime")
                        .HasColumnType("datetime");

                    b.Property<string>("Guid")
                        .HasColumnType("text");

                    b.Property<bool>("Isactive")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("Modifiedtime")
                        .HasColumnType("datetime");

                    b.Property<string>("Modifieduser")
                        .HasColumnType("text");

                    b.Property<string>("Parametergroup")
                        .HasColumnType("text");

                    b.Property<string>("Parametername")
                        .HasColumnType("text");

                    b.Property<int>("Vieworder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("GLSalestype");
                });

            modelBuilder.Entity("StarNote.Models.DBModels.GLStock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("Amount")
                        .HasColumnType("double");

                    b.Property<DateTime?>("Createdtime")
                        .HasColumnType("datetime");

                    b.Property<string>("Createduser")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Deletetime")
                        .HasColumnType("datetime");

                    b.Property<double>("Discount")
                        .HasColumnType("double");

                    b.Property<string>("Guid")
                        .HasColumnType("text");

                    b.Property<double>("Incomeprice")
                        .HasColumnType("double");

                    b.Property<bool>("Isactive")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("Modifiedtime")
                        .HasColumnType("datetime");

                    b.Property<string>("Modifieduser")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Outcomeprice")
                        .HasColumnType("text");

                    b.Property<string>("Producttype")
                        .HasColumnType("text");

                    b.Property<string>("Tax")
                        .HasColumnType("text");

                    b.Property<string>("Unit")
                        .HasColumnType("text");

                    b.Property<int>("Vieworder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("GLStock");
                });

            modelBuilder.Entity("StarNote.Models.DBModels.GLTax", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("Createdtime")
                        .HasColumnType("datetime");

                    b.Property<string>("Createduser")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Deletetime")
                        .HasColumnType("datetime");

                    b.Property<string>("Guid")
                        .HasColumnType("text");

                    b.Property<bool>("Isactive")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("Modifiedtime")
                        .HasColumnType("datetime");

                    b.Property<string>("Modifieduser")
                        .HasColumnType("text");

                    b.Property<string>("Parametergroup")
                        .HasColumnType("text");

                    b.Property<string>("Parametername")
                        .HasColumnType("text");

                    b.Property<int>("Vieworder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("GLTax");
                });

            modelBuilder.Entity("StarNote.Models.DBModels.GLUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("Createdtime")
                        .HasColumnType("datetime");

                    b.Property<string>("Createduser")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Deletetime")
                        .HasColumnType("datetime");

                    b.Property<string>("Guid")
                        .HasColumnType("text");

                    b.Property<bool>("Isactive")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("Modifiedtime")
                        .HasColumnType("datetime");

                    b.Property<string>("Modifieduser")
                        .HasColumnType("text");

                    b.Property<string>("Parametergroup")
                        .HasColumnType("text");

                    b.Property<string>("Parametername")
                        .HasColumnType("text");

                    b.Property<int>("Vieworder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("GLUnit");
                });

            modelBuilder.Entity("StarNote.Models.DBModels.GLUsers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Authory")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Createdtime")
                        .HasColumnType("datetime");

                    b.Property<string>("Createduser")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Deletetime")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Guid")
                        .HasColumnType("text");

                    b.Property<bool>("Isactive")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("Modifiedtime")
                        .HasColumnType("datetime");

                    b.Property<string>("Modifieduser")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .HasColumnType("text");

                    b.Property<int>("Vieworder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("GLUser");
                });

            modelBuilder.Entity("StarNote.Models.DBModels.SPCostumerorder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string>("Companyaddress")
                        .HasColumnType("text");

                    b.Property<string>("Companyname")
                        .HasColumnType("text");

                    b.Property<string>("Costumerid")
                        .HasColumnType("text");

                    b.Property<string>("Costumertype")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Createdtime")
                        .HasColumnType("datetime");

                    b.Property<string>("Createduser")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Deletetime")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("Deliverydate")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Guid")
                        .HasColumnType("text");

                    b.Property<string>("Info")
                        .HasColumnType("text");

                    b.Property<bool>("Isactive")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("Modifiedtime")
                        .HasColumnType("datetime");

                    b.Property<string>("Modifieduser")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Orderno")
                        .HasColumnType("text");

                    b.Property<string>("Paymenttype")
                        .HasColumnType("text");

                    b.Property<string>("Phonenumber")
                        .HasColumnType("text");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<double>("Pricewaiting")
                        .HasColumnType("double");

                    b.Property<string>("Processcase")
                        .HasColumnType("text");

                    b.Property<string>("Processtype")
                        .HasColumnType("text");

                    b.Property<DateTime>("Registerdate")
                        .HasColumnType("datetime");

                    b.Property<string>("Salesman")
                        .HasColumnType("text");

                    b.Property<string>("Salestype")
                        .HasColumnType("text");

                    b.Property<int>("Savetype")
                        .HasColumnType("int");

                    b.Property<string>("Tax")
                        .HasColumnType("text");

                    b.Property<string>("Taxname")
                        .HasColumnType("text");

                    b.Property<string>("Taxno")
                        .HasColumnType("text");

                    b.Property<string>("Town")
                        .HasColumnType("text");

                    b.Property<int>("Vieworder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SPCostumerorder");
                });

            modelBuilder.Entity("StarNote.Models.DBModels.SPDefinedcompany", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Companyaddress")
                        .HasColumnType("text");

                    b.Property<string>("Companyname")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Createdtime")
                        .HasColumnType("datetime");

                    b.Property<string>("Createduser")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Deletetime")
                        .HasColumnType("datetime");

                    b.Property<string>("Guid")
                        .HasColumnType("text");

                    b.Property<bool>("Isactive")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("Modifiedtime")
                        .HasColumnType("datetime");

                    b.Property<string>("Modifieduser")
                        .HasColumnType("text");

                    b.Property<string>("Taxname")
                        .HasColumnType("text");

                    b.Property<string>("Taxno")
                        .HasColumnType("text");

                    b.Property<int>("Vieworder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SPCompany");
                });

            modelBuilder.Entity("StarNote.Models.DBModels.SPDefinedcostumer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string>("Costumerid")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Createdtime")
                        .HasColumnType("datetime");

                    b.Property<string>("Createduser")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Deletetime")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Guid")
                        .HasColumnType("text");

                    b.Property<bool>("Isactive")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("Modifiedtime")
                        .HasColumnType("datetime");

                    b.Property<string>("Modifieduser")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Phonenumber")
                        .HasColumnType("text");

                    b.Property<string>("Town")
                        .HasColumnType("text");

                    b.Property<int>("Vieworder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SPCostumer");
                });

            modelBuilder.Entity("StarNote.Models.DBModels.SPFilemanagement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Companyname")
                        .HasColumnType("text");

                    b.Property<string>("Costumername")
                        .HasColumnType("text");

                    b.Property<string>("Filename")
                        .HasColumnType("text");

                    b.Property<string>("Fileno")
                        .HasColumnType("text");

                    b.Property<int>("Mainid")
                        .HasColumnType("int");

                    b.Property<string>("Typedetailname")
                        .HasColumnType("text");

                    b.Property<string>("Typename")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("SPFilemanagement");
                });

            modelBuilder.Entity("StarNote.Models.DBModels.SPJoborder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("Amount")
                        .HasColumnType("double");

                    b.Property<string>("Costumerorder")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Createdtime")
                        .HasColumnType("datetime");

                    b.Property<string>("Createduser")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Deletetime")
                        .HasColumnType("datetime");

                    b.Property<string>("Guid")
                        .HasColumnType("text");

                    b.Property<string>("Info")
                        .HasColumnType("text");

                    b.Property<bool>("Isactive")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Joborderno")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Modifiedtime")
                        .HasColumnType("datetime");

                    b.Property<string>("Modifieduser")
                        .HasColumnType("text");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<string>("Processcase")
                        .HasColumnType("text");

                    b.Property<string>("Product")
                        .HasColumnType("text");

                    b.Property<string>("Propducttype")
                        .HasColumnType("text");

                    b.Property<string>("Unit")
                        .HasColumnType("text");

                    b.Property<int>("Vieworder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SPJoborder");
                });
#pragma warning restore 612, 618
        }
    }
}
