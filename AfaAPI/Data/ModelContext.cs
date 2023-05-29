using System;
using System.Collections.Generic;
using Alfa.Models;
using Microsoft.EntityFrameworkCore;

namespace Alfa.Data;

public partial class ModelContext : DbContext
{
    public ModelContext()
    {
    }

    public ModelContext(DbContextOptions<ModelContext> options)
        : base(options)
    {
    }

    public virtual DbSet<PrepaidRecharge> PrepaidRecharges { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("ALFAWS_DEV");

        modelBuilder.Entity<PrepaidRecharge>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PREPAID_RECHARGE");

            entity.Property(e => e.Creditcard)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasDefaultValueSql("'000000xxxxxx0000'\n")
                .HasColumnName("CREDITCARD");
            entity.Property(e => e.LbpAmount)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("LBP_AMOUNT");
            entity.Property(e => e.PayCurrency)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PAY_CURRENCY");
            entity.Property(e => e.PrAmount)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PR_AMOUNT");
            entity.Property(e => e.PrCsDate)
                .HasColumnType("DATE")
                .HasColumnName("PR_CS_DATE");
            entity.Property(e => e.PrCsStatus)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("PR_CS_STATUS");
            entity.Property(e => e.PrDate)
                .HasColumnType("DATE")
                .HasColumnName("PR_DATE");
            entity.Property(e => e.PrFiscalstamp)
                .HasColumnType("NUMBER(8,2)")
                .HasColumnName("PR_FISCALSTAMP");
            entity.Property(e => e.PrId)
                .HasColumnType("NUMBER")
                .HasColumnName("PR_ID");
            entity.Property(e => e.PrMsisdn)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PR_MSISDN");
            entity.Property(e => e.PrPaymentId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PR_PAYMENT_ID");
            entity.Property(e => e.PrRate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PR_RATE");
            entity.Property(e => e.PrRates)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PR_RATEs");
            entity.Property(e => e.PrRequestUrl)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasColumnName("PR_REQUEST_URL");
            entity.Property(e => e.PrResponseUrl)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("PR_RESPONSE_URL");
            entity.Property(e => e.PrSessionId)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("PR_SESSION_ID");
            entity.Property(e => e.PrStatus)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("PR_STATUS");
            entity.Property(e => e.PrSvDate)
                .HasColumnType("DATE")
                .HasColumnName("PR_SV_DATE");
            entity.Property(e => e.PrSvStatus)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("PR_SV_STATUS");
            entity.Property(e => e.PrTransaction)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("PR_TRANSACTION");
            entity.Property(e => e.UsdAmount)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USD_AMOUNT");
        });
        modelBuilder.HasSequence("CREDIT_TRANSFER_LOG_SEQ");
        modelBuilder.HasSequence("CREDIT_TRANSFER_SEQ");
        modelBuilder.HasSequence("CWI_USER_SEQ");
        modelBuilder.HasSequence("DENOMINATIONSPLANS_SEQ");
        modelBuilder.HasSequence("DEVICES_LOGS_SEQ");
        modelBuilder.HasSequence("DONATION_SMS_TRANSACTIONS_SEQ");
        modelBuilder.HasSequence("DONATION_TRANSACTIONS_SEQ");
        modelBuilder.HasSequence("DONGLE_HEADER_LOG_ID");
        modelBuilder.HasSequence("DONGLE_SESSION_LOG_ID");
        modelBuilder.HasSequence("DONGLE_SUBSCRIPTION_LOG_ID");
        modelBuilder.HasSequence("FREE_SMS_CONTACTS_SEQ");
        modelBuilder.HasSequence("FREE_SMS_SEQ");
        modelBuilder.HasSequence("LOGS_SEQ");
        modelBuilder.HasSequence("ME_MEMBER_ID_SEQ");
        modelBuilder.HasSequence("MISP_CUSTOMER_INFO_ID");
        modelBuilder.HasSequence("MISP_ISP_INFO_ID");
        modelBuilder.HasSequence("MISP_ISP_INVENTORY_ID");
        modelBuilder.HasSequence("MISP_SESSION_LOG_ID");
        modelBuilder.HasSequence("MISP_SIM_TRANS_ID");
        modelBuilder.HasSequence("OP_BO_ACCESS_RIGHTS_ID");
        modelBuilder.HasSequence("OP_BO_AUDI_REPORT_ID");
        modelBuilder.HasSequence("OP_BO_SESSION_LOG_ID");
        modelBuilder.HasSequence("OPWS_ACCESS_SEQ");
        modelBuilder.HasSequence("OPWS_ID_SEQ");
        modelBuilder.HasSequence("OPWS_LOG_SEQ");
        modelBuilder.HasSequence("POST_PAY_LOGS_SEQ");
        modelBuilder.HasSequence("POST_PAY_TOKENS_SEQ");
        modelBuilder.HasSequence("POST_PAY_TRANS_INFO_SEQ");
        modelBuilder.HasSequence("POST_PAY_TRANS_SEQ");
        modelBuilder.HasSequence("POST_PRE_LOG_SEQ");
        modelBuilder.HasSequence("POST_PRE_RECHARGE_SEQ");
        modelBuilder.HasSequence("POSTPAID_PAYMENT_WEBHOOK_SEQ");
        modelBuilder.HasSequence("POSTPAID_SERVICES_ACTIONS_SEQ");
        modelBuilder.HasSequence("POSTPAID_SHARED_ACTIONS_SEQ");
        modelBuilder.HasSequence("PP_TRANSACTION_SEQ");
        modelBuilder.HasSequence("PR_TRANSACTION_SEQ");
        modelBuilder.HasSequence("PRE_RECHARGE_ACCOUNTS_SEQ");
        modelBuilder.HasSequence("PRE_RECHARGE_LOGS_SEQ");
        modelBuilder.HasSequence("PRE_SER_SHAREDBUNDLE_ID_SEQ");
        modelBuilder.HasSequence("PRE_SERVICES_ID_SEQ");
        modelBuilder.HasSequence("PREPAID_RECHARGE_SEQ");
        modelBuilder.HasSequence("SCRATCH_LOGS_SEQ");
        modelBuilder.HasSequence("SQ_PlanMigrations");
        modelBuilder.HasSequence("SQ_SMS_MESSAGES");
        modelBuilder.HasSequence("SQ_WEB_ACCOUNT_BANNER");
        modelBuilder.HasSequence("SQ_WEB_ALFA_APPS");
        modelBuilder.HasSequence("SQ_WEB_ALFA4NATURE_EVENTS");
        modelBuilder.HasSequence("SQ_WEB_AUDI_RESPONSES");
        modelBuilder.HasSequence("SQ_WEB_AUDITS");
        modelBuilder.HasSequence("SQ_WEB_AWARDS");
        modelBuilder.HasSequence("SQ_WEB_BLACKBERRY_INFOS");
        modelBuilder.HasSequence("SQ_WEB_CACHE_ITEMS");
        modelBuilder.HasSequence("SQ_WEB_CODE_MESSAGES");
        modelBuilder.HasSequence("SQ_WEB_COMPATIBLE_DEVICES");
        modelBuilder.HasSequence("SQ_WEB_CORPOATE_OFFERS");
        modelBuilder.HasSequence("SQ_WEB_CYBER_RESPONSES");
        modelBuilder.HasSequence("SQ_WEB_DEVICE_BRANDS");
        modelBuilder.HasSequence("SQ_WEB_DEVICE_CATEGORIES");
        modelBuilder.HasSequence("SQ_WEB_DEVICE_SETTINGS");
        modelBuilder.HasSequence("SQ_WEB_DEVICES_AND_ACCESSORIES");
        modelBuilder.HasSequence("SQ_WEB_ERRORS");
        modelBuilder.HasSequence("SQ_WEB_FACT_SHEETS");
        modelBuilder.HasSequence("SQ_WEB_FAQS");
        modelBuilder.HasSequence("SQ_WEB_FILES");
        modelBuilder.HasSequence("SQ_WEB_GALLERIES");
        modelBuilder.HasSequence("SQ_WEB_HOMEPAGE_BANNERS");
        modelBuilder.HasSequence("SQ_WEB_HOMEPAGE_BOXES");
        modelBuilder.HasSequence("SQ_WEB_HOMEPAGE_PROMOTIONS");
        modelBuilder.HasSequence("SQ_WEB_HOMEPAGE_SHOPS");
        modelBuilder.HasSequence("SQ_WEB_HSE_CAMPAIGNS");
        modelBuilder.HasSequence("SQ_WEB_IMAGES");
        modelBuilder.HasSequence("SQ_WEB_KEYWORD_LINKS");
        modelBuilder.HasSequence("SQ_WEB_LATEST_NEWSES");
        modelBuilder.HasSequence("SQ_WEB_LINE_PERMISSIONS");
        modelBuilder.HasSequence("SQ_WEB_LOCALIZATIONS");
        modelBuilder.HasSequence("SQ_WEB_MALAKE_WATCHES");
        modelBuilder.HasSequence("SQ_WEB_MENU_ADVERTISEMENTS");
        modelBuilder.HasSequence("SQ_WEB_NETWORK_EXPANSIONS");
        modelBuilder.HasSequence("SQ_WEB_NETWORK_MAINTENANCES");
        modelBuilder.HasSequence("SQ_WEB_NETWORK_OUTAGES");
        modelBuilder.HasSequence("SQ_WEB_NEWSES");
        modelBuilder.HasSequence("SQ_WEB_NGO_PROJECTS");
        modelBuilder.HasSequence("SQ_WEB_NGOS");
        modelBuilder.HasSequence("SQ_WEB_OFFERS_AND_PROMOS");
        modelBuilder.HasSequence("SQ_WEB_OUR_COMMUNITY_PROJECTS");
        modelBuilder.HasSequence("SQ_WEB_PAGES");
        modelBuilder.HasSequence("SQ_WEB_PLAN_COMMERICAL_NAMES");
        modelBuilder.HasSequence("SQ_WEB_PLAN_INFOS");
        modelBuilder.HasSequence("SQ_WEB_PLAN_LIFECYCLES");
        modelBuilder.HasSequence("SQ_WEB_PLAN_SERVICE_TYPES");
        modelBuilder.HasSequence("SQ_WEB_PLAN_SIMULATOR_ITEMS");
        modelBuilder.HasSequence("SQ_WEB_PLANS_AND_BUNDLES");
        modelBuilder.HasSequence("SQ_WEB_PRESSES");
        modelBuilder.HasSequence("SQ_WEB_REGIONS");
        modelBuilder.HasSequence("SQ_WEB_ROAMINGS");
        modelBuilder.HasSequence("SQ_WEB_SAFETY_CAMPAIGNS");
        modelBuilder.HasSequence("SQ_WEB_SCRATCH_CARD_DETAILS");
        modelBuilder.HasSequence("SQ_WEB_SEARCHED_WORDS");
        modelBuilder.HasSequence("SQ_WEB_SECURITY_TIPS");
        modelBuilder.HasSequence("SQ_WEB_SERVICE_BUNDLES");
        modelBuilder.HasSequence("SQ_WEB_SERVICE_CHILDREN");
        modelBuilder.HasSequence("SQ_WEB_SERVICE_INFOS");
        modelBuilder.HasSequence("SQ_WEB_SERVICE_PLANS");
        modelBuilder.HasSequence("SQ_WEB_SERVICE_PRICES");
        modelBuilder.HasSequence("SQ_WEB_SERVICES");
        modelBuilder.HasSequence("SQ_WEB_SMARTHOME_INFOS");
        modelBuilder.HasSequence("SQ_WEB_SMARTPHONE_DATA_INFOS");
        modelBuilder.HasSequence("SQ_WEB_SMARTPHONE_INFOS");
        modelBuilder.HasSequence("SQ_WEB_SMS_HELPS");
        modelBuilder.HasSequence("SQ_WEB_SMS_SHORT_CODES");
        modelBuilder.HasSequence("SQ_WEB_STORE_CATEGORIES");
        modelBuilder.HasSequence("SQ_WEB_STORE_TYPE_OF_SERVICES");
        modelBuilder.HasSequence("SQ_WEB_STORES");
        modelBuilder.HasSequence("SQ_WEB_SURVEYS");
        modelBuilder.HasSequence("SQ_WEB_TAGS");
        modelBuilder.HasSequence("SQ_WEB_TROUBLESHOOTINGS");
        modelBuilder.HasSequence("SQ_WEB_TUTORIAL_VIDEOS");
        modelBuilder.HasSequence("SQ_WEB_UNDER_MAINTE_1165573864");
        modelBuilder.HasSequence("SQ_WEB_USER_CLAIMS");
        modelBuilder.HasSequence("SQ_WEB_VIP_CODES");
        modelBuilder.HasSequence("SQ_WEB_WOMEN_EMPOWREMENTS");
        modelBuilder.HasSequence("SURVEY_LOG_ID_SEQ");
        modelBuilder.HasSequence("SURVEY_LOGS_SEQ");
        modelBuilder.HasSequence("SUSPEND_LINE_INFO_SEQ");
        modelBuilder.HasSequence("WATCHES_SEQ");
        modelBuilder.HasSequence("WSI_SMS_SEQ");
        modelBuilder.HasSequence("YOURLINE_ADDMBR_SEQ");
        modelBuilder.HasSequence("YOURLINE_RESERVATION_ID");

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
