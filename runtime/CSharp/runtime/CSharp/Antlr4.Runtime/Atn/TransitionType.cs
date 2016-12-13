/* Copyright (c) 2012-2016 The ANTLR Project. All rights reserved.
 * Use of this file is governed by the BSD 3-clause license that
 * can be found in the LICENSE.txt file in the project root.
 */

namespace Antlr4.Runtime.Atn
{
    public enum TransitionType
    {
		INVALID,
        EPSILON,
        RANGE,
        RULE,
        PREDICATE,
        ATOM,
        ACTION,
        SET,
        NOT_SET,
        WILDCARD,
        PRECEDENCE
    }
}
