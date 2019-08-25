# AutoStartConfirm

More and more programs want to start automatically when Windows starts or a user logs on.

Many startup programs can slow down the boot process.
In addition, malicious software, such as keyloggers, can survive reboots.

Therefore, this program monitors whether a program wants to start automatically and asks the user for permission.

## State of development

The development has just begun.
The program can not be used yet.

Currently, the following startup locations are being monitored:

- [ ] Boot execute
- [ ] Appinit DLLs
- [ ] Explorer Addons
- [ ] Image hijacks
- [ ] Internet Explorer Addons
- [ ] Known DLLs
- [ ] Logon
- [ ] Winsock
- [ ] Codecs
- [ ] Office Add-Ins
- [ ] Print monitor DLLs
- [ ] LSA security providers
- [ ] Services and drivers
- [ ] Scheduled Tasks
- [ ] Winlogon
- [ ] WMI

## Links

This program is similar to [Sysinternals Autoruns](https://docs.microsoft.com/en-us/sysinternals/downloads/autoruns).
Sysinternals Autoruns is a great tool for analyzing and disabling or enabling existing autostart programs.
However, it lacks a function to notify a user about a new startup program and to ask for his permission.

Sysinternals Autoruns is not an Open Source program, but there is a [Autoruns PowerShell Module](https://github.com/p0w3rsh3ll/AutoRuns)
that can be used, for example, to determine where a program can be registered to start automatically with Windows.
