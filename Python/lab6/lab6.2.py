import matplotlib.pyplot as plt
import numpy as np


circle1 = plt.Circle((4, 8), 1, color='r')
circle2 = plt.Circle((4, 8), 0.5, color='g')

plt.gca().add_patch(circle1)
plt.gca().add_patch(circle2)
plt.show()