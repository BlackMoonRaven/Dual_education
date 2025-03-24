class Upgreite:
    def __init__(self, name, ups, bonus, cost):
        self.name = name
        self.ups = ups
        self.cost = cost
        self.bonus = bonus

    def Avto(self):
        print(f"Прокачка - {self.name} Робить - {self.ups} Бонусний ефект! - {self.bonus} Коштуе - {self.cost}")

bonus_mouse = Upgreite("Додаткова мишка", "+ 1 за клік!", "Немае бонусного ефекту(а ви чого чекали від найдешевшої тварини", "10 Клік-Поінтів")
bonus_cat = Upgreite("Додадкова кішка", "+ 2 за клік", "Посилюе усіх мишок (+ 1 за кішку)", "100 Клік-Поінтів")
bonus_dog = Upgreite("Додаткова собака", "+ 5 за клік","Він може добувати дерево!", "300 Клік-Поінтів")
bonus_elefant = Upgreite("Додатковий слон", "+ 50 за клік","Йому потрібено мінімум 1 кішка, а ще він посилюе кішку на + 5 за слона", "500 Клік-Поінтів")

class Byer:
    def __init__(self, name, cost):
        self.name = name
        self.cost = cost

    def Wood(self):
        print(f"Предмет - {self.name}, Можна продати за - {self.cost}")

wood = Byer("Дерево", "10")
pasiv_wood = Byer("Обробленне Дерево", "50")
pasiv_test_wood = Byer("Обтесне Дерево", "100")
stone_wood = Byer("Кам'яне Дерево", "500")

a = 10