<div dir="rtl">

# 💻 السي شارب المتقدم — المحاضرة 03: معمارية هياكل البيانات والـ Collections (6 أنظمة تطبيقية)
### Advanced C# 03: Collections Architecture (List, Dictionary, HashSet, Queue, Stack) — 6 Exercises

[![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/C%23-14.0-239120?style=for-the-badge&logo=c-sharp&logoColor=white)](https://learn.microsoft.com/en-us/dotnet/csharp/)
[![Module](https://img.shields.io/badge/Module-03_Advanced_CSharp-0284c7?style=for-the-badge)](#)
[![Interactive Guide](https://img.shields.io/badge/%F0%9F%8C%90_Live_Study_Guide-HTML_Interactive-8b5cf6?style=for-the-badge)](https://htmlpreview.github.io/?https://github.com/mohamedadel452/Advanced-CSharp-03/blob/master/Study_Guide/session03-part1-collections-list.html)

> **نبذة عن المشروع:** ⚡ [03 Advanced C# - Session 03] Collections Internals & 6 Practical Systems: Student Grade Manager, Leaderboard, PhoneBook, Unique Email Validator, Print Queue & Browser History Undo + 3 HTML Guides.

---

## 🌐 الدليل التفاعلي المشروح بالـ HTML (Interactive Study Guide)

تم تضمين الدليل التفاعلي المشروح بالكامل داخل مجلد [`Study_Guide/`](./Study_Guide) في هذا المستودع، ويمكنك قراءته مباشرة في المتصفح عبر الروابط التالية:

- 🌐 الدليل التفاعلي (1/3): شجرة واجهات Collections وتشريح List<T> (HTML): **[🌐 معاينة حية في المتصفح (Live Preview)](https://htmlpreview.github.io/?https://github.com/mohamedadel452/Advanced-CSharp-03/blob/master/Study_Guide/session03-part1-collections-list.html)** | **[📄 فتح ملف الـ HTML في المستودع](./Study_Guide/session03-part1-collections-list.html)**
- 🌐 الدليل التفاعلي (2/3): تشريح Dictionary<TKey,TValue> و HashSet<T> (HTML): **[🌐 معاينة حية في المتصفح (Live Preview)](https://htmlpreview.github.io/?https://github.com/mohamedadel452/Advanced-CSharp-03/blob/master/Study_Guide/session03-part2-dictionary-hashset.html)** | **[📄 فتح ملف الـ HTML في المستودع](./Study_Guide/session03-part2-dictionary-hashset.html)**
- 🌐 الدليل التفاعلي (3/3): Queue<T> و Stack<T> ومقارنة Big-O (HTML): **[🌐 معاينة حية في المتصفح (Live Preview)](https://htmlpreview.github.io/?https://github.com/mohamedadel452/Advanced-CSharp-03/blob/master/Study_Guide/session03-part3-queue-stack.html)** | **[📄 فتح ملف الـ HTML في المستودع](./Study_Guide/session03-part3-queue-stack.html)**
- 📂 **[فتح مجلد المحاضرة المحلي الكامل في `nots` (للتصفح المحلي على الجهاز)](../../../../nots/03_Advanced-CSharp/Session_03_Collections)**

---

### 🧠 الملاحظات الهندسية والمفاهيم المعمارية (Engineering Notes)
1. **تشريح هياكل البيانات الخمسة وتعقيدها الزمني (`Big-O Complexity`):**
   - **`List<T>` (Dynamic Array):** يعتمد داخلياً على مصفوفة `_items` تتضاعف سعتها (`Capacity * 2`) عند الامتلاء؛ وصول فوري بالفهرس `O(1)`، وإضافة في النهاية `O(1)` أمورتي، بينما الحذف/الإدراج في المنتصف `O(N)`.
   - **`SortedList<TKey, TValue>` / `SortedDictionary`:** يحافظ على العناصر مرتبة تلقائياً حسب المفتاح، مثالي لبناء لوحات المتصدرين (`Leaderboard`).
   - **`Dictionary<TKey, TValue>` (Hash Table):** يعتمد على مصفوفتي `_buckets` و `_entries` لحساب `GetHashCode() & 0x7FFFFFFF % buckets.Length`، مما يوفر بحثاً وإضافة وحذفاً بسرعة `O(1)`.
   - **`HashSet<T>` (Unique Set):** يضمن عدم تكرار العناصر بسرعة `O(1)` ويدعم العمليات الرياضية على المجموعات (`UnionWith`, `IntersectWith`, `ExceptWith`).
   - **`Queue<T>` (FIFO Circular Buffer):** طابور يعمل بمبدأ *الأول دخولاً هو الأول خروجاً* عبر مؤشري `_head` و `_tail` (`Enqueue` / `Dequeue` بتعقيد `O(1)`).
   - **`Stack<T>` (LIFO Array):** مكدس يعمل بمبدأ *الأخير دخولاً هو الأول خروجاً* (`Push` / `Pop` / `Peek` بتعقيد `O(1)`)، وهو العمود الفقري لأنظمة `Undo / Redo` وتاريخ المتصفح.

---

## 🗂️ هيكلة الكود والتمارين التطبيقية المحلولة

| التمرين | الملف المصدري | هيكل البيانات المستخدم | الوظيفة الهندسية |
| :--- | :--- | :--- | :--- |
| **Exercise 01** | [`Exercise01_StudentGradeManager.cs`](./Advanced-CSharp-03/Exercise01_StudentGradeManager.cs) | `List<int>` | إدارة درجات الطلاب، الفرز، الحذف الشرطي، وحساب الإحصائيات. |
| **Exercise 02** | [`Exercise02_Leaderboard.cs`](./Advanced-CSharp-03/Exercise02_Leaderboard.cs) | `SortedList` / `Dictionary` | لوحة متصدرين للاعبين مرتبة حسب النقاط مع التحديث الفوري. |
| **Exercise 03** | [`Exercise03_PhoneBook.cs`](./Advanced-CSharp-03/Exercise03_PhoneBook.cs) | `Dictionary<string, string>` | دليل هاتف سريع البحث والإضافة والتحديث الآمن عبر `TryGetValue`. |
| **Exercise 04** | [`Exercise04_EmailValidator.cs`](./Advanced-CSharp-03/Exercise04_EmailValidator.cs) | `HashSet<string>` | مدقق بريد إلكتروني يمنع التكرار (Case-Insensitive) وينفذ عمليات المجموعات. |
| **Exercise 05** | [`Exercise05_PrintQueue.cs`](./Advanced-CSharp-03/Exercise05_PrintQueue.cs) | `Queue<string>` | محاكاة طابور طباعة مستندات بنظام `FIFO` (`Enqueue`, `Peek`, `Dequeue`). |
| **Exercise 06** | [`Exercise06_BrowserHistory.cs`](./Advanced-CSharp-03/Exercise06_BrowserHistory.cs) | `Stack<string>` | نظام تنقل متصفح مع دعم الرجوع للخلف (`Back / Undo`) بنظام `LIFO`. |

---

## 🧭 خريطة مسار هندسة `.NET` الكامل على GitHub

| # | المرحلة (Module) | المستودع (Repository) | الموضوع الرئيسي | الدليل التفاعلي (Live HTML) |
| :---: | :--- | :--- | :--- | :---: |
| **01** | `01_CSharp_Basics` | **[`CSharp-Basics02-Assigment`](https://github.com/mohamedadel452/CSharp-Basics02-Assigment)** | أنواع البيانات، نموذج الكائنات (System.Object)، والتحويلات | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/CSharp-Basics02-Assigment/blob/master/Study_Guide/CSharp_Basics_Session02_Guide.html) |
| **02** | `01_CSharp_Basics` | **[`CSharp-Basics03-Assigment`](https://github.com/mohamedadel452/CSharp-Basics03-Assigment)** | معمارية النصوص (Strings & StringBuilder)، جمل التحكم، والحلقات | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/CSharp-Basics03-Assigment/blob/master/Study_Guide/CSharp_Basics_Session03_Guide.html) |
| **03** | `01_CSharp_Basics` | **[`CSharp-Basics04-Assigment`](https://github.com/mohamedadel452/CSharp-Basics04-Assigment)** | المصفوفات (1D & 2D Arrays) وتمرير المعاملات للدوال (Value / ref / out / params) | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/CSharp-Basics04-Assigment/blob/master/Study_Guide/CSharp_Basics_Session04_Guide.html) |
| **04** | `01_CSharp_Basics` | **[`CSharp-Basics05-Assigment`](https://github.com/mohamedadel452/CSharp-Basics05-Assigment)** | محددات الوصول (Access Modifiers)، التغليف، والـ Enums | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/CSharp-Basics05-Assigment/blob/master/Study_Guide/CSharp_Basics_Session05_Guide.html) |
| **05** | `02_OOP` | **[`OOP-Session-01-Assigment`](https://github.com/mohamedadel452/OOP-Session-01-Assigment)** | الـ Struct، التغليف، الخصائص، والـ Indexers (نظام Smart Delivery) | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/OOP-Session-01-Assigment/blob/master/Study_Guide/OOP_Session01_Deep_Dive.html) |
| **06** | `02_OOP` | **[`OOP-Session-02-Assigment`](https://github.com/mohamedadel452/OOP-Session-02-Assigment)** | الفئات (Classes)، الوراثة، وتسلسل الـ Constructors (Smart Delivery Part 1) | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/OOP-Session-02-Assigment/blob/master/Study_Guide/OOP_Session02_Deep_Dive.html) |
| **07** | `02_OOP` | **[`OOP-Session-03-Assigment`](https://github.com/mohamedadel452/OOP-Session-03-Assigment)** | تعدد الأشكال (Polymorphism)، الربط الديناميكي، والكلاسات المختومة (Sealed) | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/OOP-Session-03-Assigment/blob/master/Study_Guide/OOP_Session03_04_Dispatch_&_SOLID_Deep_Dive.html) |
| **08** | `02_OOP` | **[`OOP-Session-04-Assigment`](https://github.com/mohamedadel452/OOP-Session-04-Assigment)** | التجريد (Abstraction)، الفئات المجردة، والواجهات (Smart Delivery Part 3) | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/OOP-Session-04-Assigment/blob/master/Study_Guide/OOP_Session04_Deep_Dive.html) |
| **09** | `02_OOP` | **[`OOP-Session-05-Assigment`](https://github.com/mohamedadel452/OOP-Session-05-Assigment)** | نسخ الكائنات، Static، دوال التوسيع، والـ Partial Classes (Smart Delivery Final) | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/OOP-Session-05-Assigment/blob/master/Study_Guide/OOP_Session05_Deep_Dive.html) |
| **10** | `03_Advanced_CSharp` | **[`Advanced-CSharp-01`](https://github.com/mohamedadel452/Advanced-CSharp-01)** | الأنواع المعممة (Generics)، القيود (Constraints)، والـ Variance | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/Advanced-CSharp-01/blob/master/Study_Guide/Generics_Deep_Part1_Core.html) |
| **11** | `03_Advanced_CSharp` | **[`Advanced-CSharp-02`](https://github.com/mohamedadel452/Advanced-CSharp-02)** | المفوضات (Delegates)، تعبيرات Lambda، ونظام ShopMaster | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/Advanced-CSharp-02/blob/master/Study_Guide/Delegates_Part1_Core.html) |
| **12** | `03_Advanced_CSharp` | **[`Advanced-CSharp-03`](https://github.com/mohamedadel452/Advanced-CSharp-03)** | معمارية هياكل البيانات والـ Collections (6 أنظمة تطبيقية) | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/Advanced-CSharp-03/blob/master/Study_Guide/session03-part1-collections-list.html) |
| **13** | `04_Database` | **[`Database-Session-01-Assigment`](https://github.com/mohamedadel452/Database-Session-01-Assigment)** | تصميم قواعد البيانات، مخططات الـ ERD، والتحويل العلائقي (Relational Mapping) | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/Database-Session-01-Assigment/blob/master/Study_Guide/ERD_Part1_Design_Intro.html) |

---

## 🚀 طريقة التشغيل المحلي (How to Run)

```bash
git clone https://github.com/mohamedadel452/Advanced-CSharp-03.git
cd Advanced-CSharp-03
dotnet run --project "Advanced-CSharp-03/Advanced-CSharp-03.csproj"
```

**إعداد وتطوير:** [محمد عادل محمد بيومي (mohamedadel452)](https://github.com/mohamedadel452) — كلية الحاسبات والمعلومات، جامعة عين شمس.

</div>
