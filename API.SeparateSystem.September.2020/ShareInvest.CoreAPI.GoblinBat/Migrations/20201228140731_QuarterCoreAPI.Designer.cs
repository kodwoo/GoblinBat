﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShareInvest.CoreAPI;

namespace ShareInvest.Migrations
{
    [DbContext(typeof(CoreApiDbContext))]
    [Migration("20201228140731_QuarterCoreAPI")]
    partial class QuarterCoreAPI
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("ShareInvest.Models.CatalogStrategics", b =>
                {
                    b.Property<string>("Strategics")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("AdditionalPurchase")
                        .HasColumnType("float");

                    b.Property<int>("Long")
                        .HasColumnType("int");

                    b.Property<string>("LongShort")
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("QuoteUnit")
                        .HasColumnType("int");

                    b.Property<double>("RealizeProfit")
                        .HasColumnType("float");

                    b.Property<string>("Setting")
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.Property<int>("Short")
                        .HasColumnType("int");

                    b.Property<int>("Trend")
                        .HasColumnType("int");

                    b.Property<string>("TrendType")
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("Strategics");

                    b.ToTable("Catalog");
                });

            modelBuilder.Entity("ShareInvest.Models.Codes", b =>
                {
                    b.Property<string>("Code")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<double>("MarginRate")
                        .HasColumnType("float");

                    b.Property<string>("MaturityMarketCap")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Code");

                    b.ToTable("Codes");
                });

