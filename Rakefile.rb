require 'rubygems'
require 'FileUtils'
require 'yaml'

desc "Configuration"
task :config do	
	@proj = Dir.pwd.split("/")[-1]
	if File.exists?("Rakefile.ini")
		@cfg = YAML.load_file("Rakefile.ini")
		# Settings
		@backup = @cfg['settings']['backup']
		@enscript = @cfg['settings']['enscript']
		@zip = @cfg['settings']['zip']
		@gs = @cfg['settings']['gs']
		# Tools / Settings
		# enscript
		@param1 = @cfg['options']['enscript']['opt']
		# gs		
		@param2 = @cfg['options']['gs']['opt']
		# excludes
		@excludes = @cfg['options']['excludes']
	else
		puts "Error loading file: #{cfile}"
	end
end

#################### PROJECT ########################

desc "Backup project"
task :backup => [:config] do
	Dir.mkdir(@backup) if !File.exists?(@backup)
	bup = "#{@backup}/#{@proj}_#{Time.now.strftime("%d%m%y")}.7z"
	#Clear backup
	File.delete(bup) if File.exist?(bup)
	#~ #Make backup
	system("#{@zip} a #{bup} *.* -r")
end

desc "Distribution"
task :dist => [:config] do
	Dir.mkdir("dist") if !File.exists?("dist")
	#~ # Make distribution	
	system("#{@zip} a -tzip ./dist/#{@proj}.zip ./master/bin/Release/*.* -r")
end

#################### DOCUMENTATION ########################

desc "Create documentation"
task :doc => [:config] do
	Dir.mkdir("doc") if !File.exists?("doc") 
	Dir.chdir("master")
	File.open("header.txt", "w+") do |f|
		f.puts "\n" * 3
		f.puts "DOCUMENTATION (Source)"
		f.puts "=" * 25
		f.puts "\nProject: #{@proj}"
		f.puts "\nFolder: #{Dir.pwd}"
		f.puts "\nStatus: #{Time.now.strftime("%d.%m.%Y")}"
		f.puts "\n-----------------------------------\n"
		Dir["*.*"].sort.each do |f1|
			if !@excludes.include?(File.extname(f1)) && !f1.include?("Designer")
				if f1 != "header.txt" && !File.directory?(f1)
					dt = File.mtime(f1).strftime("%d.%m.%Y %H:%M")
					fline = File.readlines(f1)[0]
					f.puts "#{f1}\t#{dt}\t#{fline}"
				end
			end
		end
	end 
	system(@enscript + " -B -j -r -fCourier-Bold12 -p ../doc/1header.ps header.txt")
	Dir["*.*"].sort.each do |f2|
		if !@excludes.include?(File.extname(f2)) && !f2.include?("Designer")
			if f2 != "header.txt" && !File.directory?(f2)
				system(@enscript + @param1 + "../doc/#{f2}.ps #{f2}")
			end
		end
	end
	#~ # Make PDF
	Dir.chdir("../doc")
	files = "SFXmaker.pdf "
	Dir["*.ps"].sort.each { |ps| files << "#{ps} " }
	system(@gs + @param2 + "#{@proj}_Doc.pdf #{files}")
	Dir["*.ps"].each { |ps| File.delete(ps)  if File.exist?(ps) }
	system("start #{@proj}_Doc.pdf")
end
