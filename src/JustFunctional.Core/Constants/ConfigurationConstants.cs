﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace JustFunctional.Core
{
    public static class ConfigurationConstants
    {
        public const int MaxLengthForOperatorsAndConstants = 4;
        public const char DecimalPlacesSeparator = '.';

        public static class AsString
        {
            public const string EndOfFile = "EOF";
            public const string OpeningBracket = "(";
            public const string ClosingBracket = ")";
            public const string Add = "+";
            public const string Substract = "-";
            public const string Multiply = "*";
            public const string Divide = "/";
            public const string MinusUnary = "-";
            public const string Cosine = "cos";
            public const string Sine = "sin";
            public const string CommonLogarithm = "log";
            public const string SquareRoot = "sqrt";
            public const string CubeRoot = "cbr";
            public const string Exponentiation = "^";
            public const string Factorial = "fac";
            public const string Module = "mod";
            public const string NaturalLogarithm = "ln";
        }
        public static class AsChar
        {
            public const char Space = ' ';
            public const char MinusUnary = '-';
        }

        public static class Precedences
        {
            public const int Brackets = -10;
            public const int AddSubstract = 1;
            public const int MultiplyDivide = 2;
            public const int ExponentiationAndRoots = 3;
            public const int GeneralPurposeFunctions = 4;
        }
        public static class Operators
        {
            public static readonly ReadOnlyCollection<Operator> IntrinsicOperators = new List<Operator>()
            {
                new OpeningBracketOperator(), new ClosingBracketOperator(),
            }.AsReadOnly();
        }

        public static class Tokens
        {
            public static readonly IToken EndOfFile = new Operand(int.MinValue, AsString.EndOfFile);
        }

        public static class Options
        {
            public static readonly FunctionOptions CompiledDefault = new(new CompiledExpressionEvaluatorFactory(),
                                                                            new DefaultTokensProvider(),
                                                                            null);
            public static readonly FunctionOptions JustInTimeDefault = new(new CompiledExpressionEvaluatorFactory(),
                                                                                new DefaultTokensProvider(),
                                                                                null);
        }
    }
}