            modelBuilder.Entity("ShareInvest.Models.Consensus", b =>
                {
                    b.Property<string>("Code")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Date")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Quarter")
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.Property<int>("Bps")
                        .HasColumnType("int");

                    b.Property<int>("Eps")
                        .HasColumnType("int");

                    b.Property<string>("Ev")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Np")
                        .HasColumnType("bigint");

                    b.Property<long>("Op")
                        .HasColumnType("bigint");

                    b.Property<double>("Pbr")
                        .HasColumnType("float");

                    b.Property<double>("Per")
                        .HasColumnType("float");

                    b.Property<string>("Roe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Sales")
                        .HasColumnType("bigint");

                    b.Property<double>("YoY")
                        .HasColumnType("float");

                    b.HasKey("Code", "Date", "Quarter");

                    b.ToTable("Consensus");
                });

            modelBuilder.Entity("ShareInvest.Models.Days", b =>
                {
                    b.Property<string>("Code")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Date")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Code", "Date");

                    b.ToTable("Days");
                });

            modelBuilder.Entity("ShareInvest.Models.EstimatedPrice", b =>
                {
                    b.Property<string>("Code")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Strategics")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<double>("FirstQuarter")
                        .HasColumnType("float");

                    b.Property<double>("Quarter")
                        .HasColumnType("float");

                    b.Property<double>("SecondQuarter")
                        .HasColumnType("float");

                    b.Property<double>("TheNextYear")
                        .HasColumnType("float");

                    b.Property<double>("TheYearAfterNext")
                        .HasColumnType("float");

                    b.Property<double>("ThirdQuarter")
                        .HasColumnType("float");

                    b.HasKey("Code", "Strategics");

                    b.HasIndex("Strategics");

                    b.ToTable("Estimate");
                });

            modelBuilder.Entity("ShareInvest.Models.FileOfGoblinBat", b =>
                {
                    b.Property<string>("Version")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<byte[]>("Content")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Version");

                    b.ToTable("File");
                });

            modelBuilder.Entity("ShareInvest.Models.FinancialStatement", b =>
                {
                    b.Property<string>("Code")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Date")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("BPS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CAPEX")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ControllingEquity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ControllingNetIncome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DPS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DebtRatio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DividendYield")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EPS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EquityCapital")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FCF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FinancingActivities")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IncomeFromOperation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IncomeFromOperations")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InterestAccruingLiabilities")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InvestingActivities")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IssuedStocks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NetIncome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NetMargin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NonControllingEquity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NonControllingNetIncome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OperatingActivities")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OperatingMargin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PBR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PER")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PayoutRatio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfitFromContinuingOperations")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ROA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ROE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RetentionRatio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Revenues")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TotalAssets")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TotalEquity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TotalLiabilites")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Code", "Date");

                    b.ToTable("FinancialStatement");
                });

            modelBuilder.Entity("ShareInvest.Models.Futures", b =>
                {
                    b.Property<string>("Code")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Date")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Volume")
                        .HasColumnType("int");

                    b.HasKey("Code", "Date");

                    b.ToTable("Futures");
                });

            modelBuilder.Entity("ShareInvest.Models.IncorporatedStocks", b =>
                {
                    b.Property<string>("Code")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<int>("Capitalization")
                        .HasColumnType("int");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("Market")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Code");

                    b.ToTable("Incorporate");
                });

            modelBuilder.Entity("ShareInvest.Models.Options", b =>
                {
                    b.Property<string>("Code")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Date")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Volume")
                        .HasColumnType("int");

                    b.HasKey("Code", "Date");

                    b.ToTable("Options");
                });

            modelBuilder.Entity("ShareInvest.Models.Privacy", b =>
                {
                    b.Property<string>("Security")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Account")
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("CodeStrategics")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Coin")
                        .HasColumnType("float");

                    b.Property<double>("Commission")
                        .HasColumnType("float");

                    b.Property<string>("SecuritiesAPI")
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("SecurityAPI")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Security");

                    b.ToTable("Privacies");
                });

            modelBuilder.Entity("ShareInvest.Models.RevisedStockPrice", b =>
                {
                    b.Property<string>("Code")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Date")
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Revise")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Code", "Date");

                    b.ToTable("RevisedStockPrices");
                });

            modelBuilder.Entity("ShareInvest.Models.SatisfyConditions", b =>
                {
                    b.Property<string>("Security")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Ban")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SettingValue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Strategics")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TempStorage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Security");

                    b.ToTable("Conditions");
                });

            modelBuilder.Entity("ShareInvest.Models.Stocks", b =>
                {
                    b.Property<string>("Code")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Date")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Volume")
                        .HasColumnType("int");

                    b.HasKey("Code", "Date");

                    b.ToTable("Stocks");
                });

            modelBuilder.Entity("ShareInvest.Models.StocksStrategics", b =>
                {
                    b.Property<string>("Code")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Strategics")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("CumulativeReturn")
                        .HasColumnType("float");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<double>("DiscrepancyRateFromExpectedStockPrice")
                        .HasColumnType("float");

                    b.Property<long>("MaximumInvestment")
                        .HasColumnType("bigint");

                    b.Property<double>("WeightedAverageDailyReturn")
                        .HasColumnType("float");

                    b.HasKey("Code", "Strategics");

                    b.HasIndex("Strategics");

                    b.ToTable("StocksStrategics");
                });

            modelBuilder.Entity("ShareInvest.Models.Consensus", b =>
                {
                    b.HasOne("ShareInvest.Models.Codes", null)
                        .WithMany("Consensus")
                        .HasForeignKey("Code")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ShareInvest.Models.Days", b =>
                {
                    b.HasOne("ShareInvest.Models.Codes", null)
                        .WithMany("Days")
                        .HasForeignKey("Code")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ShareInvest.Models.EstimatedPrice", b =>
                {
                    b.HasOne("ShareInvest.Models.Codes", null)
                        .WithMany("Estimate")
                        .HasForeignKey("Code")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShareInvest.Models.CatalogStrategics", null)
                        .WithMany("Consensus")
                        .HasForeignKey("Strategics")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ShareInvest.Models.FinancialStatement", b =>
                {
                    b.HasOne("ShareInvest.Models.Codes", null)
                        .WithMany("Financials")
                        .HasForeignKey("Code")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ShareInvest.Models.Futures", b =>
                {
                    b.HasOne("ShareInvest.Models.Codes", null)
                        .WithMany("Futures")
                        .HasForeignKey("Code")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ShareInvest.Models.IncorporatedStocks", b =>
                {
                    b.HasOne("ShareInvest.Models.Codes", null)
                        .WithMany("Incorporate")
                        .HasForeignKey("Code")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ShareInvest.Models.Options", b =>
                {
                    b.HasOne("ShareInvest.Models.Codes", null)
                        .WithMany("Options")
                        .HasForeignKey("Code")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ShareInvest.Models.RevisedStockPrice", b =>
                {
                    b.HasOne("ShareInvest.Models.Codes", null)
                        .WithMany("RevisedStockPrices")
                        .HasForeignKey("Code")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ShareInvest.Models.SatisfyConditions", b =>
                {
                    b.HasOne("ShareInvest.Models.Privacy", null)
                        .WithMany("Conditions")
                        .HasForeignKey("Security")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ShareInvest.Models.Stocks", b =>
                {
                    b.HasOne("ShareInvest.Models.Codes", null)
                        .WithMany("Stocks")
                        .HasForeignKey("Code")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ShareInvest.Models.StocksStrategics", b =>
                {
                    b.HasOne("ShareInvest.Models.Codes", null)
                        .WithMany("StocksStrategics")
                        .HasForeignKey("Code")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShareInvest.Models.CatalogStrategics", null)
                        .WithMany("Stocks")
                        .HasForeignKey("Strategics")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ShareInvest.Models.CatalogStrategics", b =>
                {
                    b.Navigation("Consensus");

                    b.Navigation("Stocks");
                });

            modelBuilder.Entity("ShareInvest.Models.Codes", b =>
                {
                    b.Navigation("Consensus");

                    b.Navigation("Days");

                    b.Navigation("Estimate");

                    b.Navigation("Financials");

                    b.Navigation("Futures");

                    b.Navigation("Incorporate");

                    b.Navigation("Options");

                    b.Navigation("RevisedStockPrices");

                    b.Navigation("Stocks");

                    b.Navigation("StocksStrategics");
                });

            modelBuilder.Entity("ShareInvest.Models.Privacy", b =>
                {
                    b.Navigation("Conditions");
                });
#pragma warning restore 612, 618
        }
    }
}
