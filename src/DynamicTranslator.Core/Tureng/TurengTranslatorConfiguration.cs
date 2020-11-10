﻿using System.Collections.Generic;
using DynamicTranslator.Core.Configuration;
using DynamicTranslator.Core.Model;

namespace DynamicTranslator.Core.Tureng
{
    public class TurengTranslatorConfiguration : TranslatorConfiguration
    {
        private readonly IApplicationConfiguration _applicationConfiguration;

        public override bool CanSupport()
        {
            return base.CanSupport() && _applicationConfiguration.IsToLanguageTurkish;
        }

        public override IList<Language> SupportedLanguages { get; set; }

        public override string Url { get; set; }

        public override TranslatorType TranslatorType => TranslatorType.Tureng;

        public TurengTranslatorConfiguration(ActiveTranslatorConfiguration activeTranslatorConfiguration,
            IApplicationConfiguration applicationConfiguration) : base(activeTranslatorConfiguration,
            applicationConfiguration)
        {
            _applicationConfiguration = applicationConfiguration;
        }
    }
}