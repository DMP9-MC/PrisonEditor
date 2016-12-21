package co.uk.dmp9software.prisonread;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.util.Map;

import java.util.Base64;
import java.util.HashMap;

import me.sirfaizdat.prison.core.Prison;
import me.sirfaizdat.prison.mines.SerializableMine;
import me.sirfaizdat.prison.mines.entities.Block;
import me.sirfaizdat.prison.ranks.SerializableRank;

public class PrisonRead {
	public static void main(String[] args) {
		if (args.length < 2)
		{
			System.out.println("Psst. This is for Prison Data Editor to use, not you.");
			return;
		}
		else if (args.length >= 2)
		{
			if (args[0].equalsIgnoreCase("--read-mine"))
			{
				File file = new File(args[1]);
                FileInputStream fileIn = null;
				try {
					fileIn = new FileInputStream(file);
				} catch (FileNotFoundException e) {
					System.out.print("1");
					e.printStackTrace();
				}
                ObjectInputStream in = null;
				try {
					in = new ObjectInputStream(fileIn);
				} catch (IOException e) {
					System.out.print("2");
					e.printStackTrace();
				}
				SerializableMine sm = null;
                try {
					sm = (SerializableMine) in.readObject();
				} catch (ClassNotFoundException e) {
					System.out.print("3");
					e.printStackTrace();
				} catch (IOException e) {
					System.out.print("2");
					e.printStackTrace();
				}
                try {
                in.close();
                fileIn.close();
                } catch (IOException e) {
					System.out.print("2");
					e.printStackTrace();
                }
                String n = System.getProperty("line.separator");
                String output = "";
                output += "Name="+sm.name+n+"WorldName="+sm.world+n+"MinX="+sm.minX+n+"MinY="+sm.minY+n+"MinZ="+sm.minZ+n+"MaxX="+sm.maxX+n+"MaxY="+sm.maxY+n+"MaxZ="+sm.maxZ;
                for (Map.Entry<String, Block> e : sm.blocks.entrySet())
                {
                	output += n+"Block="+e.getKey()+","+e.getValue().getChance();
                }
                output = Base64.getEncoder().encodeToString(output.getBytes());
                System.out.print("0"+output);
			}
			else if (args[0].equalsIgnoreCase("--write-mine"))
			{
				if (args.length < 3)
				{
					System.out.println("Psst. This is for Prison Data Editor to use, not you.");
					return;
				}
				String input = new String(Base64.getDecoder().decode(args[2]));
				String[] formattedMine = input.split(System.getProperty("line.separator"));
				SerializableMine sm = new SerializableMine();
				sm.blocks = new HashMap<>();
				for (String s : formattedMine){
					String key = s.split("=")[0];
					String value = s.split("=")[1];
					if (key.equalsIgnoreCase("Name")){sm.name = value;}
					else if (key.equalsIgnoreCase("WorldName")){sm.world = value;}
					else if (key.equalsIgnoreCase("MinX")) {sm.minX = Integer.parseInt(value);}
					else if (key.equalsIgnoreCase("MinY")) {sm.minY = Integer.parseInt(value);}
					else if (key.equalsIgnoreCase("MinZ")) {sm.minZ = Integer.parseInt(value);}
					else if (key.equalsIgnoreCase("MaxX")) {sm.maxX = Integer.parseInt(value);}
					else if (key.equalsIgnoreCase("MaxY")) {sm.maxY = Integer.parseInt(value);}
					else if (key.equalsIgnoreCase("MaxZ")) {sm.maxZ = Integer.parseInt(value);}
					else if (key.equalsIgnoreCase("Block")) {Block b = new Block(Integer.parseInt(value.split(",")[0].split(":")[0]),Short.parseShort(value.split(",")[0].split(":")[1]));b.setChance(Double.parseDouble(value.split(",")[1]));sm.blocks.put(value.split(",")[0], b);}
				}
	            FileOutputStream out = null;
				try {
					out = new FileOutputStream(args[1]);
				} catch (FileNotFoundException e) {
					System.out.print("1");
					e.printStackTrace();
				}
	            ObjectOutputStream oOut = null;
				try {
					oOut = new ObjectOutputStream(out);
				} catch (IOException e) {
					System.out.print("2");
					e.printStackTrace();
				}
	            try {
					oOut.writeObject(sm);
				} catch (IOException e) {
					System.out.print("2");
					e.printStackTrace();
				}
	            try {
					oOut.close();
				} catch (IOException e) {
					System.out.print("2");
					e.printStackTrace();
				}
	            try {
					out.close();
				} catch (IOException e) {
					System.out.print("2");
					e.printStackTrace();
				}
	            System.out.println("0");
			}
			else if (args[0].equalsIgnoreCase("--read-rank"))
			{
				File file = new File(args[1]);
                FileInputStream fileIn = null;
				try {
					fileIn = new FileInputStream(file);
				} catch (FileNotFoundException e) {
					System.out.print("1");
					e.printStackTrace();
				}
                ObjectInputStream in = null;
				try {
					in = new ObjectInputStream(fileIn);
				} catch (IOException e) {
					System.out.print("2");
					e.printStackTrace();
				}
				SerializableRank sm = null;
                try {
					sm = (SerializableRank) in.readObject();
				} catch (ClassNotFoundException e) {
					System.out.print("3");
					e.printStackTrace();
				} catch (IOException e) {
					System.out.print("2");
					e.printStackTrace();
				}
                try {
                in.close();
                fileIn.close();
                } catch (IOException e) {
					System.out.print("2");
					e.printStackTrace();
                }
                String n = System.getProperty("line.separator");
                String output = "";
                output = Base64.getEncoder().encodeToString(("Id="+sm.id+n+"Name="+sm.name+n+"Price="+sm.price+n+"Prefix="+sm.prefix).getBytes());
                System.out.print("0"+output);
			}
			else if (args[0].equalsIgnoreCase("--write-rank"))
			{
				if (args.length < 3)
				{
					System.out.println("Psst. This is for Prison Data Editor to use, not you.");
					return;
				}
				String input = new String(Base64.getDecoder().decode(args[2]));
				String[] formattRank = input.split(System.getProperty("line.separator"));
				SerializableRank sm = new SerializableRank();
				for (String s : formattRank)
				{
					String key = s.split("=")[0];
					String value = s.split("=")[1];
					if (key.equalsIgnoreCase("Id")){sm.id=Integer.parseInt(value);}
					else if (key.equalsIgnoreCase("Name")){sm.name = value;}
					else if (key.equalsIgnoreCase("Price")){sm.price = Double.parseDouble(value);}
					else if (key.equalsIgnoreCase("Prefix")){sm.prefix = value;}
				}
				FileOutputStream out = null;
				try {
					out = new FileOutputStream(args[1]);
				} catch (FileNotFoundException e) {
					System.out.print("1");
					e.printStackTrace();
				}
	            ObjectOutputStream oOut = null;
				try {
					oOut = new ObjectOutputStream(out);
				} catch (IOException e) {
					System.out.print("2");
					e.printStackTrace();
				}
	            try {
					oOut.writeObject(sm);
				} catch (IOException e) {
					System.out.print("2");
					e.printStackTrace();
				}
	            try {
					oOut.close();
				} catch (IOException e) {
					System.out.print("2");
					e.printStackTrace();
				}
	            try {
					out.close();
				} catch (IOException e) {
					System.out.print("2");
					e.printStackTrace();
				}
	            System.out.print("0");
			}
			else
			{
				System.out.println("Psst. This is for Prison Data Editor to use, not you.");
				return;
			}
		}
	}
}
