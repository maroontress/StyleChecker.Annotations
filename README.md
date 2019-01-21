# StyleChecker.Annotations

This is a C# class library that provides annotations used with
[StyleChecker][stylechecker].

- `DoNotIgnoreAttribute` marks a return value as unable to ignore, used with
  [DiscardingReturnValue][discarding-return-value] analyzer.
- `UnusedAttribute` marks a parameter unused, used with
  [UnusedVariable][unused-variable] analyzer.

[stylechecker]:
  https://maroontress.github.io/StyleChecker/
[discarding-return-value]:
  https://github.com/maroontress/StyleChecker/blob/master/doc/rules/DiscardingReturnValue.md
[unused-variable]:
  https://github.com/maroontress/StyleChecker/blob/master/doc/rules/UnusedVariable.md
