import matplotlib.pyplot as plt

def read_data(filename):
    n_values = []
    err_values = []
    with open(filename, 'r') as file:
        for line in file:
            line = line.strip()
            if line and not line.startswith('#'):
                parts = line.split()
                n = int(parts[0])
                err = float(parts[1].replace(',', '.'))
                n_values.append(n)
                err_values.append(err)
    return n_values, err_values

def plot_err_vs_n(n_values, err_values, output_file='plot.png'):
    plt.figure(figsize=(10, 6))
    plt.plot(n_values, err_values, 'bo-', label='err(n)')
    
    plt.yscale('log')
    
    plt.xlabel('n', fontsize=12)
    plt.ylabel('err (log scale)', fontsize=12)
    plt.title('Зависимость ошибки err от параметра n', fontsize=14)
    plt.grid(True, which="both", linestyle='--', alpha=0.6)
    plt.legend()
    
    plt.savefig(output_file, dpi=300, bbox_inches='tight')
    plt.close()

if __name__ == "__main__":
    input_filename = 'data.txt'
    output_filename = 'plot.png'
    
    n_values, err_values = read_data(input_filename)
    plot_err_vs_n(n_values, err_values, output_filename)
    
    print(f"График успешно сохранен в файл {output_filename}")