using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace console_app.library {
    public static class StringUtils {
        public static bool Validate(this string str) {
            return Regex.IsMatch(str, @"^\D+$");
        }
    }
}
