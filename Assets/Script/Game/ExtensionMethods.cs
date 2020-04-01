using System;
using System.Collections.Generic;
using Random = UnityEngine.Random;

public static class ExtensionMethods {
    public static bool ContainsVerb(this string input, Command command) {
        input = input.ToLower();
        foreach (string verb in command.verbs) {
            if (input.StartsWith(verb.ToLower())) {
                return true;
            }
        }
        return false;
    }

    public static bool IsValid(this string input, Command command) {
        return input.ContainsVerb(command) && command.nouns.ContainsCaseInsensitive(input.GetNoun(command));
    }

    public static string GetVerb(this string input, Command command) {
        input = input.Trim().ToLower();
        foreach (string verb in command.verbs) {
            if (input.StartsWith(verb.ToLower())) {
                return verb.ToLower();
            }
        }
        return input.Split(' ')[0];
    }

    public static string GetNoun(this string input, Command command) {
        return input.ReplaceCaseInsensitive(input.GetVerb(command), "").Trim();
    }

    public static bool ContainsCaseInsensitive(this List<string> strings, string input) {
        foreach (string s in strings) {
            if (string.Equals(s.Trim(), input.Trim(), StringComparison.CurrentCultureIgnoreCase)) {
                return true;
            }
        }
        return false;
    }

    public static bool EqualsCaseInsensitive(this string input1, string input2) {
        return string.Equals(input1.Trim(), input2.Trim(), StringComparison.CurrentCultureIgnoreCase);
    }

    public static string ReplaceCaseInsensitive(this string s, string oldValue, string newValue) {
        return s.ToLower().Replace(oldValue.ToLower(), newValue.ToLower());
    }
    
    public static void Shuffle<T>(this List<T> list)
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = Random.Range(0, n+1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }
}
