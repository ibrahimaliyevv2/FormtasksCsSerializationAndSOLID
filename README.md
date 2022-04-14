# FormtasksCsSerializationAndSOLID

Task-1:

Employee class
- Id
- Name
- Salary
- ShowInfo()

Department
- Id
- Name
- Employees list
- AddEmployee() - employee obyekti qebul edecek
- GetEmployeeById() - id qebul edecek
- RemoveEmployee() - id qebul edecek


Program class
Files folder-i yaradırsız içindədə Database.json deyə bir file yaradırsız amma database.json-u
yaratmamışdan qabaq yoxlayırsız bu adda file yoxdursa yaradır

Menu
1. Add employee
2. Get employee by id
3. Remove employee id
0. Quit

1-ci əməliyyatda istifadəçidən employee-nin bütün məlumatları istənəcək yeni bir employee
obyekti yaranacaq və add methodu vasitəsilə listə əlavə oluncaq daha sonra həmin listi
json-a serialize edəcəksiniz və həmin serialize olunmuş obyekti database.json faylına əlavə
edəcəksiniz.

2-ci əməliyyatda istidaçi bir id daxil edəcək daha sonra database.json faylının oxuyacaqsız
axıra qədər ordan gələn string-i deserialize edəcəksizin department obyektinə və GetEmployeeById
methodu vasitəsilə həmin id-li employee obyektini tapacaqsız

3-cü əməliyyatda isə yenə 2 ci əməliyyatdakı kimi database.json oxunacaq deserialize olunacaq
department obyektinə həmin idli employee tapılacaq və listdən silinəcək daha sonra həmin depatment
yenidən obyekti serialize olunacaq json-a və database.json file-na yazılacaq.
