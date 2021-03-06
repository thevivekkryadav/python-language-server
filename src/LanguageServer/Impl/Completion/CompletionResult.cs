﻿// Copyright(c) Microsoft Corporation
// All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the License); you may not use
// this file except in compliance with the License. You may obtain a copy of the
// License at http://www.apache.org/licenses/LICENSE-2.0
//
// THIS CODE IS PROVIDED ON AN  *AS IS* BASIS, WITHOUT WARRANTIES OR CONDITIONS
// OF ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION ANY
// IMPLIED WARRANTIES OR CONDITIONS OF TITLE, FITNESS FOR A PARTICULAR PURPOSE,
// MERCHANTABILITY OR NON-INFRINGEMENT.
//
// See the Apache Version 2.0 License for specific language governing
// permissions and limitations under the License.

using System.Collections.Generic;
using System.Linq;
using Microsoft.Python.Core.Text;
using Microsoft.Python.LanguageServer.Protocol;

namespace Microsoft.Python.LanguageServer.Completion {
    internal sealed class CompletionResult {
        public static readonly CompletionResult Empty = new CompletionResult(Enumerable.Empty<CompletionItem>());

        public IReadOnlyList<CompletionItem> Completions { get; }
        public SourceSpan? ApplicableSpan { get; }

        public CompletionResult(IEnumerable<CompletionItem> completions, SourceSpan? applicableSpan) : this(completions) {
            ApplicableSpan = applicableSpan;
        }
        public CompletionResult(IEnumerable<CompletionItem> completions) {
            Completions = completions.ToArray();
        }
    }
}
